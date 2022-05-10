using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using SOR4GameExplorer;
using System.Net.Http;
using System.Globalization;
using System.Threading.Tasks;

namespace SOR4_Swapper
{
    public partial class MainWindow : Form
    {
        // internal variables
        public Assembly imageAssembly = Assembly.GetExecutingAssembly();

        // class references
        public Library classlib = new Library();
        public Thumbnails thumbnailslib = new Thumbnails();
        BigfileExplorer bigfileClass;

        // accessible by BigfileExplorer
        public string originalReferenceForBigfile;

        // window stuff
        public int initialWindowWidth;
        public int fullWindowWidth;
        public Point lastLocation;

        public bool hasNoPending = true;

        public Container container;
        public Info info;
        public Swapper swapper;
        public Randomizer randomizer;
        public SwapListPanel swaplistpanel;
        public SwapListItemPanel swaplistitempanel;
        public SwapListDestroyablePanel swaplistdestroyablepanel;
        public SwapListLevelPanel swaplistlevelpanel;
        public SwapperItems swapperitems;
        public RandomizerItems randomizeritems;
        public SwapperDestroyables swapperdestroyables;
        public RandomizerDestroyables randomizerdestroyables;
        public SwapperLevels swapperlevels;
        public RandomizerLevels randomizerlevels;
        public RandomizerPresets randomizerpresets;
        public Instructions instructions;
        public DifficultyScreen difficultyscreen;
        public OwnerDetails ownerdetailsscreen;
        public CustomizerCharacters charactercustomizerscreen;
        public CustomizerLevels levelcustomizerscreen;
        public CharacterCustomizerPanel charactercustomizerpanel;
        public string screenmode = "characters";
        public string functionmode = "swapper";

        public bool updateAvailable = false;
        string updateurl = "https://raw.githubusercontent.com/honganqi/SOR4CharacterSwapper/main/latest.json";
        string downloadURL = "";

