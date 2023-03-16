using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace SOR4_Swapper
{
    public class Thumbnails
    {
        const string SerializationClass = "Microsoft.Xna.Framework.Content.Texture2DReader";
        public class TextureInfo
        {
            public string name;
            public UInt32 offset;
            public UInt32 flags;
            public UInt32 length;
            public string datafile;
            public bool changed;
            public bool original = true;
        }

        public readonly List<TextureInfo> thumbnails = new List<TextureInfo>();
        public readonly Dictionary<string, TextureInfo> thumbnailKeys = new Dictionary<string, TextureInfo>();
        public readonly Dictionary<string, FileStream> DataFiles = new Dictionary<string, FileStream>();

        public byte[] LoadTextureData(TextureInfo textureInfo)
        {
            if (textureInfo.datafile == null)
                return null;

            byte[] data = new byte[textureInfo.length];
            var datafile = DataFiles[textureInfo.datafile];
            if (datafile == null)
                datafile = DataFiles[textureInfo.datafile] = new FileStream(textureInfo.datafile, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            lock (datafile)    // Not needed?
            {
                datafile.Seek(textureInfo.offset, SeekOrigin.Begin);
                datafile.Read(data, 0, (int)textureInfo.length);
            }
            return data;
        }

        public Bitmap LoadTexture(TextureInfo textureInfo)
        {
            return Load(textureInfo, LoadTextureData(textureInfo));
        }

        public static Bitmap Load(TextureInfo textureInfo, byte[] data)
        {
            var filename = Path.GetFileName(textureInfo.name);
            var output = new MemoryStream();
            output.Seek(0, SeekOrigin.Begin);
            output.SetLength(0);
            var stream = new DeflateStream(new MemoryStream(data, false), CompressionMode.Decompress);
            stream.CopyTo(output);
            var uncompressedSize = output.Position;
            output.Seek(0, SeekOrigin.Begin);
            var reader = new BinaryReader(output);

            // Check signature
            var signature = Encoding.UTF8.GetString(reader.ReadBytes(4));
            if (signature != "XNBw")
            {
                Console.WriteLine($"{filename} has an unknown signature: {signature}");
                return null;
            }

            // Check version number
            int versionHi = reader.ReadByte();
            int versionLo = reader.ReadByte();
            if (versionHi != 5 || versionLo != 0)
            {
                Console.WriteLine($"{filename} has an unknown version code: {versionHi}.{versionLo}");
                return null;
            }

            // Check file size
            uint fileSize = reader.ReadUInt32();
            if (fileSize != uncompressedSize)
            {
                Console.WriteLine($"{filename} has the wrong length {fileSize} encoded, should be {uncompressedSize}");
                return null;
            }

            // Check items count
            byte itemsCount = reader.ReadByte();
            if (itemsCount == 0)
            {
                Console.WriteLine($"{filename} is empty");
                return null;
            }
            if (itemsCount != 1)
            {
                Console.WriteLine($"{filename} contains more than one item");
            }

            // Check serialization class name
            string classname = reader.ReadString();
            if (classname != SerializationClass)
            {
                Console.WriteLine($"{filename} uses an unknown class {classname}");
                return null;
            }
            var unknown0 = reader.ReadUInt32();            // Always 0
            var unknown1 = reader.ReadUInt16();            // Always 256

            // Read texture header, check format
            uint format = reader.ReadUInt32();
            int width = reader.ReadInt32();
            int height = reader.ReadInt32();
            int levelCount = reader.ReadInt32();           // Level count (for mipmaps)
            int dataSize = reader.ReadInt32();             // Uncompressed data size
            if (format != 0)
            {
                Console.WriteLine($"{filename} uses an unsupported format {format}");
                return null;
            }
            if (dataSize != width * height * 4)
            {
                Console.WriteLine($"{filename} has a wrong data size ({dataSize} instead of {width * height * 4})");
                return null;
            }

            // Load texture data, convert Argb to Abgr for Bitmap()
            var image = new Bitmap(width, height);
            var bmpData = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            IntPtr ptr = bmpData.Scan0; 
            var line = new byte[width * 4];
            for (int y = 0; y < height; y++)
            {
                reader.Read(line, 0, width * 4);
                for (int x = 0; x < width * 4; x += 4)
                {
                    byte b = line[x + 0];
                    line[x + 0] = line[x + 2];
                    line[x + 2] = b;
                    if (line[x + 3] < line[x] || line[x + 3] < line[x + 1] || line[x + 3] < line[x + 2])
                        Console.WriteLine($"{filename} has non-premultiplied alpha!");
                }
                Marshal.Copy(line, 0, ptr, width * 4);
                ptr += bmpData.Stride;
            }
            image.UnlockBits(bmpData);
            return image;
        }


        public void InitializeThumbnails(string gameDir)
        {
            try
            {
                List<string> indexes = new() { "", "02", "08" };
                foreach (string fileIndex in indexes)
                {
                    string imagefilename = Path.Combine(gameDir, $"textures{fileIndex}");
                    string imagetablefilename = Path.Combine(gameDir, $"texture_table{fileIndex}");

                    if (File.Exists(imagefilename) && File.Exists(imagetablefilename))
                    {
                        DataFiles[imagefilename] = new FileStream(imagefilename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                        GenerateList(imagetablefilename, imagefilename);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void GenerateList(string filename, string datafile)
        {
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            BinaryReader imagereader = new BinaryReader(file, Encoding.Unicode);

            try
            {
                while (true)
                {
                    //string assetName = imagereader.ReadString().Replace('/', Path.DirectorySeparatorChar);
                    string assetName = imagereader.ReadString();
                    TextureInfo imageinfo = new TextureInfo()
                    {
                        name = assetName,
                        offset = imagereader.ReadUInt32(),
                        flags = imagereader.ReadUInt32(),
                        length = imagereader.ReadUInt32(),
                        datafile = datafile,
                    };
                    foreach (KeyValuePair<int, Library.Character> asset in Library.characterDictionary)
                    {
                        if ((asset.Value.Thumbnail != "") && assetName.Contains(asset.Value.Thumbnail))
                        {
                            if (!thumbnailKeys.ContainsKey(asset.Value.Thumbnail))
                            {
                                thumbnailKeys.Add(asset.Value.Thumbnail, imageinfo);
                                thumbnails.Add(imageinfo);
                            }
                        }
                    }
                    foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
                    {
                        if ((asset.Value.Thumbnail != "") && assetName.Contains(asset.Value.Thumbnail))
                        {
                            if (!thumbnailKeys.ContainsKey(asset.Value.Thumbnail))
                            {
                                thumbnailKeys.Add(asset.Value.Thumbnail, imageinfo);
                                thumbnails.Add(imageinfo);
                            }
                        }
                    }
                    foreach (KeyValuePair<int, Library.Destroyable> asset in Library.destroyableDictionary)
                    {
                        if ((asset.Value.Thumbnail != "") && assetName.Contains(asset.Value.Thumbnail))
                        {
                            if (!thumbnailKeys.ContainsKey(asset.Value.Thumbnail))
                            {
                                thumbnailKeys.Add(asset.Value.Thumbnail, imageinfo);
                                thumbnails.Add(imageinfo);
                            }
                        }
                    }
                    foreach (KeyValuePair<int, Library.Level> asset in Library.levelDictionary)
                    {
                        if ((asset.Value.Thumbnail != "") && assetName.Contains(asset.Value.Thumbnail))
                        {
                            if (!thumbnailKeys.ContainsKey(asset.Value.Thumbnail))
                            {
                                thumbnailKeys.Add(asset.Value.Thumbnail, imageinfo);
                                thumbnails.Add(imageinfo);
                            }
                        }
                    }
                }
            }
            catch (EndOfStreamException)
            {

            }
        }

        public Bitmap getThumbnail(string mode, int itemIndex)
        {
            Bitmap thumbBitmap;
            string thumbString = "";
            switch (mode)
            {
                case "character":
                    thumbString = Library.characterDictionary[itemIndex].Thumbnail;
                    break;
                case "item":
                    thumbString = Library.itemDictionary[itemIndex].Thumbnail;
                    break;
                case "destroyable":
                    thumbString = Library.destroyableDictionary[itemIndex].Thumbnail;
                    break;
                case "level":
                    thumbString = Library.levelDictionary[itemIndex].Thumbnail;
                    break;
            }
            if (thumbString != "")
            {
                if (thumbnailKeys.ContainsKey(thumbString))
                {
                    TextureInfo textureInfo = thumbnailKeys[thumbString];
                    thumbBitmap = LoadTexture(textureInfo);
                }
                else
                {
                    thumbBitmap = new Bitmap(80, 80);
                }
            }
            else
            {
                thumbBitmap = new Bitmap(80, 80);
            }
            return thumbBitmap;
        }

    }
}
