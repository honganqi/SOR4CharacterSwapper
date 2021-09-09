using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using SOR4CharacterExplorer;


namespace SOR4_Replacer
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
        public string screenmode = "characters";
        public string functionmode = "swapper";

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
            container.panelInfo.Controls.Add(info);
            info.Show();
            panelInstructions.Controls.Add(instructions);
            instructions.Show();
            panelSwapList.Controls.Add(swaplistpanel);
            swaplistpanel.Show();
            panelLeft.BackColor = Color.FromArgb(33, 33, 33);
            btnMinimize.BackColor = Color.FromArgb(33, 33, 33);
            btnClose.BackColor = Color.FromArgb(33, 33, 33);

            bigfileClass = classlib.bigfileClass;

            // populate comboboxes with data
            foreach (KeyValuePair<int, Library.Character> asset in Library.characterDictionary)
            {
                swapper.characterList.Items.Insert(asset.Key, asset.Value.Name);
                swapper.replacementComboBox.Items.Insert(asset.Key, asset.Value.Name);
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

            Stream thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.bmc.png");
            Bitmap thumbBitmap = new Bitmap(thumbStream);
            container.imgBMCSupport.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.sflogo.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgSF.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.youtube.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgYoutube.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.twitch.png");
            thumbBitmap = new Bitmap(thumbStream);
            container.imgTwitch.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.open.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnOpenBigfile.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.random.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnShowRandomPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.load.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnLoad.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.save.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnSave.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.help.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnInstructions.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.exit.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnClose.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.min.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnMinimize.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer.img.listshadow.png");
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
                swapper.btnSetItem.Enabled = true;
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;

                thumbnailslib.InitializeThumbnails(classlib.gameDir);
                if (classlib.CheckBigfile(classlib.bigfilePath))
                {
                    info.labelValidBigfile.Text = "original v7 bigfile";
                    info.labelValidBigfile.ForeColor = Color.ForestGreen;
                    if (File.Exists(Path.Combine(classlib.gameDir, "bigfile_rep_backup")))
                    {
                        info.labelBackupMade.Visible = false;
                    }
                    else
                    {
                        info.labelBackupMade.Visible = true;
                    }
                }
                else
                {
                    info.labelValidBigfile.Text = "modded v7 bigfile";
                    info.labelValidBigfile.ForeColor = Color.Crimson;
                    //labelBackupMade.Text = "A backup named \"bigfile_custom_backup\" will be made.";
                    info.labelBackupMade.Visible = false;
                }

                info.labelValidBigfile.Visible = true;
                classlib.gameDir = Path.GetDirectoryName(classlib.bigfilePath);

                info.labelBigfileLocationInfo.Text = "Loaded file:\n" + classlib.bigfilePath;
                classlib.bigfileClass.bigfilePath = classlib.bigfilePath;
                classlib.bigfileClass.OutStuff();
                ResetForm();
            }
        }


        public void ResetForm()
        {
            if (classlib.CheckBigfile(classlib.bigfilePath) || File.Exists(classlib.bigfilePath))
            {
                // load buttons in a specific order to simulate tabs
                btnLoad.Visible = true;
                btnShowRandomPanel.Visible = true;
                info.btnRestoreBigfile.Visible = true;
                info.btnExtractSwaps.Visible = true;
                container.btnCharPanel.Visible = true;
                container.panelDivider.Visible = true;
                container.btnItemPanel.Visible = true;
                container.btnDestroyablesPanel.Visible = true;
                //container.btnPresetsPanel.Visible = true;
                container.btnLevelPanel.Visible = true;
                container.btnStartReplace.Visible = true;
                container.btnClearAllSwaps.Visible = true;

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
                    info.btnExtractSwaps.Enabled = false;
                }
                else
                {
                    info.btnRestoreBigfile.Enabled = true;
                    info.btnExtractSwaps.Enabled = true;
                }

                if ((classlib.changeList.Count > 0) || (classlib.itemChangeList.Count > 0) || (classlib.destroyableChangeList.Count > 0) || (classlib.levelChangeList.Count > 0))
                {
                    btnSave.Enabled = true;
                    btnSave.Visible = true;
                    container.btnStartReplace.Enabled = true;
                    container.btnClearAllSwaps.Enabled = true;
                    container.labelPending.Visible = true;
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
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                    container.btnStartReplace.Enabled = false;
                    container.btnClearAllSwaps.Enabled = false;
                    container.labelPending.Visible = false;
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
                Console.WriteLine("is legit");
                bigfileClass.bigfilePath = classlib.bigfilePath;
            }
            // reassign bigfilePath to backup to fetch all original characters
            else
            if (File.Exists(Path.Combine(classlib.gameDir, "bigfile_rep7_backup")))
            {
                bigfileClass.bigfilePath = Path.Combine(classlib.gameDir, "bigfile_rep7_backup");
            }

            if (bigfileClass.CommitChanges()) 
            {
                info.labelValidBigfile.Text = "modded v7 bigfile";
                info.labelValidBigfile.ForeColor = Color.Crimson;
                info.btnRestoreBigfile.Enabled = true;
                info.btnExtractSwaps.Enabled = true;
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

        public void ClearSwaps(string mode, bool fromAll = false)
        {
            bool goAhead = false;
            if (mode == "destroyable") mode = "breakable";
            if (fromAll == false)
            {
                DialogResult resetAsk = MessageBox.Show("Are you sure you want to clear your " + mode + " swap selections?", "Reset " + mode + " swaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resetAsk == DialogResult.Yes) goAhead = true;
            }
            else
            {
                goAhead = true;
            }
            if (mode == "all")
            {
                string[] list = { "character", "item", "destroyable", "level" };
                foreach (string item in list) ClearSwaps(item, true);
            } else
            {
                if (mode == "breakable") mode = "destroyable";
                if (goAhead == true)
                {
                    classlib.ClearTable(mode);
                    bigfileClass.ResetSwaps(mode);
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
                    }
                    ResetForm();
                }
            }

        }

        public void btnInstructionsClose()
        {
            panelInstructions.Visible = false;
        }

        private bool SaveToSwapFile(bool autosave = false)
        {
            string settingsFileName;
            if (autosave == true)
            {
                settingsFileName = "bigfile_swap_autosave.swap";
            }
            else
            {
                settingsFileName = "bigfile_swapper_settings_" + DateTime.Now.ToString("yyyyMMdd") + ".swap";
            }
            string[] lines = new string[0];
            string[] charLines = new string[0];
            string[] itemLines = new string[0];
            string[] destroyableLines = new string[0];
            string[] levelLines = new string[0];
            int changeCount = 0;
            if (classlib.changeList.Count() > 0)
            {
                charLines = classlib.changeList.Select(item => string.Format("{0}:{1}", classlib.characterPathToIndex[item.Key], classlib.characterPathToIndex[item.Value])).ToArray();
                changeCount += classlib.changeList.Count();
            }
            if (classlib.itemChangeList.Count() > 0)
            {
                itemLines = classlib.itemChangeList.Select(item => string.Format("i{0}:i{1}", classlib.itemPathToIndex[item.Key], classlib.itemPathToIndex[item.Value])).ToArray();
                changeCount += classlib.itemChangeList.Count();
            }
            if (classlib.destroyableChangeList.Count() > 0)
            {
                destroyableLines = classlib.destroyableChangeList.Select(item => string.Format("d{0}:d{1}", classlib.destroyablePathToIndex[item.Key], classlib.destroyablePathToIndex[item.Value])).ToArray();
                changeCount += classlib.destroyableChangeList.Count();
            }
            if (classlib.levelChangeList.Count() > 0)
            {
                levelLines = classlib.levelChangeList.Select(item => string.Format("l{0}:l{1}", classlib.levelPathToIndex[item.Key], classlib.levelPathToIndex[item.Value])).ToArray();
                changeCount += classlib.levelChangeList.Count();
            }

            lines = new string[changeCount];

            int counter = 0;
            charLines.CopyTo(lines, counter);
            counter += charLines.Count();
            itemLines.CopyTo(lines, counter);
            counter += itemLines.Count();
            destroyableLines.CopyTo(lines, counter);
            counter += destroyableLines.Count();
            levelLines.CopyTo(lines, counter);

            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Swapper Settings|*.swap";
            saveFileDialog1.Title = "Save Settings";
            saveFileDialog1.FileName = settingsFileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    FileStream settingsFile = (FileStream)saveFileDialog1.OpenFile();
                    settingsFileName = saveFileDialog1.FileName;
                    settingsFile.Close();
                }
                File.WriteAllLines(Path.Combine(classlib.gameDir, settingsFileName), lines);
                return true;
            }
            else
            {
                return false;
            }            
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
            if (show == true)
            {
                Width = fullWindowWidth;
                swapper.btnShowList.Text = "Hide list";
                swapperitems.btnShowList.Text = "Hide list";
                swapperdestroyables.btnShowList.Text = "Hide list";
                swapperlevels.btnShowList.Text = "Hide list";
                randomizer.btnShowList.Text = "Hide list";
                randomizeritems.btnShowList.Text = "Hide list";
                randomizerdestroyables.btnShowList.Text = "Hide list";
                randomizerlevels.btnShowList.Text = "Hide list";
                swapper.btnShowList.Enabled = true;
                swapperitems.btnShowList.Enabled = true;
                swapperdestroyables.btnShowList.Enabled = true;
                swapperlevels.btnShowList.Enabled = true;
                randomizer.btnShowList.Enabled = true;
                randomizeritems.btnShowList.Enabled = true;
                randomizerdestroyables.btnShowList.Enabled = true;
                randomizerlevels.btnShowList.Enabled = true;
            }
            else
            {
                swapper.btnShowList.Text = "Show list";
                swapperitems.btnShowList.Text = "Show list";
                swapperdestroyables.btnShowList.Text = "Show list";
                swapperlevels.btnShowList.Text = "Show list";
                randomizer.btnShowList.Text = "Show list";
                randomizeritems.btnShowList.Text = "Show list";
                randomizerdestroyables.btnShowList.Text = "Show list";
                randomizerlevels.btnShowList.Text = "Show list";

            }
        }

        private bool ReadSwapFile(string settingsFileName)
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
                    bigfileClass.ResetSwaps(categories.Key);
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
                swapper.btnSetItem.Enabled = true;
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;
                if (classlib.CheckBigfile(bigfilePath))
                {
                    if (!File.Exists(Path.Combine(classlib.gameDir, "bigfile_rep_backup")))
                    {
                        //labelBackupMade.Text = "A backup named \"bigfile_rep_backup\" does not exist yet. One will be created upon swapping for the first time.";
                        info.labelBackupMade.Visible = true;
                    }
                    else
                    {
                        //labelBackupMade.Text = "A backup named \"bigfile_rep_backup\" already exists and will not be overwritten until changes are made.";
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
                    Properties.Settings.Default.bigfilePath = classlib.bigfilePath;
                    Properties.Settings.Default.Save();
                }
                info.labelBigfileLocationInfo.Text = "Loaded file:\n" + bigfilePath;
                info.labelValidBigfile.Visible = true;
                ResetForm();
                container.panelInfo.Controls.Clear();
                container.panelInfo.Controls.Add(info);
                info.Show();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdLoadDialog.ShowDialog() == DialogResult.OK)
            {
                bool pushthrough = true;

                if (classlib.changeList.Count > 0)
                {
                    pushthrough = false;
                    DialogResult cont = MessageBox.Show("All unsaved changes will be lost. Continue?", "Load swap file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cont == DialogResult.Yes) pushthrough = true;
                }

                if (pushthrough == true)
                {
                    string settingsFilename = ofdLoadDialog.FileName;
                    if (ReadSwapFile(settingsFilename) == true)
                    {
                        info.labelLoadedSwapFile.Text = Path.GetFileName(ofdLoadDialog.FileName);
                        info.labelLoadedSwap.Visible = true;
                        info.labelLoadedSwapFile.Visible = true;
                        swapper.btnClearSwapList.Enabled = true;
                        swapper.btnClearSwapList.Visible = true;
                        randomizer.btnClearSwapList.Enabled = true;
                        randomizer.btnClearSwapList.Visible = true;
                    }
                }
                ResetForm();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToSwapFile();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowRandomPanel_Click(object sender, EventArgs e)
        {
            container.panelMain.Controls.Clear();
            switch (functionmode)
            {
                case "swapper":
                    btnShowRandomPanel.Text = "Swapper";
                    functionmode = "randomizer";
                    container.btnPresetsPanel.Visible = true;
                    switch (screenmode)
                    {
                        case "characters":
                            container.panelMain.Controls.Add(randomizer);
                            randomizer.Show();
                            break;
                        case "items":
                            container.panelMain.Controls.Add(randomizeritems);
                            randomizeritems.Show();
                            break;
                        case "destroyables":
                            container.panelMain.Controls.Add(randomizerdestroyables);
                            randomizerdestroyables.Show();
                            break;
                        case "levels":
                            container.panelMain.Controls.Add(randomizerlevels);
                            randomizerlevels.Show();
                            break;
                    }
                    break;
                case "randomizer":
                    btnShowRandomPanel.Text = "Randomizer";
                    functionmode = "swapper";
                    container.btnPresetsPanel.Visible = false;
                    if (screenmode == "presets")
                    {
                        screenmode = "characters";
                        container.SwitchTabs(screenmode);
                    }
                    switch (screenmode)
                    {
                        case "characters":
                            container.panelMain.Controls.Add(swapper);
                            swapper.Show();
                            break;
                        case "items":
                            container.panelMain.Controls.Add(swapperitems);
                            swapperitems.Show();
                            break;
                        case "destroyables":
                            container.panelMain.Controls.Add(swapperdestroyables);
                            swapperdestroyables.Show();
                            break;
                        case "levels":
                            container.panelMain.Controls.Add(swapperlevels);
                            swapperlevels.Show();
                            break;
                    }
                    break;
            }
        }

        public void ExecuteRandomPreset(int preset)
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
            Random randomObj = new Random();
            int randomValue;

            List<int> randomList = Library.characterDictionary.Keys.ToList();
            List<int> bossList = new List<int>(randomList);
            List<int> minibossList = new List<int>(randomList);
            List<int> regularplusList = new List<int>(randomList);

            // remove all characters based on conditions
            foreach (KeyValuePair<int, Library.Character> asset in Library.characterDictionary)
            {
                if ((target == "enemies") && asset.Value.IsPlayable) randomList.Remove(asset.Key);
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
                if (asset.Value.IsExcluded)
                {
                    randomList.Remove(asset.Key);
                    bossList.Remove(asset.Key);
                    minibossList.Remove(asset.Key);
                    regularplusList.Remove(asset.Key);
                }
                if (classlib.changeList.ContainsKey(asset.Value.Path)) randomList.Remove(asset.Key);
                if (!asset.Value.IsBoss) bossList.Remove(asset.Key);
                if (!asset.Value.IsMiniboss || (asset.Value.IsMiniboss && !asset.Value.ReplaceRegs)) minibossList.Remove(asset.Key);
                if (!asset.Value.IsRegularPlus) regularplusList.Remove(asset.Key);
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
                    !classlib.changeList.ContainsKey(character.Value.Path)
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
                            Console.WriteLine("randomValue: " + randomValue + ", count: " + minibossList.Count());
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

            swaplistpanel.dataGridView1.Visible = true;
        }

        public void RandomizeItems(string target)
        {
            Random randomObj = new Random();
            int randomValue;

            List<int> randomList = Library.itemDictionary.Keys.ToList();
            List<int> goldenList = new List<int>(randomList);

            // remove all characters based on conditions
            foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
            {
                // if target is pickups, remove all weapons from randomization
                if ((target == "pickups") && !asset.Value.IsPickup) randomList.Remove(asset.Key);
                if ((target == "weapons") && !asset.Value.IsWeapon) randomList.Remove(asset.Key);
                if (asset.Value.IsGolden && (randomizeritems.checkIgnoreGolden.Checked || randomizeritems.checkGoldToGold.Checked))
                    randomList.Remove(asset.Key);
                if (asset.Value.IsExcluded) randomList.Remove(asset.Key);
                if (classlib.itemChangeList.ContainsKey(asset.Value.Path)) randomList.Remove(asset.Key);
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
                    !classlib.itemChangeList.ContainsKey(asset.Value.Path)
                    )
                {
                    if (asset.Value.IsGolden)
                    {
                        if (!randomizeritems.checkIgnoreGolden.Checked && randomizeritems.checkGoldToGold.Checked)
                        {
                            randomValue = randomObj.Next(0, goldenList.Count());
                            classlib.AddToList(this, "item", asset.Key, goldenList[randomValue]);
                            if (!randomizeritems.allowDuplicates.Checked)
                            {
                                randomList.Remove(goldenList[randomValue]);
                                goldenList.RemoveAt(randomValue);
                            }
                        }
                    }
                    else
                    {
                        randomValue = randomObj.Next(0, randomList.Count());
                        classlib.AddToList(this, "item", asset.Key, randomList[randomValue]);
                        if (!randomizeritems.allowDuplicates.Checked) randomList.RemoveAt(randomValue);
                    }
                }
            }
            swaplistitempanel.dataGridView2.Visible = true;
        }

        public void RandomizeDestroyables(string target)
        {
            Random randomObj = new Random();
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

    }
}