        public MainWindow()
        {
            InitializeComponent();

            initialWindowWidth = Width;
            fullWindowWidth = 1070;

            // panels
            container = new Container(this)
            {
                TopLevel = false,
                TopMost = true
            };
            info = new Info(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swapper = new Swapper(this)
            {
                TopLevel = false,
                TopMost = true
            };
            randomizer = new Randomizer(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swaplistpanel = new SwapListPanel(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swaplistitempanel = new SwapListItemPanel(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swaplistdestroyablepanel = new SwapListDestroyablePanel(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swaplistlevelpanel = new SwapListLevelPanel(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swapperitems = new SwapperItems(this)
            {
                TopLevel = false,
                TopMost = true
            };
            randomizeritems = new RandomizerItems(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swapperdestroyables = new SwapperDestroyables(this)
            {
                TopLevel = false,
                TopMost = true
            };
            randomizerdestroyables = new RandomizerDestroyables(this)
            {
                TopLevel = false,
                TopMost = true
            };
            swapperlevels = new SwapperLevels(this)
            {
                TopLevel = false,
                TopMost = true
            };
            randomizerlevels = new RandomizerLevels(this)
            {
                TopLevel = false,
                TopMost = true
            };
            randomizerpresets = new RandomizerPresets(this)
            {
                TopLevel = false,
                TopMost = true
            };
            instructions = new Instructions(this)
            {
                TopLevel = false,
                TopMost = true
            };
            difficultyscreen = new DifficultyScreen(this)
            {
                TopLevel = false,
                TopMost = true
            };
            ownerdetailsscreen = new OwnerDetails(this)
            {
                TopLevel = false,
                TopMost = true
            };
            charactercustomizerscreen = new CustomizerCharacters(this)
            {
                TopLevel = false,
                TopMost = true
            };
            levelcustomizerscreen = new CustomizerLevels(this)
            {
                TopLevel = false,
                TopMost = true
            };
            charactercustomizerpanel = new CharacterCustomizerPanel(this)
            {
                TopLevel = false,
                TopMost = true
            };
            container.panelInfo.Controls.Add(info);
            info.Show();
            panelInstructions.Controls.Add(instructions);
            instructions.Show();
            panelSwapList.Controls.Add(swaplistpanel);
            swaplistpanel.Show();
            container.panelDifficulty.Controls.Add(difficultyscreen);
            difficultyscreen.Show();
            container.panelOwner.Controls.Add(ownerdetailsscreen);
            ownerdetailsscreen.Show();
            panelLeft.BackColor = Color.FromArgb(33, 33, 33);
            btnMinimize.BackColor = Color.FromArgb(33, 33, 33);
            btnClose.BackColor = Color.FromArgb(33, 33, 33);

            string currentVerString = Application.ProductVersion;
            List<string> currentVersionSplit = currentVerString.Split('.').ToList();
            if (currentVersionSplit[3] == "0") currentVersionSplit.RemoveAt(3);
            if (currentVersionSplit[2] == "0") currentVersionSplit.RemoveAt(2);
            labelVerNum.Text = "v" + string.Join(".", currentVersionSplit) + " by honganqi";

            bigfileClass = classlib.bigfileClass;

            // populate comboboxes with data
            foreach (KeyValuePair<int, Library.Character> asset in Library.characterDictionary)
            {
                swapper.characterList.Items.Insert(asset.Key, asset.Value.Name);
                swapper.replacementComboBox.Items.Insert(asset.Key, asset.Value.Name);
                charactercustomizerscreen.characterList.Items.Insert(asset.Key, asset.Value.Name);
                classlib.characterPathToIndex[asset.Value.Path] = asset.Key;
            }

            foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
            {
                swapperitems.cmbItemOriginalList.Items.Insert(asset.Key, asset.Value.Name);
                swapperitems.cmbItemReplacementList.Items.Insert(asset.Key, asset.Value.Name);
                classlib.itemPathToIndex[asset.Value.Path] = asset.Key;
            }

            foreach (KeyValuePair<int, Library.Destroyable> asset in Library.destroyableDictionary)
            {
                swapperdestroyables.cmbItemOriginalList.Items.Insert(asset.Key, asset.Value.Name);
                swapperdestroyables.cmbItemReplacementList.Items.Insert(asset.Key, asset.Value.Name);
                classlib.destroyablePathToIndex[asset.Value.Path] = asset.Key;
            }

            foreach (KeyValuePair<int, Library.Level> asset in Library.levelDictionary)
            {
                swapperlevels.cmbItemOriginalList.Items.Insert(asset.Key, asset.Value.Name);
                swapperlevels.cmbItemReplacementList.Items.Insert(asset.Key, asset.Value.Name);
                classlib.levelPathToIndex[asset.Value.Path] = asset.Key;
            }

            Stream thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.bmc.png");
            Bitmap thumbBitmap = new Bitmap(thumbStream);
            container.imgBMCSupport.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.sflogo.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgSF.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.youtube.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgYoutube.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.twitch.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgTwitch.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.open.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnOpenBigfile.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.random.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnShowRandomPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.swapper.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnShowSwapperPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.customize.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnShowCustomizer.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.load.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnLoadSwap.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.difficulty.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnDifficultyPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.author.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnOwnerPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.save.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnSaveSwap.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.help.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnInstructions.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.exit.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnClose.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.min.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnMinimize.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Swapper.img.listshadow.png");
            thumbBitmap = new Bitmap(thumbStream);
            imgListShadow.BackgroundImage = thumbBitmap;

            panelContainer.Controls.Add(container);
            container.Show();
            panelInstructions.Controls.Add(instructions);
            instructions.Show();
            panelInstructions.Visible = false;

            classlib.CreateSwapTable(this);

            // set DataGridView DoubleBuffered to TRUE to remove flickering caused by repainting when mouse hovers over the remove button and changes color
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            swaplistpanel.dataGridView1, new object[] { true });

            if ((Properties.Settings.Default.bigfilePath != "") && File.Exists(Properties.Settings.Default.bigfilePath))
            {
                // get path from settings
                classlib.bigfilePath = Properties.Settings.Default.bigfilePath;
                // get directory from path
                classlib.gameDir = Path.GetDirectoryName(classlib.bigfilePath);
                // reassign the default bigfile path to "bigfile"
                classlib.bigfilePath = Path.Combine(classlib.gameDir, "bigfile");
                swapper.characterList.Enabled = true;
                swapper.replacementComboBox.Enabled = true;
                //swapper.btnSetItem.Enabled = true;
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;

                thumbnailslib.InitializeThumbnails(classlib.gameDir);
                if (classlib.CheckBigfile(classlib.bigfilePath))
                {
                    info.labelValidBigfile.Text = $"original v{classlib.gameVerString} bigfile";
                    info.labelValidBigfile.ForeColor = Color.ForestGreen;
                    if (!File.Exists(Path.Combine(classlib.gameDir, classlib.backup_filename)))
                    {
                        string backup_filename = classlib.CreateBackup();
                        info.labelBackupMade.Text = $"A backup file named \"{ backup_filename}\" was created.";
                        info.labelBackupMade.Visible = true;
                    }
                    else
                    {
                        info.labelBackupMade.Visible = false;
                    }
                }
                else
                {
                    info.labelValidBigfile.Text = $"modded v{classlib.gameVerString} bigfile";
                    info.labelValidBigfile.ForeColor = Color.Crimson;
                    if (!File.Exists(Path.Combine(classlib.gameDir, classlib.backup_filename)))
                    {
                        string backup_filename = classlib.CreateBackup();
                        info.labelBackupMade.Text = $"A backup file named \"{ backup_filename}\" was created.";
                        info.labelBackupMade.Visible = true;
                    }
                    else
                    {
                        info.labelBackupMade.Visible = false;
                    }
                    //labelBackupMade.Text = "A backup named \"bigfile_custom_backup\" will be made.";
                    info.labelBackupMade.Visible = false;
                }

                info.labelValidBigfile.Visible = true;
                classlib.gameDir = Path.GetDirectoryName(classlib.bigfilePath);

                info.labelBigfileLocationInfo.Text = "Loaded file:\n" + classlib.bigfilePath;
                classlib.bigfileClass.bigfilePath = classlib.bigfilePath;

                Initialize();

                ResetForm();
            }

            CheckUpdate(updateurl);
        }

        public async void CheckUpdate(string url)
        {
            List<string> onlineVer = new();
            List<string> currentVer = new();
            var client = new HttpClient();
            var request = client.GetAsync(url);

            Task timeout = Task.Delay(3000);
            await Task.WhenAny(timeout, request);

            try
            {
                HttpResponseMessage response = request.Result;
                if (response.IsSuccessStatusCode)
                {
                    var page = response.Content.ReadAsStringAsync();
                    var queryResult = Newtonsoft.Json.JsonConvert.DeserializeObject<Library.VersionClass>(page.Result);

                    if ((queryResult != null) && (queryResult.ReleaseDate != null))
                    {
                        DateTime releaseDate = DateTime.Parse(queryResult.ReleaseDate).ToUniversalTime();
                        string onlineVerString = queryResult.Version;
                        string currentVerString = Application.ProductVersion;
                        downloadURL = queryResult.DownloadURL;
                        if (onlineVerString.CompareTo(currentVerString) > 0)
                        {
                            List<string> versionSplit = onlineVerString.Split('.').ToList();
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            onlineVer.Add(string.Join(".", versionSplit));
                            onlineVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            container.btnUpdateNotif.Text = "v" + onlineVer[0] + " is now available!\nGET IT NOW!";
                            if (queryResult.Description != "")
                            {
                                ToolTip updateTooltip = new();
                                updateTooltip.SetToolTip(container.btnUpdateNotif, "Download from: " + queryResult.DownloadURL + "\n\n" + queryResult.Description);
                            }

                            versionSplit = new(currentVerString.Split('.').ToList());
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            currentVer.Add(string.Join(".", versionSplit));
                            currentVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            container.btnUpdateNotif.Show();
                        }
                    }
                }
                else
                {
                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NotFound:
                            throw new Exception("The update file was not found on the server.");
                        case System.Net.HttpStatusCode.BadRequest:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.InternalServerError:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.MethodNotAllowed:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.Forbidden:
                            throw new Exception("");
                    }
                }
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void GetUpdate()
        {
            if (downloadURL != "") System.Diagnostics.Process.Start(downloadURL);
        }

        private void Initialize()
        {
            string originalBigfilePath = classlib.bigfilePath;
            string backupFilename = Path.Combine(classlib.gameDir, classlib.backup_filename);

            if (File.Exists(backupFilename))
            {
                bigfileClass.bigfilePath = backupFilename;
            }
            classlib.characterCustomizationInMemory = new();

            bigfileClass.Initialize();


            // initialize shader combobox in customizer
            string[] shaderStrings = { "Normal", "Shiva Double", "Elite", "Motion Blur", "Doppelganger" };
            int shaderComboIndex = 0;
            foreach (var item in bigfileClass.shaderStrings)
            {
                charactercustomizerscreen.cmbShader.Items.Add(shaderStrings[shaderComboIndex++]);
            }

            // add levels to level customizer
            foreach (var levelClass in Library.levelDictionary)
            {
                if (levelClass.Value.Path != "n/a")
                {
                    levelcustomizerscreen.dgvLevelSettings.Rows.Add(levelClass.Value.Name, bigfileClass.levelCollection[levelClass.Key].Teams, levelClass.Key);
                }
            }

            // if CheckBigFile fails, probably modded
            // reassign bigfilePath to backup to fetch all original data
            if (classlib.CheckBigfile(classlib.bigfilePath))
            {
                bigfileClass.bigfilePath = classlib.bigfilePath;
            }
            else
            if (File.Exists(backupFilename))
            {
                bigfileClass.bigfilePath = backupFilename;
            }

            // character names
            foreach (KeyValuePair<int, CharacterClass> charClass in classlib.bigfileClass.characterCollection)
            {
                string customNameIndex = Library.characterDictionary[charClass.Key].CustomNameIndex;
                string nameFromOriginalIndex;
                if (bigfileClass.customCharacterNames.ContainsKey(charClass.Value.NameIndex))
                {
                    nameFromOriginalIndex = classlib.bigfileClass.customCharacterNames[charClass.Value.NameIndex];
                }
                else
                {
                    nameFromOriginalIndex = charClass.Value.NameIndex;
                }
                charClass.Value.Name = nameFromOriginalIndex;
                charClass.Value.NewName = nameFromOriginalIndex;
                charClass.Value.SwapNameIndex = customNameIndex;
                classlib.customCharacterNames[customNameIndex] = nameFromOriginalIndex;
            }

            int lastDiffIndex = 0;
            foreach (KeyValuePair<int, DifficultyClass> asset in bigfileClass.difficultyCollection)
            {
                if (asset.Key <= 5)
                {
                    difficultyscreen.cmbDifficultyCollection.Items.Insert(asset.Key, asset.Value.Name);
                    lastDiffIndex = asset.Key;
                }
            }
            difficultyscreen.difficultyJustArrived = true;
            difficultyscreen.txtDifficultyName.Text = "CUSTOM";
            Dictionary<string, CharacterClass> globalCharacterSettings = new()
            { 
                ["playables"] = new()
                {
                    MoveSpeed = 100
                },
                ["enemies"] = new()
                {
                    MoveSpeed = 100
                }
            };
            difficultyscreen.LoadSettings(bigfileClass.difficultyCollection[lastDiffIndex], bigfileClass.gameplayConfigData, globalCharacterSettings);
            difficultyscreen.cmbDifficultyCollection.SelectedIndex = lastDiffIndex;
            difficultyscreen.difficultyJustArrived = false;
            difficultyscreen.txtDifficultyName.Text = "CUSTOM";

            classlib.bigfilePath = originalBigfilePath;
        }

        public void ResetForm()
        {
            if (classlib.CheckBigfile(classlib.bigfilePath) || File.Exists(classlib.bigfilePath))
            {
                // load buttons in a specific order to simulate tabs
                //3.Visible = true;
                btnLoadSwap.Show();
                btnSaveSwap.Show();
                btnShowSwapperPanel.Show();
                btnShowRandomPanel.Show();
                btnShowCustomizer.Show();
                btnDifficultyPanel.Show();
                btnOwnerPanel.Show();
                info.btnRestoreBigfile.Show();
                if (functionmode != "custom")
                {
                    container.panelDivider.Show();
                    container.btnCharPanel.Show();
                    container.btnItemPanel.Show();
                    container.btnDestroyablesPanel.Show();
                    container.btnLevelPanel.Show();
                    //container.btnPresetsPanel.Visible = true;
                }
                container.btnStartReplace.Show();
                container.btnClearAllSwaps.Show();

                // maybe reselect the thumbnail after a reset?
                if (swapper.characterList.SelectedIndex > -1) thumbnailslib.getThumbnail("character", swapper.characterList.SelectedIndex);
                if (swapper.replacementComboBox.SelectedIndex > -1) thumbnailslib.getThumbnail("character", swapper.replacementComboBox.SelectedIndex);
                if (swapperitems.cmbItemOriginalList.SelectedIndex > -1) thumbnailslib.getThumbnail("item", swapperitems.cmbItemOriginalList.SelectedIndex);
                if (swapperitems.cmbItemReplacementList.SelectedIndex > -1) thumbnailslib.getThumbnail("item", swapperitems.cmbItemReplacementList.SelectedIndex);
                if (swapperdestroyables.cmbItemOriginalList.SelectedIndex > -1) thumbnailslib.getThumbnail("destroyable", swapperdestroyables.cmbItemOriginalList.SelectedIndex);
                if (swapperdestroyables.cmbItemReplacementList.SelectedIndex > -1) thumbnailslib.getThumbnail("destroyable", swapperdestroyables.cmbItemReplacementList.SelectedIndex);
                if (swapperlevels.cmbItemOriginalList.SelectedIndex > -1) thumbnailslib.getThumbnail("level", swapperlevels.cmbItemOriginalList.SelectedIndex);
                if (swapperlevels.cmbItemReplacementList.SelectedIndex > -1) thumbnailslib.getThumbnail("level", swapperlevels.cmbItemReplacementList.SelectedIndex);

                // if nothing is displayed after initialization, load the swapper panel as the default panel
                if (container.panelMain.Controls.Count == 0)
                {
                    container.panelMain.Controls.Add(swapper);
                    swapper.Show();
                }

                // if bigfile exists and is valid, disable bigfile-related buttons
                if (classlib.CheckBigfile(Path.Combine(classlib.gameDir, "bigfile")))
                {
                    info.btnRestoreBigfile.Enabled = false;
                    //info.btnExtractSwaps.Enabled = false;
                }
                else
                {
                    info.btnRestoreBigfile.Enabled = true;
                    //info.btnExtractSwaps.Enabled = true;
                }

                if ((classlib.changeList.Count > 0) || (classlib.itemChangeList.Count > 0) || (classlib.destroyableChangeList.Count > 0) || (classlib.levelChangeList.Count > 0))
                {
                    container.btnStartReplace.Enabled = true;
                    container.btnClearAllSwaps.Enabled = true;
                    container.labelPending.Show();
                    if (classlib.changeList.Count > 0)
                    {
                        swapper.btnShowList.Enabled = true;
                        randomizer.btnShowList.Enabled = true;
                        swapper.btnClearSwapList.Enabled = true;
                        randomizer.btnClearSwapList.Enabled = true;
                    }
                    else
                    {
                        swapper.btnShowList.Enabled = false;
                        randomizer.btnShowList.Enabled = false;
                        swapper.btnClearSwapList.Enabled = false;
                        randomizer.btnClearSwapList.Enabled = false;
                    }
                    if (classlib.itemChangeList.Count > 0)
                    {
                        swapperitems.btnShowList.Enabled = true;
                        randomizeritems.btnShowList.Enabled = true;
                        swapperitems.btnClearSwapList.Enabled = true;
                        randomizeritems.btnClearSwapList.Enabled = true;

                    }
                    else
                    {
                        swapperitems.btnShowList.Enabled = false;
                        randomizeritems.btnShowList.Enabled = false;
                        swapperitems.btnClearSwapList.Enabled = false;
                        randomizeritems.btnClearSwapList.Enabled = false;
                    }
                    if (classlib.destroyableChangeList.Count > 0)
                    {
                        swapperdestroyables.btnShowList.Enabled = true;
                        randomizerdestroyables.btnShowList.Enabled = true;
                        swapperdestroyables.btnClearSwapList.Enabled = true;
                        randomizerdestroyables.btnClearSwapList.Enabled = true;

                    }
                    else
                    {
                        swapperdestroyables.btnShowList.Enabled = false;
                        randomizerdestroyables.btnShowList.Enabled = false;
                        swapperdestroyables.btnClearSwapList.Enabled = false;
                        randomizerdestroyables.btnClearSwapList.Enabled = false;
                    }
                    if (classlib.levelChangeList.Count > 0)
                    {
                        swapperlevels.btnShowList.Enabled = true;
                        randomizerlevels.btnShowList.Enabled = true;
                        swapperlevels.btnClearSwapList.Enabled = true;
                        randomizerlevels.btnClearSwapList.Enabled = true;

                    }
                    else
                    {
                        swapperlevels.btnShowList.Enabled = false;
                        randomizerlevels.btnShowList.Enabled = false;
                        swapperlevels.btnClearSwapList.Enabled = false;
                        randomizerlevels.btnClearSwapList.Enabled = false;
                    }
                }
                else
                {
                    container.btnStartReplace.Enabled = false;
                    container.btnStartReplace.Enabled = true;
                    container.btnClearAllSwaps.Enabled = false;
                    container.labelPending.Hide();
                    hasNoPending = true;
                }
            }

        }

        public void ApplyChanges()
        {
            string createdBackup = classlib.CreateBackup();
            string originalBigfilePath = classlib.bigfilePath;

            if (createdBackup != "") createdBackup = "\n\nA backup file named \"" + createdBackup + "\" was also created for you.";

            if (classlib.CheckBigfile(classlib.bigfilePath))
            {
                bigfileClass.bigfilePath = classlib.bigfilePath;
            }
            // reassign bigfilePath to backup to fetch all original characters
            else
            if (File.Exists(Path.Combine(classlib.gameDir, "bigfile_rep7_13648_backup")))
            {
                bigfileClass.bigfilePath = Path.Combine(classlib.gameDir, "bigfile_rep7_13648_backup");
            }

            Swaps swaps = GetValuesFromUI(true);
            if (bigfileClass.CommitChanges(swaps))
            {
                info.labelValidBigfile.Text = "modded v7 bigfile";
                info.labelValidBigfile.ForeColor = Color.Crimson;
                info.btnRestoreBigfile.Enabled = true;
                //info.btnExtractSwaps.Enabled = true;
                hasNoPending = true;
                container.labelPending.Visible = false;
                MessageBox.Show("Swaps have been applied!\n\nYou will need to restart the game if it is currently running." + createdBackup, "Awesomeness unlocked!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The currently loaded \"bigfile\" and the \"bigfile_rep_backup\" file that this app created is missing is already modded.\n\nIf you don't have a backup, you may restore your files by going to Steam > right-click Streets of Rage 4 > Properties > Local Files > Verify integrity of game files.", "Unable to find original v5 \"bigfile\" data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // return bigfilePath to true bigfile
            bigfileClass.bigfilePath = originalBigfilePath;


        }

        public Swaps GetValuesFromUI(bool applyChanges = false)
        {
            // GameplayConfigData, Difficulty, and Global Character Settings
            GameplayConfigDataClass gcd = difficultyscreen.GetGCDValues();
            DifficultyClass difficulty = difficultyscreen.GetDifficultyValues();
            Dictionary<string, CharacterClass> generalCharacterCollection = difficultyscreen.GetGlobalCharacterValues();

            // Author
            Author author = ownerdetailsscreen.GetValues(applyChanges);

            // Level Customizer
            Dictionary<int, LevelClass> levelCustomizationQueue = levelcustomizerscreen.GetValues();

            Swaps swaps = new();
            swaps.gameplayConfigDataSave = gcd;
            swaps.difficulty = difficulty;
            swaps.globalCharacterSettings = generalCharacterCollection;
            swaps.author = author;
            swaps.levelCustomizationQueue = levelCustomizationQueue;
            swaps.changeList = classlib.changeList;
            swaps.itemChangeList = classlib.itemChangeList;
            swaps.destroyableChangeList = classlib.destroyableChangeList;
            swaps.levelChangeList = classlib.levelChangeList;
            swaps.characterCustomizationQueue = classlib.characterCustomizationQueue;
            swaps.customCharacterNamesQueue = classlib.customCharacterNames;
            return swaps;
        }

        public void ClearSwaps(string mode, string function, bool fromAll = false)
        {
            bool goAhead = false;
            if (mode == "destroyable") mode = "breakable";
            string promptString = "";
            string[] list = { "character", "item", "destroyable", "level" };
            switch (function)
            {
                case "swap":
                    promptString = "swap selections";
                    break;
                case "custom":
                    promptString = "customizations";
                    break;
            }
            if (fromAll == false)
            {
                DialogResult resetAsk = MessageBox.Show("Are you sure you want to clear your " + mode + " " + promptString + "?", "Reset " + mode + " " + promptString, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resetAsk == DialogResult.Yes) goAhead = true;
            }
            else
            {
                goAhead = true;
            }
            if (mode == "all")
            {
                foreach (string item in list) ClearSwaps(item, function, true);
            } else
            {
                if (mode == "breakable") mode = "destroyable";
                if (goAhead == true)
                {
                    if (function == "custom")
                    {
                        mode = "custom" + mode.Substring(0, 1).ToUpper() + mode.Substring(1);
                    }
                    classlib.ClearTable(mode);
                    //bigfileClass.ResetSwaps(mode);
                    info.labelLoadedSwapFile.Text = "";
                    info.labelLoadedSwap.Visible = false;
                    info.labelLoadedSwapFile.Visible = false;
                    switch (mode)
                    {
                        case "character":
                            swaplistpanel.labelReplaceCount.Text = "0";
                            swaplistpanel.labelReplaceUniqueCount.Text = "0";
                            swapper.btnClearSwapList.Enabled = false;
                            randomizer.btnClearSwapList.Enabled = false;
                            break;
                        case "item":
                            swaplistitempanel.labelReplaceCount.Text = "0";
                            swaplistitempanel.labelReplaceUniqueCount.Text = "0";
                            swapperitems.btnClearSwapList.Enabled = false;
                            randomizeritems.btnClearSwapList.Enabled = false;
                            break;
                        case "destroyable":
                            swaplistdestroyablepanel.labelReplaceCount.Text = "0";
                            swaplistdestroyablepanel.labelReplaceUniqueCount.Text = "0";
                            swapperdestroyables.btnClearSwapList.Enabled = false;
                            randomizerdestroyables.btnClearSwapList.Enabled = false;
                            break;
                        case "level":
                            swaplistlevelpanel.labelReplaceCount.Text = "0";
                            swaplistlevelpanel.labelReplaceUniqueCount.Text = "0";
                            swapperlevels.btnClearSwapList.Enabled = false;
                            randomizerlevels.btnClearSwapList.Enabled = false;
                            break;
                        case "customCharacter":
                            charactercustomizerpanel.labelReplaceCount.Text = "0";
                            charactercustomizerscreen.btnClearSwapList.Enabled = false;
                            break;
                    }
                    ResetForm();
                }
            }
        }

        public void btnInstructionsClose()
        {
            panelInstructions.Visible = false;
        }

        public void ToggleSwapList(bool fullwidth)
        { 
            if (fullwidth == true)
            {
                Width = fullWindowWidth;
                ToggleShowHideListLabels(true);
            }
            else
            {
                Width = initialWindowWidth;
                ToggleShowHideListLabels(false);
            }
        }

        public void ToggleShowHideListLabels(bool show)
        {
            Control[] controls = {
                swapper.btnShowList, swapperitems.btnShowList, swapperdestroyables.btnShowList, swapperlevels.btnShowList,
                randomizer.btnShowList, randomizeritems.btnShowList, randomizerdestroyables.btnShowList, randomizerlevels.btnShowList,
                charactercustomizerscreen.btnShowList
            };
            if (show == true)
            {
                Width = fullWindowWidth;

                foreach (Control ctrlname in controls)
                {
                    ctrlname.Text = "Hide list";
                    ctrlname.Enabled = true;
                }
            }
            else
            {
                foreach (Control ctrlname in controls)
                {
                    ctrlname.Text = "Show list";
                }
            }
        }

        private bool ReadSwapFileOld(string settingsFileName)
        {
            // get bigfile MD5 hash to compare if original
            string[] lines = File.ReadAllLines(settingsFileName);
            Dictionary<string, Dictionary<int, int>> data = new Dictionary<string, Dictionary<int, int>>
            {
                ["character"] = new Dictionary<int, int>(),
                ["item"] = new Dictionary<int, int>(),
                ["destroyable"] = new Dictionary<int, int>(),
                ["level"] = new Dictionary<int, int>(),
            };
            foreach (string line in lines)
            {
                string[] replacement = line.Split(':');
                char[] charsToTrim = { 'i', 'd', 'l' };
                int original = Int32.Parse(replacement[0].Trim(charsToTrim).Trim());
                int replaceWith = Int32.Parse(replacement[1].Trim(charsToTrim).Trim());
                switch (replacement[0])
                {
                    case string item when item.Contains('i'):
                        data["item"][original] = replaceWith;
                        break;
                    case string destroyable when destroyable.Contains('d'):
                        data["destroyable"][original] = replaceWith;
                        break;
                    case string level when level.Contains('l'):
                        data["level"][original] = replaceWith;
                        break;
                    default:
                        data["character"][original] = replaceWith;
                        break;
                }
            }
            if (data.Count() > 0)
            {
                RefreshSwapList(data);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid settings file!", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public void RefreshSwapList(Dictionary<string, Dictionary<int, int>> data)
        {
            // clear all swaps if swap file contains category
            foreach (KeyValuePair<string, Dictionary<int, int>> categories in data)
            {
                if (categories.Value.Count() > 0)
                {
                    classlib.ClearTable(categories.Key);
                    foreach (KeyValuePair<int, int> pair in categories.Value)
                    {
                        if (pair.Key != pair.Value) classlib.AddToList(this, categories.Key, pair.Key, pair.Value);
                    }
                }
            }
            ResetForm();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("Yeah?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exitAsk == DialogResult.No);
        }

        private void btnOpenBigfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string bigfilePath = openFileDialog1.FileName;
                classlib.gameDir = Path.GetDirectoryName(bigfilePath);
                swapper.characterList.Enabled = true;
                swapper.replacementComboBox.Enabled = true;
                //swapper.btnSetItem.Enabled = true;
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;
                if (classlib.CheckBigfile(bigfilePath))
                {
                    if (!File.Exists(Path.Combine(classlib.gameDir, classlib.backup_filename)))
                    {
                        string backup_filename = classlib.CreateBackup();
                        info.labelBackupMade.Text = $"A backup file named \"{ backup_filename}\" was created.";
                        info.labelBackupMade.Visible = true;
                    }
                    else
                    {
                        info.labelBackupMade.Visible = false;
                    }
                }
                else
                {
                    info.labelValidBigfile.Text = "modded v7 bigfile";
                    info.labelValidBigfile.ForeColor = Color.Crimson;
                    //labelBackupMade.Text = "A backup named \"bigfile_custom_backup\" will be made.";
                    info.labelBackupMade.Visible = false;
                }

                classlib.gameDir = Path.GetDirectoryName(bigfilePath);
                thumbnailslib.InitializeThumbnails(classlib.gameDir);

                if (File.Exists(bigfilePath))
                {
                    classlib.bigfilePath = bigfilePath;
                    Properties.Settings.Default.bigfilePath = classlib.bigfilePath;
                    Properties.Settings.Default.Save();
                }
                info.labelBigfileLocationInfo.Text = "Loaded file:\n" + bigfilePath;
                info.labelValidBigfile.Visible = true;
                bigfileClass = classlib.bigfileClass;
                classlib.bigfileClass.bigfilePath = classlib.bigfilePath;
                Initialize();
                ResetForm();
                container.panelInfo.Controls.Clear();
                container.panelInfo.Controls.Add(info);
                info.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            ChangeFunction("custom");
        }

        private void btnShowSwapperPanel_Click(object sender, EventArgs e)
        {
            ChangeFunction("swapper");
        }

        private void btnShowRandomPanel_Click(object sender, EventArgs e)
        {
            ChangeFunction("randomizer");
        }

        private void btnDifficultyPanel_Click(object sender, EventArgs e)
        {
            btnInstructionsClose();
            container.panelDifficulty.Visible = true;
            container.panelDifficulty.BringToFront();
        }

        public void ChangeFunction(string functionmode)
        {
            this.functionmode = functionmode;
            btnInstructionsClose();
            container.panelDifficulty.Hide();
            container.panelOwner.Hide();
            if (functionmode == "custom")
            {
                labelDisplayList.Text = "CUSTOMIZATION List";
            }
            else
            {
                labelDisplayList.Text = "REPLACEMENT List";
            }
            container.SwitchTabs(screenmode);
        }
        public void ExecuteRandomPreset(int preset, bool battleRoyaleMode)
        {
            string questionString = "";
            switch (preset)
            {
                case 1:
                    questionString = "Are you sure you want to randomize using the \"MAXX CHAOS\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
                case 2:
                    questionString = "Are you sure you want to randomize using the \"CRAZY Chaos\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
                case 3:
                    questionString = "Are you sure you want to randomize using the \"Scared? Chaos!\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
                case 4:
                    questionString = "Are you sure you want to randomize using the \"Some chaos, boss?\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
                case 5:
                    questionString = "Are you sure you want to randomize using the \"Baby Steps Chaos\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
                case 6:
                    questionString = "Are you sure you want to randomize using the \"Pretend chaos\" preset?\n\n" +
                        randomizerpresets.chaosOneTooltipText;
                    break;
            }

            DialogResult randomAsk = MessageBox.Show(questionString, "Randomize with preset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (randomAsk == DialogResult.Yes)
            {

                switch (preset)
                {
                    case 1:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = false;
                        randomizer.checkBossToBoss.Checked = false;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = false;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = false;
                        RandomizePeople("enemies");

                        // Pickups
                        RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = false;
                        randomizeritems.checkGoldToGold.Checked = false;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("everything");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = false;
                        RandomizeLevels("playables");
                        // Survival levels
                        RandomizeLevels("survival");
                        break;
                    case 2:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = false;
                        randomizer.checkBossToBoss.Checked = true;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = false;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = false;
                        RandomizePeople("enemies");

                        // Pickups
                        RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = false;
                        randomizeritems.checkGoldToGold.Checked = false;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("everything");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = false;
                        RandomizeLevels("playables");
                        // Survival levels
                        RandomizeLevels("survival");
                        break;
                    case 3:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = false;
                        randomizer.checkBossToBoss.Checked = true;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = true;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = false;
                        RandomizePeople("enemies");

                        // Pickups
                        //RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = false;
                        randomizeritems.checkGoldToGold.Checked = false;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("everything");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = true;
                        RandomizeLevels("playables");
                        // Survival levels
                        RandomizeLevels("survival");
                        break;
                    case 4:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = false;
                        randomizer.checkBossToBoss.Checked = true;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = true;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = true;
                        RandomizePeople("enemies");

                        // Pickups
                        //RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = false;
                        randomizeritems.checkGoldToGold.Checked = true;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("everything");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = true;
                        RandomizeLevels("playables");
                        // Survival levels
                        RandomizeLevels("survival");
                        break;
                    case 5:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = false;
                        randomizer.checkBossToBoss.Checked = true;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = true;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = true;
                        RandomizePeople("enemies");

                        // Pickups
                        //RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = true;
                        randomizeritems.checkGoldToGold.Checked = true;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("regulars");
                        RandomizeDestroyables("destructive");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = true;
                        RandomizeLevels("playables");
                        // Survival levels
                        RandomizeLevels("survival");
                        break;
                    case 6:
                        // Characters
                        randomizer.checkIgnoreBoss.Checked = true;
                        randomizer.checkBossToBoss.Checked = true;
                        randomizer.checkIgnoreMiniboss.Checked = false;
                        randomizer.checkMiniToMini.Checked = true;
                        randomizer.checkIgnoreRegularplus.Checked = false;
                        randomizer.checkRegplusToRegplus.Checked = true;
                        RandomizePeople("enemies");

                        // Pickups
                        //RandomizeItems("pickups");

                        // Weapons
                        randomizeritems.checkIgnoreGolden.Checked = true;
                        randomizeritems.checkGoldToGold.Checked = true;
                        RandomizeItems("weapons");

                        // Breakables
                        RandomizeDestroyables("regulars");
                        RandomizeDestroyables("destructive");

                        // Story Levels
                        randomizerlevels.checkIgnoreBossRush.Checked = true;
                        // RandomizeLevels("playables");
                        // Survival levels
                        // RandomizeLevels("survival");
                        break;
                }

                if (battleRoyaleMode)
                {
                    int teamIterator = 3;
                    foreach (KeyValuePair<int, Library.Character> charData in Library.characterDictionary)
                    {
                        if (charData.Value.Path != "n/a")
                        {
                            int assetKey = charData.Key;
                            int targetKey = assetKey;

                            // initialize characterClass with original character's original attributes
                            CharacterClass characterClass = new(bigfileClass.characterCollection[assetKey]);

                            // if character is found in swap list, change characterClass into swap target's original attributes
                            if (classlib.changeList.ContainsKey(assetKey)) {
                                targetKey = classlib.changeList[assetKey];
                                characterClass = new(bigfileClass.characterCollection[targetKey]);
                            }

                            // if character is found in customization list
                            if (classlib.characterCustomizationQueue.ContainsKey(assetKey))
                            {
                                characterClass = new(classlib.characterCustomizationQueue[assetKey]);
                            }

                            characterClass.Team = teamIterator;

                            // if character has an entry in "memory" but not yet added to list
                            if (!classlib.characterCustomizationInMemory.ContainsKey(assetKey))
                            {
                                classlib.characterCustomizationInMemory[assetKey] = characterClass;
                            }
                            classlib.AddCustom(this, "character", assetKey, characterClass);
                            foreach (DataGridViewRow dr in levelcustomizerscreen.dgvLevelSettings.Rows)
                            {
                                dr.Cells["teams"].Value = true;
                            }
                            teamIterator++;
                        }

                    }
                    
                }
                ResetForm();
                MessageBox.Show("Randomization complete.\n\nHit \"Apply changes\" if you want to try it out in the game. You may also visit the tabs and \"Show list\" if you want to check the swaps.", "Preset Randomization complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("That's ok. Take your time...", "Preset Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void RandomizePeople(string target)
        {
            Random randomObj = new();
            int randomValue;

            List<int> randomList = Library.characterDictionary.Keys.ToList();
            List<int> bossList = new(randomList);
            List<int> minibossList = new(randomList);
            List<int> regularplusList = new(randomList);
            List<int> regularList = new(randomList);

            // remove all characters based on conditions
            foreach (KeyValuePair<int, Library.Character> asset in Library.characterDictionary)
            {
                if ((target == "enemies") && asset.Value.IsPlayable)
                {
                    regularList.Remove(asset.Key);
                    randomList.Remove(asset.Key);
                }
                if (asset.Value.IsBoss)
                {
                    // if bosses are locked OR 
                    if (randomizer.checkIgnoreBoss.Checked || randomizer.checkBossToBoss.Checked)
                    {
                        randomList.Remove(asset.Key);
                    }
                    else if (!asset.Value.ReplaceRegs)
                    {
                        randomList.Remove(asset.Key);
                    }
                }
                if (asset.Value.IsMiniboss)
                {
                    if (randomizer.checkIgnoreMiniboss.Checked || randomizer.checkMiniToMini.Checked)
                    {
                        randomList.Remove(asset.Key);
                    }
                    else if (!asset.Value.ReplaceRegs)
                    {
                        randomList.Remove(asset.Key);
                    }
                }
                if (asset.Value.IsRegularPlus)
                {
                    if (randomizer.checkIgnoreRegularplus.Checked || randomizer.checkRegplusToRegplus.Checked)
                    {
                        randomList.Remove(asset.Key);
                    }
                    else if (!asset.Value.ReplaceRegs)
                    {
                        randomList.Remove(asset.Key);
                    }
                }
                if (!asset.Value.IsBoss! && !asset.Value.IsMiniboss && !asset.Value.IsRegularPlus)
                {
                    if (randomizer.checkIgnoreRegular.Checked || randomizer.checkRegularToRegular.Checked)
                    {
                        randomList.Remove(asset.Key);
                    }
                    else if (!asset.Value.ReplaceRegs)
                    {
                        randomList.Remove(asset.Key);
                    }
                }
                if (asset.Value.IsExcluded)
                {
                    randomList.Remove(asset.Key);
                    bossList.Remove(asset.Key);
                    minibossList.Remove(asset.Key);
                    regularplusList.Remove(asset.Key);
                    regularList.Remove(asset.Key);
                }
                if (classlib.changeList.ContainsKey(asset.Key)) randomList.Remove(asset.Key);
                if (!asset.Value.IsBoss) bossList.Remove(asset.Key);
                if (!asset.Value.IsMiniboss || (asset.Value.IsMiniboss && !asset.Value.ReplaceRegs)) minibossList.Remove(asset.Key);
                if (!asset.Value.IsRegularPlus) regularplusList.Remove(asset.Key);
                if (asset.Value.IsBoss || asset.Value.IsMiniboss || asset.Value.IsRegularPlus) regularList.Remove(asset.Key);
            }

            foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
            {
                // consider only if:
                // 1. if target is "enemies" and current character is NOT playable
                // 2. if target is "everybody" (NOT enemies only)
                // 3. if Ignore Boss is checked and current character is NOT boss
                // 4. if Ignore Miniboss is checked and current character is NOT miniboss
                // 5. if character is NOT excluded
                if ((((target == "enemies") && !character.Value.IsPlayable) || (target != "enemies")) &&
                    (!randomizer.checkIgnoreBoss.Checked || (randomizer.checkIgnoreBoss.Checked && !character.Value.IsBoss)) &&
                    (!randomizer.checkIgnoreMiniboss.Checked || (randomizer.checkIgnoreMiniboss.Checked && !character.Value.IsMiniboss)) &&
                    (!randomizer.checkIgnoreRegularplus.Checked || (randomizer.checkIgnoreRegularplus.Checked && !character.Value.IsRegularPlus)) &&
                    !character.Value.IsExcluded &&
                    !classlib.changeList.ContainsKey(character.Key)
                    )
                {
                    if (character.Value.IsBoss)
                    {
                        if (!randomizer.checkIgnoreBoss.Checked)
                        {
                            // if boss-to-boss
                            // OR if !boss-to-boss and character is NOT replaceable by a regular
                            // pick from BossList
                            if (randomizer.checkBossToBoss.Checked || (!randomizer.checkBossToBoss.Checked && !character.Value.ReplacedByRegs))
                            {
                                randomValue = randomObj.Next(0, bossList.Count());
                                classlib.AddToList(this, "character", character.Key, bossList[randomValue]);
                                if (!randomizer.allowDuplicates.Checked)
                                {
                                    bossList.RemoveAt(randomValue);
                                }
                            }
                            // else if character IS replaceable by a regular
                            // pick from randomList but this should have been pruned by the loop above
                            else
                            {
                                randomValue = randomObj.Next(0, randomList.Count());
                                classlib.AddToList(this, "character", character.Key, randomList[randomValue]);
                                if (!randomizer.allowDuplicates.Checked)
                                {
                                    bossList.Remove(randomList[randomValue]);
                                    randomList.RemoveAt(randomValue);
                                }
                            }

                        }

                    }
                    else
                    if (character.Value.IsMiniboss && !randomizer.checkIgnoreMiniboss.Checked && randomizer.checkMiniToMini.Checked)
                    {
                        if (minibossList.Count() > 0)
                        {
                            randomValue = randomObj.Next(0, minibossList.Count());
                            classlib.AddToList(this, "character", character.Key, minibossList[randomValue]);
                            if (!randomizer.allowDuplicates.Checked)
                            {
                                randomList.Remove(minibossList[randomValue]);
                                minibossList.RemoveAt(randomValue);
                            }
                        }
                    }
                    else
                    if (character.Value.IsRegularPlus && !randomizer.checkIgnoreRegularplus.Checked && randomizer.checkRegplusToRegplus.Checked)
                    {
                        randomValue = randomObj.Next(0, regularplusList.Count());
                        classlib.AddToList(this, "character", character.Key, regularplusList[randomValue]);
                        if (!randomizer.allowDuplicates.Checked)
                        {
                            randomList.Remove(regularplusList[randomValue]);
                            regularplusList.RemoveAt(randomValue);
                        }
                    }
                    else
                    if (!character.Value.IsBoss && !character.Value.IsMiniboss && !character.Value.IsRegularPlus && !randomizer.checkIgnoreRegular.Checked && randomizer.checkRegularToRegular.Checked)
                    {
                        randomValue = randomObj.Next(0, regularList.Count());
                        classlib.AddToList(this, "character", character.Key, regularList[randomValue]);
                        if (!randomizer.allowDuplicates.Checked)
                        {
                            randomList.Remove(regularList[randomValue]);
                            regularList.RemoveAt(randomValue);
                        }
                    }
                    else
                    {
                        if (randomList.Count() > 0)
                        {
                            randomValue = randomObj.Next(0, randomList.Count());
                            classlib.AddToList(this, "character", character.Key, randomList[randomValue]);

                            if (!randomizer.allowDuplicates.Checked)
                            {
                                bossList.Remove(randomList[randomValue]);
                                randomList.RemoveAt(randomValue);
                            }

                        }
                    }
                }
            }

            swaplistpanel.dataGridView1.Visible = true;
        }

        public void RandomizeItems(string target)
        {
            Random randomObj = new();
            int randomValue;

            List<int> randomList = Library.itemDictionary.Keys.ToList();
            List<int> goldenList = new (randomList);

            // remove all characters based on conditions
            foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
            {
                // if target is pickups, remove all weapons from randomization
                if ((target == "pickups") && !asset.Value.IsPickup) randomList.Remove(asset.Key);
                if ((target == "weapons") && !asset.Value.IsWeapon) randomList.Remove(asset.Key);
                if (asset.Value.IsGolden && (randomizeritems.checkIgnoreGolden.Checked || randomizeritems.checkGoldToGold.Checked))
                    randomList.Remove(asset.Key);
                if (asset.Value.IsExcluded) randomList.Remove(asset.Key);
                if (classlib.itemChangeList.ContainsKey(asset.Key)) randomList.Remove(asset.Key);
                if (!asset.Value.IsGolden) goldenList.Remove(asset.Key);
            }

            foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
            {
                // consider only if:
                // 1. if target is "enemies" and current character is NOT playable
                // 2. if target is "everybody" (NOT enemies only)
                // 3. if Ignore Boss is checked and current character is NOT boss
                // 4. if Ignore Miniboss is checked and current character is NOT miniboss
                // 5. if character is NOT excluded   
                if (
                    ((target == "pickups") && asset.Value.IsPickup) ||
                    ((target == "weapons") && asset.Value.IsWeapon) &&
                    !asset.Value.IsExcluded &&
                    !classlib.itemChangeList.ContainsKey(asset.Key)
                    )
                {
                    if (asset.Value.IsGolden && !randomizeritems.checkIgnoreGolden.Checked && randomizeritems.checkGoldToGold.Checked)
                    {
                        randomValue = randomObj.Next(0, goldenList.Count());
                        classlib.AddToList(this, "item", asset.Key, goldenList[randomValue]);
                        if (!randomizeritems.allowDuplicates.Checked)
                        {
                            randomList.Remove(goldenList[randomValue]);
                            goldenList.RemoveAt(randomValue);
                        }
                    }
                    else
                    {
                        if (randomList.Count > 0)
                        {
                            randomValue = randomObj.Next(0, randomList.Count());
                            classlib.AddToList(this, "item", asset.Key, randomList[randomValue]);
                            if (!randomizeritems.allowDuplicates.Checked) randomList.RemoveAt(randomValue);
                        }
                    }
                }
            }
            swaplistitempanel.dataGridView2.Visible = true;
        }

        public void RandomizeDestroyables(string target)
        {
            Random randomObj = new();
            int randomValue;

            List<int> randomList = Library.destroyableDictionary.Keys.ToList();

            foreach (KeyValuePair<int, Library.Destroyable> asset in Library.destroyableDictionary)
            {
                switch (target)
                {
                    case "regulars":
                        if (asset.Value.IsDestructive || asset.Value.IsUnbreakable || asset.Value.IsExcluded) randomList.Remove(asset.Key);
                        break;
                    case "destructive":
                        if (!asset.Value.IsDestructive) randomList.Remove(asset.Key);
                        break;
                    default:
                        if (asset.Value.IsExcluded) randomList.Remove(asset.Key);
                        break;
                }
            }

            List<int> newRandomList = new List<int>(randomList);

            foreach (int key in randomList)
            {
                randomValue = randomObj.Next(0, newRandomList.Count());
                classlib.AddToList(this, "destroyable", key, newRandomList[randomValue]);
                if (!randomizerdestroyables.allowDuplicates.Checked) newRandomList.RemoveAt(randomValue);
            }
            swaplistdestroyablepanel.dataGridView2.Visible = true;
        }

        public void RandomizeLevels(string target)
        {
            Random randomObj = new Random();
            int randomValue;

            List<int> randomList = Library.levelDictionary.Keys.ToList();

            foreach (KeyValuePair<int, Library.Level> asset in Library.levelDictionary)
            {
                switch (target)
                {
                    case "playables":
                        if ((!asset.Value.IsStory && !asset.Value.IsChallenge && !asset.Value.IsBossRush) || (randomizerlevels.checkIgnoreBossRush.Checked && asset.Value.IsBossRush) || asset.Value.IsExcluded)
                            randomList.Remove(asset.Key);
                        break;
                    case "survival":
                        if (!asset.Value.IsSurvival || asset.Value.IsExcluded) randomList.Remove(asset.Key);
                        break;
                    default:
                        if (asset.Value.IsExcluded) randomList.Remove(asset.Key);
                        break;
                }
            }

            List<int> newRandomList = new List<int>(randomList);

            foreach (int key in randomList)
            {
                randomValue = randomObj.Next(0, newRandomList.Count());
                classlib.AddToList(this, "level", key, newRandomList[randomValue]);
                if (!randomizerlevels.allowDuplicates.Checked) newRandomList.RemoveAt(randomValue);
            }
            swaplistlevelpanel.dataGridView2.Visible = true;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            panelInstructions.Visible = true;
        }

        private void btnInstructionsClose_Click(object sender, EventArgs e)
        {
            btnInstructionsClose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // window movement stuff
        public void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            //lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //lastLocation = e.Location;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void labelAuthor_MouseDown(object sender, MouseEventArgs e)
        {
           // lastLocation = e.Location;
        }

        private void labelAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void btnOwnerPanel_Click(object sender, EventArgs e)
        {
            btnInstructionsClose();
            container.panelOwner.Visible = true;
            container.panelOwner.BringToFront();
        }

        private void SaveSettings(string filename)
        {
            Swaps swaps = GetValuesFromUI(false);
            swaps.Save(Application.ProductVersion, filename);
            info.labelLoadedSwapFile.Text = Path.GetFileName(filename);
            info.labelLoadedSwap.Text = "Swap list saved:";
            info.labelLoadedSwap.Visible = true;
            info.labelLoadedSwapFile.Visible = true;
        }

        private void btnSaveSwap_Click(object sender, EventArgs e)
        {
            string settingsFileName = "bigfile_swapper_settings_" + DateTime.Now.ToString("yyyyMMdd") + ".swap";
            SaveFileDialog fd = new SaveFileDialog
            {
                Filter = "Swapper Settings|*.swap",
                Title = "Save Settings",
                FileName = settingsFileName
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // If the file name is not an empty string open it for saving.
                if (fd.FileName != "")
                {
                    SaveSettings(fd.FileName);
                }
            }
            
        }

        private void btnLoadSwap_Click(object sender, EventArgs e)
        {
            if (ofdLoadDialog.ShowDialog() == DialogResult.OK)
            {
                bool pushthrough_v4 = false;
                DialogResult cont = MessageBox.Show("All unsaved changes will be lost. Continue?", "Load swap file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cont == DialogResult.Yes)
                {
                    string settingsFilename = ofdLoadDialog.FileName;
                    Swaps swapSettings = new(settingsFilename);

                    classlib.ClearTable("character", swaplistpanel);
                    classlib.ClearTable("item", swaplistitempanel);
                    classlib.ClearTable("destroyable", swaplistdestroyablepanel);
                    classlib.ClearTable("level", swaplistlevelpanel);
                    classlib.ClearTable("customCharacter", charactercustomizerpanel);

                    // character names
                    foreach (KeyValuePair<int, CharacterClass> charClass in classlib.bigfileClass.characterCollection)
                    {
                        string customNameIndex = Library.characterDictionary[charClass.Key].CustomNameIndex;
                        string nameFromOriginalIndex;
                        if (bigfileClass.customCharacterNames.ContainsKey(charClass.Value.NameIndex))
                        {
                            nameFromOriginalIndex = classlib.bigfileClass.customCharacterNames[charClass.Value.NameIndex];
                        }
                        else
                        {
                            nameFromOriginalIndex = charClass.Value.NameIndex;
                        }
                        classlib.customCharacterNames[customNameIndex] = nameFromOriginalIndex;
                    }

                    string currentVerString = Application.ProductVersion;
                    string swapVerString = "";
                    List<string> currentVer = new();
                    List<string> swapVer = new();

                    try
                    {
                        Dictionary<string, string> settings = swapSettings.Load();
                        if (settings != null)
                        {
                            if (settings.ContainsKey("appversion"))
                            {
                                swapVerString = settings["appversion"];
                                if (settings["appversion"] == currentVerString)
                                {
                                    pushthrough_v4 = true;
                                }
                                else
                                {
                                    List<string> versionSplit = currentVerString.Split('.').ToList();
                                    if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                                    if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                                    currentVer.Add(string.Join(".", versionSplit));

                                    versionSplit = new(swapVerString.Split('.').ToList());
                                    if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                                    if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                                    swapVer.Add(string.Join(".", versionSplit));

                                    cont = MessageBox.Show($"The swap file you loaded is for a different version of SOR4 Swapper (v.{swapVer[0]}). You are currently using v.{currentVer[0]}. \n\nDo you want to continue?", "Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (cont == DialogResult.Yes) pushthrough_v4 = true;
                                }
                            }

                            if (pushthrough_v4 == true)
                            {
                                Dictionary<string, Dictionary<int, int>> swapList = swapSettings.PullSwaps();
                                foreach (KeyValuePair<string, Dictionary<int, int>> swapKeyValuePair in swapList)
                                {
                                    // needs to be copy and not reference of swaps
                                    // since we're still reading the swaps but already adding to them
                                    Dictionary<int, int> swapContents = new(swapKeyValuePair.Value);
                                    foreach (KeyValuePair<int, int> swap in swapContents)
                                    {
                                        classlib.AddToList(this, swapKeyValuePair.Key, swap.Key, swap.Value, true);
                                    }
                                }

                                Dictionary<int, CharacterClass> customList = swapSettings.characterCustomizationQueue;
                                if (customList != null)
                                {
                                    foreach (KeyValuePair<int, CharacterClass> customCharacter in customList)
                                    {
                                        // customCharacter.Value = class of customized (and replaced) character
                                        classlib.AddCustom(this, "character", customCharacter.Key, customCharacter.Value);
                                        classlib.characterCustomizationInMemory[customCharacter.Key] = customCharacter.Value;
                                        classlib.customCharacterNames[customCharacter.Value.NameIndex] = customCharacter.Value.NewName;
                                    }
                                }

                                // add levels to level customizer
                                foreach (DataGridViewRow leveldr in levelcustomizerscreen.dgvLevelSettings.Rows)
                                {
                                    int levelKey = (int)leveldr.Cells["origKey"].Value;
                                    if (swapSettings.levelCustomizationQueue != null)
                                    {
                                        if (swapSettings.levelCustomizationQueue.ContainsKey(levelKey))
                                        {
                                            leveldr.Cells["teams"].Value = swapSettings.levelCustomizationQueue[levelKey].Teams;
                                        }
                                    }
                                }

                                // very special condition for pre-4.2 and EnemySpeedMultiplier==0, reset to default of 100
                                // anything pre-v4.0 will not have difficulty anyway and will load default
                                if (swapVer.Count > 0 && ((swapVer[0] == "4.0") || (swapVer[0] == "4.1")) && (swapSettings.difficulty.EnemySpeedMultiplier == 0))
                                {
                                    swapSettings.difficulty.EnemySpeedMultiplier = 100;
                                }
                                if (swapSettings.gameplayConfigDataSave != null)
                                {
                                    difficultyscreen.LoadSettings(swapSettings.difficulty, swapSettings.gameplayConfigDataSave, swapSettings.globalCharacterSettings);
                                }
                                else
                                {
                                    difficultyscreen.LoadSettings(swapSettings.difficulty, bigfileClass.gameplayConfigData, swapSettings.globalCharacterSettings);
                                }

                                ownerdetailsscreen.LoadSettings(swapSettings.author);
                                info.labelLoadedSwapFile.Text = Path.GetFileName(settingsFilename);
                                info.labelLoadedSwap.Visible = true;
                                info.labelLoadedSwapFile.Visible = true;
                                swapper.btnClearSwapList.Enabled = true;
                                swapper.btnClearSwapList.Visible = true;
                                randomizer.btnClearSwapList.Enabled = true;
                                randomizer.btnClearSwapList.Visible = true;
                                ResetForm();
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        List<string> versionSplit = currentVerString.Split('.').ToList();
                        if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                        if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                        currentVer.Add(string.Join(".", versionSplit));
                        cont = MessageBox.Show($"The swap file you loaded is for a version of SOR4 Swapper older than v4.0. You are currently using v.{currentVer[0]}. \n\nDo you want to continue?", "Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cont == DialogResult.Yes)
                        {
                            if (ReadSwapFileOld(settingsFilename) == true)
                            {
                                info.labelLoadedSwapFile.Text = Path.GetFileName(settingsFilename);
                                info.labelLoadedSwap.Text = "Swap list loaded:";
                                info.labelLoadedSwap.Visible = true;
                                info.labelLoadedSwapFile.Visible = true;
                                swapper.btnClearSwapList.Enabled = true;
                                swapper.btnClearSwapList.Visible = true;
                                randomizer.btnClearSwapList.Enabled = true;
                                randomizer.btnClearSwapList.Visible = true;
                                ResetForm();
                            }
                        }
                    }
                }
            }
        }

    }
}
