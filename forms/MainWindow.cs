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
        // class references
        public Library classlib = new();
        public Thumbnails thumbnailslib = new();
        BigfileExplorer bigfileClass;
        Swaps swaps = new();
        public forms.TextEditor textEditorForm;


        // accessible by BigfileExplorer
        public string originalReferenceForBigfile;

        // window stuff
        public int initialWindowWidth;
        public int fullWindowWidth;
        public Point lastLocation;

        public bool hasNoPending = true;
        public string currentlyLoadedFile = "";
        public int lastDifficultyIndex = 0;

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
        public CustomizerItems itemcustomizerscreen;
        public CustomizerLevels levelcustomizerscreen;
        public CharacterCustomizerPanel charactercustomizerpanel;
        public ItemCustomizerPanel itemcustomizerpanel;
        public string screenmode = "characters";
        public string functionmode = "swapper";

        public bool currentEditable = true;
        public bool currentReadable = true;

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
            itemcustomizerscreen = new CustomizerItems(this)
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
            itemcustomizerpanel = new ItemCustomizerPanel(this)
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
                charactercustomizerscreen.cmbAI.Items.Insert(asset.Key, asset.Value.Name);
                classlib.characterPathToIndex[asset.Value.Path] = asset.Key;
            }

            foreach (KeyValuePair<int, Library.Item> asset in Library.itemDictionary)
            {
                swapperitems.cmbItemOriginalList.Items.Insert(asset.Key, asset.Value.Name);
                swapperitems.cmbItemReplacementList.Items.Insert(asset.Key, asset.Value.Name);
                itemcustomizerscreen.itemList.Items.Insert(asset.Key, asset.Value.Name);
                itemcustomizerscreen.cmbTransformOnHit.Items.Insert(asset.Key, asset.Value.Name);
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

            container.imgBMCSupport.Image = Images.Load("bmc");
            container.imgSF.Image = Images.Load("sflogo");
            container.imgYoutube.Image = Images.Load("youtube");
            container.imgTwitch.Image = Images.Load("twitch");
            btnOpenBigfile.BackgroundImage = Images.Load("open");
            btnShowRandomPanel.BackgroundImage = Images.Load("random");
            btnShowSwapperPanel.BackgroundImage = Images.Load("swapper");
            btnShowCustomizer.BackgroundImage = Images.Load("customize");
            btnLoadSwap.BackgroundImage = Images.Load("load");
            btnDifficultyPanel.BackgroundImage = Images.Load("difficulty");
            btnOwnerPanel.BackgroundImage = Images.Load("author");
            btnSaveSwap.BackgroundImage = Images.Load("save");
            btnInstructions.BackgroundImage = Images.Load("help");
            btnClose.BackgroundImage = Images.Load("exit");
            btnMinimize.BackgroundImage = Images.Load("min");
            imgListShadow.BackgroundImage = Images.Load("listshadow");

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
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;

                Initialize();

                ResetForm(true);

                ChangeFunction("swapper");
            }

            CheckUpdate(updateurl);
        }

        private void Initialize()
        {
            ManageBackups();

            thumbnailslib.InitializeThumbnails(classlib.gameDir);

            string originalBigfilePath = classlib.bigfilePath;
            string backupFilename = Path.Combine(classlib.gameDir, classlib.backup_filename);

            if (File.Exists(backupFilename))
            {
                bigfileClass.bigfilePath = backupFilename;
            }
            classlib.characterCustomizationInMemory = new();

            bigfileClass.Initialize();

            textEditorForm = new(this);

            // initialize shader combobox in customizer
            string[] shaderStrings = { "Normal", "Shiva Double", "Motion Blur", "Elite", "Doppelganger" };
            int shaderComboIndex = 0;
            classlib.shaderStrings = bigfileClass.GetListStrings("shaders");
            foreach (var item in classlib.shaderStrings)
                charactercustomizerscreen.cmbShader.Items.Add(shaderStrings[shaderComboIndex++]);
            foreach (var item in classlib.bigfileClass.superArmors)
                charactercustomizerscreen.cmbMoveArmor.Items.Add(item.Key);
            foreach (var item in classlib.bigfileClass.moveDpads)
                charactercustomizerscreen.cmbMoveDpad.Items.Add(item.Key);
            foreach (var item in classlib.bigfileClass.moveButtons)
                charactercustomizerscreen.cmbMoveButton.Items.Add(item.Key);

            // initialize weapon type combobox in customizer
            string[] weaponTypeStrings = { "Not a weapon", "Pipe", "Bottle", "Katana", "Knife", "Vial", "Taser", "Butcher Knife", "Halberd", "Tonfa", "Umbrella" };
            int weaponTypeComboIndex = 0;
            classlib.weaponTypeStrings = bigfileClass.GetListStrings("weaponTypes");
            foreach (var item in classlib.weaponTypeStrings)
                itemcustomizerscreen.cmbWeaponType.Items.Add(weaponTypeStrings[weaponTypeComboIndex++]);

            // initialize food type combobox in customizer
            string[] foodTypeStrings = { "Not food", "Small", "Big" };
            int foodTypeComboIndex = 0;
            classlib.foodTypeStrings = bigfileClass.GetListStrings("foodTypes");
            foreach (var item in classlib.foodTypeStrings)
                itemcustomizerscreen.cmbFood.Items.Add(foodTypeStrings[foodTypeComboIndex++]);

            // add levels to level customizer
            foreach (var levelClass in Library.levelDictionary)
            {
                if (levelClass.Value.Path != "n/a")
                    levelcustomizerscreen.dgvLevelSettings.Rows.Add(levelClass.Value.Name, bigfileClass.levelCollection[levelClass.Key].Teams, levelClass.Key);
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
            InitializeCustomNames();

            foreach (KeyValuePair<int, DifficultyClass> asset in bigfileClass.difficultyCollection)
            {
                if (asset.Key <= 5)
                {
                    difficultyscreen.cmbDifficultyCollection.Items.Insert(asset.Key, asset.Value.Name);
                    classlib.difficultyItemsInMemory.Add(asset.Key, asset.Value);
                    difficultyscreen.originalDifficultyCollection.Add(asset.Key, asset.Value.Copy());
                    lastDifficultyIndex = asset.Key;
                }
            }

            difficultyscreen.difficultyJustArrived = true;
            difficultyscreen.txtDifficultyName.Text = "CUSTOM";
            difficultyscreen.cmbDifficultyCollection.SelectedIndex = lastDifficultyIndex;
            difficultyscreen.difficultyJustArrived = false;
            difficultyscreen.txtDifficultyName.Text = "CUSTOM";

            classlib.bigfilePath = originalBigfilePath;
        }

        public void InitializeCustomNames()
        {
            // character names
            foreach (KeyValuePair<int, CharacterClass> charClass in classlib.bigfileClass.characterCollection)
            {
                string customNameIndex = Library.characterDictionary[charClass.Key].CustomNameIndex;
                string nameFromOriginalIndex;
                if (bigfileClass.customCharacterNames.ContainsKey(charClass.Value.NameIndex))
                    nameFromOriginalIndex = classlib.bigfileClass.customCharacterNames[charClass.Value.NameIndex];
                else
                    nameFromOriginalIndex = charClass.Value.NameIndex;

                charClass.Value.Name = nameFromOriginalIndex;
                charClass.Value.NewName = nameFromOriginalIndex;
                charClass.Value.SwapNameIndex = customNameIndex;
                classlib.customCharacterNames[customNameIndex] = nameFromOriginalIndex;
            }
        }

        private void ManageBackups()
        {
            bool originalBigfileExists;
            bool backupBigfileExists;

            if (originalBigfileExists = classlib.CheckBigfile(classlib.bigfilePath))
            {
                info.labelValidBigfile.Text = $"original v{classlib.gameVerString} bigfile";
                info.labelValidBigfile.ForeColor = Color.ForestGreen;
            }
            else
            {
                info.labelValidBigfile.Text = $"modded bigfile";
                info.labelValidBigfile.ForeColor = Color.Crimson;
            }

            // check for existence of any bigfile before checking for backup
            if (File.Exists(Path.Combine(classlib.bigfilePath)))
            {
                if (backupBigfileExists = classlib.CheckBackupFile(classlib.backup_filename))
                    info.labelBackupMade.Visible = false;

                if (!backupBigfileExists)
                {
                    if (originalBigfileExists)
                    {
                        string backup_filename = classlib.CreateBackup();
                        info.labelBackupMade.Text = $"A backup file named \"{ backup_filename}\" was created.";
                        info.labelBackupMade.Visible = true;
                    }
                    else
                    {
                        string backupMessage = $@"Unable to find a valid bigfile or a backup of it.
This version of the Swapper supports only v{classlib.gameVerString} or earlier.
Please get a valid bigfile by re-validating your copy of the game. Proceed at your own risk.";
                        MessageBox.Show(backupMessage, "No valid bigfile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            info.labelValidBigfile.Visible = true;
            classlib.gameDir = Path.GetDirectoryName(classlib.bigfilePath);

            info.labelBigfileLocationInfo.Text = "Loaded file:\n" + classlib.bigfilePath;
            classlib.bigfileClass.bigfilePath = classlib.bigfilePath;
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
            if (File.Exists(Path.Combine(classlib.gameDir, classlib.backup_filename)))
            {
                bigfileClass.bigfilePath = Path.Combine(classlib.gameDir, classlib.backup_filename);
            }

            GetValuesFromUI(true);

            if (bigfileClass.CommitChanges(swaps))
            {
                info.labelValidBigfile.Text = $"modded bigfile";
                info.labelValidBigfile.ForeColor = Color.Crimson;
                info.btnRestoreBigfile.Enabled = true;
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

        public void GetValuesFromUI(bool applyChanges = false)
        {
            // GameplayConfigData, Difficulty, and Global Character Settings
            GameplayConfigDataClass gcd = difficultyscreen.GetGCDValues();
            DifficultyClass difficulty = difficultyscreen.GetDifficultyValues();
            Dictionary<string, CharacterClass> generalCharacterCollection = difficultyscreen.GetGlobalCharacterValues();

            // Author
            Author author = ownerdetailsscreen.GetValues(applyChanges);

            // Level Customizer
            Dictionary<int, LevelClass> levelCustomizationQueue = levelcustomizerscreen.GetValues();

            swaps.GameplayConfigDataSave = gcd;
            swaps.Difficulty = difficulty;
            swaps.GlobalCharacterSettings = generalCharacterCollection;
            swaps.Author = author;
            swaps.LevelCustomizationQueue = levelCustomizationQueue;
            swaps.ChangeList = classlib.changeList;
            swaps.ItemChangeList = classlib.itemChangeList;
            swaps.DestroyableChangeList = classlib.destroyableChangeList;
            swaps.LevelChangeList = classlib.levelChangeList;
            swaps.CharacterCustomizationQueue = classlib.characterCustomizationQueue;
            swaps.CustomCharacterNamesQueue = classlib.customCharacterNames;
            swaps.ItemCustomizationQueue = classlib.itemCustomizationQueue;

            if (textEditorForm.chkSwapFile.Checked|| textEditorForm.chkTextApply.Checked)
                swaps.GameTextCollection = textEditorForm.ExportTextSwap(applyChanges);
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
            }
            else
            {
                if (mode == "breakable") mode = "destroyable";
                if (goAhead == true)
                {
                    if (function == "custom")
                        mode = "custom" + mode.Substring(0, 1).ToUpper() + mode.Substring(1);

                    classlib.ClearTable(mode);
                    if (mode == "customCharacter")
                        InitializeCustomNames();

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
                        case "customItem":
                            itemcustomizerpanel.labelReplaceCount.Text = "0";
                            itemcustomizerscreen.btnClearSwapList.Enabled = false;
                            break;
                    }
                    ResetForm();
                }
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

        #region Swapper Functions
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
                            CharacterClass characterClass = bigfileClass.characterCollection[assetKey].Copy();

                            // if character is found in swap list, change characterClass into swap target's original attributes
                            if (classlib.changeList.ContainsKey(assetKey)) {
                                targetKey = classlib.changeList[assetKey];
                                characterClass = bigfileClass.characterCollection[targetKey].Copy();
                            }

                            // if character is found in customization list
                            if (classlib.characterCustomizationQueue.ContainsKey(assetKey))
                                characterClass = classlib.characterCustomizationQueue[assetKey].Copy();

                            characterClass.Team = teamIterator;

                            // if character has an entry in "memory" but not yet added to list
                            if (!classlib.characterCustomizationInMemory.ContainsKey(assetKey))
                                classlib.characterCustomizationInMemory[assetKey] = characterClass;

                            classlib.AddCustom(this, "character", assetKey, characterClass);
                            foreach (DataGridViewRow dr in levelcustomizerscreen.dgvLevelSettings.Rows)
                                dr.Cells["teams"].Value = true;

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
        #endregion

        #region Updates
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
                    var queryResult = Newtonsoft.Json.JsonConvert.DeserializeObject<VersionClass>(page.Result);

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

        #endregion

        #region Panels and Windows
        public void ChangeFunction(string functionmode)
        {
            this.functionmode = functionmode;
            btnInstructionsClose();
            container.panelDifficulty.Hide();
            container.panelOwner.Hide();
            if (functionmode == "custom")
                labelDisplayList.Text = "CUSTOMIZATION List";
            else
                labelDisplayList.Text = "REPLACEMENT List";
            container.SwitchTabs(screenmode);
        }

        public void ResetForm(bool fullReset = false)
        {
            bool editable;
            bool readable;
            if (fullReset)
            {
                editable = true;
                readable = true;
            }
            else
            {
                editable = currentEditable;
                readable = currentReadable;
            }
            if (classlib.CheckBigfile(classlib.bigfilePath) || File.Exists(classlib.bigfilePath))
            {
                // load buttons in a specific order to simulate tabs
                //3.Visible = true;
                btnLoadSwap.Show();
                btnOwnerPanel.Show();
                info.btnRestoreBigfile.Show();
                btnSaveSwap.Visible = editable;
                btnShowSwapperPanel.Visible = readable;
                btnShowRandomPanel.Visible = readable;
                btnShowCustomizer.Visible = readable;
                btnDifficultyPanel.Visible = readable;
                if (functionmode != "custom")
                {
                    container.panelDivider.Visible = readable;
                    container.btnCharPanel.Visible = readable;
                    container.btnItemPanel.Visible = readable;
                    container.btnDestroyablesPanel.Visible = readable;
                    container.btnLevelPanel.Visible = readable;
                }
                container.btnStartReplace.Show();
                container.btnClearAllSwaps.Visible = editable;

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

                // owner stuff
                ownerdetailsscreen.txtAuthor.Enabled = editable;
                ownerdetailsscreen.txtDateCreated.Enabled = editable;
                ownerdetailsscreen.txtDownloadURL.Enabled = editable;
                ownerdetailsscreen.txtModDesc.Enabled = editable;
                ownerdetailsscreen.txtModShortDesc.Enabled = editable;
                ownerdetailsscreen.txtModTitle.Enabled = editable;
                ownerdetailsscreen.txtRecoDiff.Enabled = editable;
                ownerdetailsscreen.chkAuthorDisplay.Enabled = editable;
                ownerdetailsscreen.chkTitleDisplay.Enabled = editable;
                ownerdetailsscreen.chkDateDisplay.Enabled = editable;

                // if bigfile exists and is valid, disable bigfile-related buttons
                if (classlib.CheckBigfile(Path.Combine(classlib.gameDir, "bigfile")))
                    info.btnRestoreBigfile.Enabled = false;
                else
                    info.btnRestoreBigfile.Enabled = true;

                if ((classlib.changeList.Count > 0) || (classlib.itemChangeList.Count > 0) || (classlib.destroyableChangeList.Count > 0) || (classlib.levelChangeList.Count > 0))
                {
                    container.btnStartReplace.Enabled = true;
                    container.btnClearAllSwaps.Enabled = editable;
                    container.labelPending.Visible = editable;
                    if (classlib.changeList.Count > 0)
                    {
                        swapper.btnShowList.Enabled = readable;
                        randomizer.btnShowList.Enabled = readable;
                        swapper.btnClearSwapList.Enabled = readable;
                        randomizer.btnClearSwapList.Enabled = readable;
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
                        swapperitems.btnShowList.Enabled = readable;
                        randomizeritems.btnShowList.Enabled = readable;
                        swapperitems.btnClearSwapList.Enabled = readable;
                        randomizeritems.btnClearSwapList.Enabled = readable;
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
                        swapperdestroyables.btnShowList.Enabled = readable;
                        randomizerdestroyables.btnShowList.Enabled = readable;
                        swapperdestroyables.btnClearSwapList.Enabled = readable;
                        randomizerdestroyables.btnClearSwapList.Enabled = readable;
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
                        swapperlevels.btnShowList.Enabled = readable;
                        randomizerlevels.btnShowList.Enabled = readable;
                        swapperlevels.btnClearSwapList.Enabled = readable;
                        randomizerlevels.btnClearSwapList.Enabled = readable;
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
                    container.btnStartReplace.Enabled = true;
                    container.btnClearAllSwaps.Enabled = false;
                    container.labelPending.Hide();
                    hasNoPending = true;
                }

                // reset controls of all other forms
                Form[] forms = new Form[]
                {
                    swapper,
                    swapperitems,
                    swapperdestroyables,
                    swapperlevels,
                    randomizer,
                    randomizeritems,
                    randomizerdestroyables,
                    randomizerlevels,
                    randomizerpresets,
                    levelcustomizerscreen,
                    difficultyscreen
                };
                foreach (Form form in forms)
                {
                    foreach (Control formControl in form.Controls)
                        formControl.Enabled = editable;
                }
                // reset exception controls
                swapper.btnShowList.Enabled = readable;
                randomizer.btnShowList.Enabled = readable;
                swapperitems.btnShowList.Enabled = readable;
                randomizeritems.btnShowList.Enabled = readable;
                swapperdestroyables.btnShowList.Enabled = readable;
                randomizerdestroyables.btnShowList.Enabled = readable;
                swapperlevels.btnShowList.Enabled = readable;
                randomizerlevels.btnShowList.Enabled = readable;
                charactercustomizerscreen.characterList.Enabled = readable;

                if (difficultyscreen.cmbPlayerHitstopValuesOptions.SelectedIndex > 0)
                    difficultyscreen.txtPlayerHitstop.Enabled = currentEditable;
                else
                    difficultyscreen.txtPlayerHitstop.Enabled = false;

                if (difficultyscreen.cmbPlayerHitstunValuesOptions.SelectedIndex > 0)
                    difficultyscreen.txtPlayerHitstun.Enabled = currentEditable;
                else
                    difficultyscreen.txtPlayerHitstun.Enabled = false;

                if (difficultyscreen.cmbEnemyHitstopValuesOptions.SelectedIndex > 0)
                    difficultyscreen.txtEnemyHitstop.Enabled = currentEditable;
                else
                    difficultyscreen.txtEnemyHitstop.Enabled = false;

                if (difficultyscreen.cmbEnemyHitstunValuesOptions.SelectedIndex > 0)
                    difficultyscreen.txtEnemyHitstun.Enabled = currentEditable;
                else
                    difficultyscreen.txtEnemyHitstun.Enabled = false;
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

        private void btnInstructions_Click(object sender, EventArgs e) => panelInstructions.Visible = true;
        private void btnInstructionsClose_Click(object sender, EventArgs e) => btnInstructionsClose();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void btnOwnerPanel_Click(object sender, EventArgs e)
        {
            btnInstructionsClose();
            container.panelOwner.Visible = true;
            container.panelOwner.BringToFront();
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("Yeah?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exitAsk == DialogResult.No);
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void btnCustomize_Click(object sender, EventArgs e) => ChangeFunction("custom");
        private void btnShowSwapperPanel_Click(object sender, EventArgs e) => ChangeFunction("swapper");
        private void btnShowRandomPanel_Click(object sender, EventArgs e) => ChangeFunction("randomizer");
        private void btnDifficultyPanel_Click(object sender, EventArgs e)
        {
            btnInstructionsClose();
            container.panelDifficulty.Visible = true;
            container.panelDifficulty.BringToFront();
        }
        #endregion

        #region Window Movement
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
        #endregion

        #region Load/Save Functions
        private void btnSaveSwap_Click(object sender, EventArgs e)
        {
            ContextMenu cm = new();
            MenuItem cmExport = new("Export swap mod");
            cm.MenuItems.Add("Save editable swap mod", new EventHandler(SaveAs_Editable_Click));
            cmExport.MenuItems.Add("Editable", new EventHandler(SaveAs_Editable_Click));
            cmExport.MenuItems.Add("Read-only", new EventHandler(SaveAs_Readonly_Click));
            cmExport.MenuItems.Add("Protected", new EventHandler(SaveAs_Hidden_Click));
            cm.MenuItems.Add(cmExport);
            cm.Show(btnSaveSwap, new Point(5,60));
        }

        private void SaveAs_Editable_Click(object sender, EventArgs e) => SaveSwap(2);
        private void SaveAs_Readonly_Click(object sender, EventArgs e)
        {
            DialogResult cont = MessageBox.Show("You are about to export a READ-ONLY swap mod. If you haven't saved an editable copy for yourself, please do so before exporting a copy. \n\n" + Library.TEXT_ACCESSMODE_READONLY + " If you want to create or share a modifiable swap select the \"Save editable swap mod\" option.", "Export Read-only Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cont == DialogResult.Yes)
                SaveSwap(1);
        }

        private void SaveAs_Hidden_Click(object sender, EventArgs e)
        {
            DialogResult cont = MessageBox.Show("You are about to export a PROTECTED swap mod. If you haven't saved an editable copy for yourself, please do so before exporting a copy. \n\n" + Library.TEXT_ACCESSMODE_PROTECTED + " If you want to create or share a modifiable swap select the \"Save editable swap mod\" option.", "Export Protected Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cont == DialogResult.Yes)
                SaveSwap(0);
        }

        private void SaveSettings(string filename, int saveMode)
        {
            GetValuesFromUI(false);
            if (swaps.Save(Application.ProductVersion, filename, saveMode))
            {
                string saveModeString = saveMode switch
                {
                    2 => "editable",
                    1 => "read-only",
                    _ => "protected",
                };
                info.labelLoadedSwapFile.Text = Path.GetFileName(filename) + " (as " + saveModeString + ")";
                info.labelLoadedSwap.Text = "Swap list saved:";
                info.labelLoadedSwap.Visible = true;
                info.labelLoadedSwapFile.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed to save");
            }
        }

        public void SaveSwap(int saveMode = 0)
        {
            string settingsFileName = "bigfile_swapper_settings_" + DateTime.Now.ToString("yyyyMMdd") + ".swap";

            if (currentlyLoadedFile != "")
                settingsFileName = currentlyLoadedFile;

            SaveFileDialog fd = new()
            {
                Filter = "Swapper Mod|*.swap",
                Title = "Save Swap Mod",
                FileName = settingsFileName
            };
            if (saveMode == 2)
            {
                settingsFileName = Path.GetFileNameWithoutExtension(settingsFileName) + ".swapedit";
                fd.Filter = "Editable Swapper Mod|*.swapedit";
                fd.FileName = settingsFileName;
            }

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // If the file name is not an empty string open it for saving.
                if (fd.FileName != "")
                    SaveSettings(fd.FileName, saveMode);
            }
        }

        private Dictionary<ComboBox, int> ReselectAllCmb(Dictionary<ComboBox, int> previouslySelected = null)
        {
            List<ComboBox> controls = new()
            {
                swapper.characterList,
                swapper.replacementComboBox,
                swapperitems.cmbItemOriginalList,
                swapperitems.cmbItemReplacementList,
                swapperdestroyables.cmbItemOriginalList,
                swapperdestroyables.cmbItemReplacementList,
                swapperlevels.cmbItemOriginalList,
                swapperlevels.cmbItemReplacementList,
                charactercustomizerscreen.characterList,
            };

            if (previouslySelected != null)
            {
                foreach (KeyValuePair<ComboBox, int> pair in previouslySelected)
                {
                    ComboBox thiscontrol = pair.Key;
                    int selectedIndex = pair.Value;
                    thiscontrol.SelectedIndex =selectedIndex;
                }
                    
            }
            else
            {
                previouslySelected = new();
                foreach (ComboBox thiscontrol in controls)
                {
                    if (thiscontrol.SelectedIndex > -1)
                    {
                        previouslySelected.Add(thiscontrol, thiscontrol.SelectedIndex);
                        thiscontrol.SelectedIndex = -1;
                    }
                }
                    

            }

            return previouslySelected;
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
                    swaps = new();
                    swaps.Reset(bigfileClass);

                    classlib.ClearTable("character", swaplistpanel);
                    classlib.ClearTable("item", swaplistitempanel);
                    classlib.ClearTable("destroyable", swaplistdestroyablepanel);
                    classlib.ClearTable("level", swaplistlevelpanel);
                    classlib.ClearTable("customCharacter", charactercustomizerpanel);
                    classlib.ClearTable("customItem", itemcustomizerpanel);

                    // character names
                    InitializeCustomNames();

                    string currentVerString = Application.ProductVersion;
                    string swapVerString = "";
                    List<string> currentVer = new();
                    List<string> swapVer = new();
                    Dictionary<string, string> settings = swaps.Load(settingsFilename);

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
                            Dictionary<ComboBox, int> previouslySelected = ReselectAllCmb();

                            if (ReadSwapFile(swaps, swapVer))
                            {
                                btnInstructionsClose();
                                swapper.btnClearSwapList.Enabled = swaps.editable;
                                swapper.btnClearSwapList.Visible = swaps.editable;
                                randomizer.btnClearSwapList.Enabled = swaps.editable;
                                randomizer.btnClearSwapList.Visible = swaps.editable;
                            }
                            currentEditable = swaps.editable;
                            currentReadable = swaps.readable;
                            container.panelOwner.Visible = true;
                            container.panelOwner.BringToFront();
                            currentlyLoadedFile = Path.GetFileName(settingsFilename);
                            ReselectAllCmb(previouslySelected);
                            ResetForm();
                            string viewmode = "protected";
                            if (currentEditable && currentReadable)
                            {
                                viewmode = "editable";
                            }
                            else
                            if (!currentEditable && currentReadable)
                            {
                                viewmode = "read-only";
                            }
                            info.labelLoadedSwapFile.Text = Path.GetFileName(settingsFilename) + " (as " + viewmode + ")";
                            info.labelLoadedSwap.Visible = true;
                            info.labelLoadedSwapFile.Visible = true;

                            string saveModeString = swaps.AccessLevel switch
                            {
                                2 => Library.TEXT_ACCESSMODE_EDITABLE,
                                1 => Library.TEXT_ACCESSMODE_READONLY,
                                _ => Library.TEXT_ACCESSMODE_PROTECTED,
                            };
                            info.tooltip.SetToolTip(info.labelLoadedSwapFile, saveModeString);
                        }
                    }
                    try
                    {

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        List<string> versionSplit = currentVerString.Split('.').ToList();
                        if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                        if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                        currentVer.Add(string.Join(".", versionSplit));
                        cont = MessageBox.Show($"The swap file you loaded is for a version of SOR4 Swapper older than v4.0. You are currently using v.{currentVer[0]}. \n\nDo you want to continue?", "Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cont == DialogResult.Yes)
                        {
                            if (ReadSwapFileOld(settingsFilename))
                            {
                                btnInstructionsClose();
                                container.panelOwner.Visible = true;
                                container.panelOwner.BringToFront();

                                info.labelLoadedSwapFile.Text = Path.GetFileName(settingsFilename);
                                currentlyLoadedFile = Path.GetFileName(settingsFilename);
                                info.labelLoadedSwap.Text = "Swap list loaded:";
                                info.labelLoadedSwap.Visible = true;
                                info.labelLoadedSwapFile.Visible = true;
                                swapper.btnClearSwapList.Enabled = true;
                                swapper.btnClearSwapList.Visible = true;
                                randomizer.btnClearSwapList.Enabled = true;
                                randomizer.btnClearSwapList.Visible = true;
                                currentEditable = true;
                                currentReadable = true;
                                ResetForm(true);
                            }
                        }

                        System.Text.StringBuilder msg = new();
                        msg.AppendLine(err.GetType().FullName);
                        msg.AppendLine(err.Message);
                        System.Diagnostics.StackTrace st = new();
                        msg.AppendLine(st.ToString());
                        msg.AppendLine();
                        string exePath = AppDomain.CurrentDomain.BaseDirectory;
                        string path = $"{exePath}sor4swapper_error_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log";
                        MessageBox.Show(path);
                        File.AppendAllText(path, msg.ToString());
                    }
                }
            }
        }

        private bool ReadSwapFile(Swaps swapSettings, List<string> swapVer)
        {
            ownerdetailsscreen.LoadSettings(swapSettings.Author);
            if (swapSettings.readable)
            {
                Dictionary<int, int> swapContents = swapSettings.ChangeList;
                if (swapContents != null)
                {
                    foreach (KeyValuePair<int, int> swap in swapContents)
                        classlib.AddToList(this, "character", swap.Key, swap.Value, true);
                }

                swapContents = swapSettings.ItemChangeList;
                if (swapContents != null)
                {
                    foreach (KeyValuePair<int, int> swap in swapContents)
                        classlib.AddToList(this, "item", swap.Key, swap.Value, true);
                }
                swapContents = swapSettings.DestroyableChangeList;
                if (swapContents != null)
                {
                    foreach (KeyValuePair<int, int> swap in swapContents)
                        classlib.AddToList(this, "destroyable", swap.Key, swap.Value, true);
                }
                swapContents = swapSettings.LevelChangeList;
                if (swapContents != null)
                {
                    foreach (KeyValuePair<int, int> swap in swapContents)
                        classlib.AddToList(this, "level", swap.Key, swap.Value, true);
                }

                Dictionary<int, CharacterClass> customList = swapSettings.CharacterCustomizationQueue;
                classlib.ClearTable("customCharacter", charactercustomizerpanel);
                InitializeCustomNames();
                if (customList != null)
                {
                    Dictionary<int, int> missingSwaps = new();
                    foreach (KeyValuePair<int, CharacterClass> customCharacter in customList)
                    {
                        // customCharacter.Value = class of customized (and replaced) character
                        if (!swapSettings.ChangeList.ContainsKey(customCharacter.Key) && (customCharacter.Key != customCharacter.Value.NewCharacterId))
                        {
                            missingSwaps.Add(customCharacter.Key, customCharacter.Value.NewCharacterId);
                            classlib.AddToList(this, "character", customCharacter.Key, customCharacter.Value.NewCharacterId);
                        }

                        classlib.AddCustom(this, "character", customCharacter.Key, customCharacter.Value);
                        classlib.characterCustomizationInMemory[customCharacter.Key] = customCharacter.Value;
                        classlib.customCharacterNames[customCharacter.Value.NameIndex] = customCharacter.Value.NewName;
                    }
                    if (missingSwaps.Count > 0)
                    {
                        string missingSwapsText = "Customizations were found for the following missing swaps:\n\n";
                        foreach (KeyValuePair<int, int> missing in missingSwaps)
                        {
                            missingSwapsText += Library.characterDictionary[missing.Key].Name + " -> " + Library.characterDictionary[missing.Value].Name + "\n";
                        }
                        missingSwapsText += "\nYou may inspect these by going to the Characters tab in the Swapper section.\n";
                        MessageBox.Show(missingSwapsText, "Missing swaps added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

                if (swapSettings.ItemCustomizationQueue != null)
                {
                    Dictionary<int, ItemClass> customItemList = swapSettings.ItemCustomizationQueue;
                    classlib.ClearTable("customItem", itemcustomizerpanel);
                    if (customItemList != null)
                    {
                        foreach (KeyValuePair<int, ItemClass> customItem in customItemList)
                        {
                            classlib.AddCustomItem(this, "item", customItem.Key, customItem.Value);
                            classlib.itemCustomizationInMemory[customItem.Key] = customItem.Value;
                        }
                    }
                }
                else
                {
                    classlib.ClearTable("customItem", itemcustomizerpanel);
                }

                // add levels to level customizer
                foreach (DataGridViewRow leveldr in levelcustomizerscreen.dgvLevelSettings.Rows)
                {
                    int levelKey = (int)leveldr.Cells["origKey"].Value;
                    if (swapSettings.LevelCustomizationQueue != null)
                    {
                        if (swapSettings.LevelCustomizationQueue.ContainsKey(levelKey))
                            leveldr.Cells["teams"].Value = swapSettings.LevelCustomizationQueue[levelKey].Teams;
                    }
                }

                // very special condition for pre-4.2 and EnemySpeedMultiplier==0, reset to default of 100
                // anything pre-v4.0 will not have difficulty anyway and will load default
                if (swapVer.Count > 0 && ((swapVer[0] == "4.0") || (swapVer[0] == "4.1")) && (swapSettings.Difficulty.EnemySpeedMultiplier == 0))
                    swapSettings.Difficulty.EnemySpeedMultiplier = 100;

                difficultyscreen.cmbDifficultyCollection.SelectedIndex = swapSettings.Difficulty.BasisIndex;
                if (swapSettings.GameplayConfigDataSave != null)
                    difficultyscreen.LoadSettings(swapSettings.Difficulty, swapSettings.GameplayConfigDataSave, swapSettings.GlobalCharacterSettings);
                else
                    difficultyscreen.LoadSettings(swapSettings.Difficulty, bigfileClass.gameplayConfigData, swapSettings.GlobalCharacterSettings);

                if (swapSettings.GameTextCollection != null)
                    textEditorForm.ImportTextSwap(swapSettings.GameTextCollection);

                return true;
            }
            return false;
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
                int original = int.Parse(replacement[0].Trim(charsToTrim).Trim());
                int replaceWith = int.Parse(replacement[1].Trim(charsToTrim).Trim());
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

        #endregion
    }
    class VersionClass
    {
        [Newtonsoft.Json.JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [Newtonsoft.Json.JsonProperty("version")]
        public string Version { get; set; }
        [Newtonsoft.Json.JsonProperty("download_url")]
        public string DownloadURL { get; set; }
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }
    }

    class Images
    {
        public static Bitmap Load(string imagename)
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();
            Stream stream = _assembly.GetManifestResourceStream("SOR4_Swapper.img." + imagename + ".png");
            Bitmap _bitmap = new(stream);
            return _bitmap;
        }
    }
}
