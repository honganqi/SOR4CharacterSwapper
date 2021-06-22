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
        public Instructions instructions;

        public MainWindow()
        {
            InitializeComponent();

            initialWindowWidth = Width;
            fullWindowWidth = 1002;

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
            instructions = new Instructions(this)
            {
                TopLevel = false,
                TopMost = true
            };
            container.panelInfo.Controls.Add(info);
            info.Show();
            panelInstructions.Controls.Add(instructions);
            instructions.Show();
            bigfileClass = classlib.bigfileClass;

            // populate comboboxes with data
            foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
            {
                swapper.characterList.Items.Insert(character.Key, character.Value.Name);
                swapper.replacementComboBox.Items.Insert(character.Key, character.Value.Name);
                classlib.characterPathToIndex[character.Value.Path] = character.Key;
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

            panelContainer.Controls.Add(container);
            container.Show();
            panelInstructions.Controls.Add(instructions);
            instructions.Show();
            panelInstructions.Visible = false;

            // set DataGridView DoubleBuffered to TRUE to remove flickering caused by repainting when mouse hovers over the remove button and changes color
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridView1, new object[] { true });

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

                if (classlib.CheckBigfile(classlib.bigfilePath))
                {
                    info.labelValidBigfile.Text = "original v5 bigfile";
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
                    info.labelValidBigfile.Text = "modded v5 bigfile";
                    info.labelValidBigfile.ForeColor = Color.Crimson;
                    //labelBackupMade.Text = "A backup named \"bigfile_custom_backup\" will be made.";
                    info.labelBackupMade.Visible = false;
                }

                info.labelValidBigfile.Visible = true;
                classlib.gameDir = Path.GetDirectoryName(classlib.bigfilePath);

                info.labelBigfileLocationInfo.Text = "Loaded file:\n" + classlib.bigfilePath;

                ResetForm();
            }
        }


        public void ResetForm()
        {
            if (classlib.CheckBigfile(classlib.bigfilePath) || File.Exists(classlib.bigfilePath))
            {
                btnLoad.Visible = true;
                btnShowRandomPanel.Visible = true;

                swapper.characterList.Enabled = true;
                swapper.replacementComboBox.Enabled = true;
                swapper.btnSetItem.Enabled = true;
                if (swapper.characterList.SelectedIndex > -1) swapper.getThumbnail("original", swapper.characterList.SelectedIndex);
                if (swapper.replacementComboBox.SelectedIndex > -1) swapper.getThumbnail("replacement", swapper.replacementComboBox.SelectedIndex);

                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = true;
                randomizer.checkDuplicates.Enabled = true;
                randomizer.checkIgnoreBoss.Enabled = true;
                randomizer.checkIgnoreMiniboss.Enabled = true;

                if (container.panelMain.Controls.Count == 0)
                {
                    container.panelMain.Controls.Add(swapper);
                    swapper.Show();
                }

                info.btnRestoreBigfile.Visible = true;
                if (classlib.CheckBigfile(Path.Combine(classlib.gameDir, "bigfile")))
                {
                    info.btnRestoreBigfile.Enabled = false;
                }
                else
                {
                    info.btnRestoreBigfile.Enabled = true;
                }

                if (classlib.changeList.Count > 0)
                {
                    btnSave.Enabled = true;
                    btnSave.Visible = true;
                    container.btnStartReplace.Enabled = true;
                    swapper.btnShowList.Enabled = true;
                    randomizer.btnShowList.Enabled = true;
                    swapper.btnClearSwapList.Visible = true;

                }
                else
                {
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                    container.btnStartReplace.Enabled = false;
                    //swapper.btnShowList.Enabled = false;
                    //randomizer.btnShowList.Enabled = false;
                    container.labelPending.Visible = false;
                    hasNoPending = true;
                }
            }
            else
            {
                container.btnStartReplace.Enabled = false;
                swapper.characterList.Enabled = false;
                swapper.replacementComboBox.Enabled = false;
                swapper.btnSetItem.Enabled = false;
                randomizer.btnRandomize.Enabled = true;
                randomizer.btnRandomizeEverybody.Enabled = false;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                btnLoad.Visible = false;
                btnShowRandomPanel.Visible = false;
                randomizer.checkDuplicates.Enabled = false;
                randomizer.checkIgnoreBoss.Enabled = false;
                randomizer.checkIgnoreMiniboss.Enabled = false;
            }
        }

        public void ApplyChanges()
        {
            string createdBackup = classlib.CreateBackup();
            if (createdBackup != "") createdBackup = "\n\nA backup file named \"" + createdBackup + "\" was also created for you.";

            if (classlib.CheckBigfile(classlib.bigfilePath))
            {
                bigfileClass.bigfilePath = classlib.bigfilePath;
            }
            else
            {
                if (File.Exists(Path.Combine(classlib.gameDir, "bigfile_rep_backup"))) bigfileClass.bigfilePath = classlib.bigfilePath;
            }

            if (bigfileClass.CommitChanges()) 
            {
                info.labelValidBigfile.Text = "modded v5 bigfile";
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
        }

        public void ClearSwaps()
        {
            DialogResult resetAsk = MessageBox.Show("Are you sure you want to clear your swap selections?", "Reset Swaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resetAsk == DialogResult.Yes)
            {
                classlib.changeList.Clear();
                classlib.changeTo.Clear();
                bigfileClass.ResetSwaps();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                info.labelLoadedSwapFile.Text = "";
                info.labelLoadedSwap.Visible = false;
                info.labelLoadedSwapFile.Visible = false;
                swapper.btnClearSwapList.Enabled = false;
                randomizer.btnClearSwapList.Enabled = false;
                //Width = initialWindowWidth;
                ResetForm();
            }
        }

        public void btnInstructionsClose()
        {
            panelInstructions.Visible = false;
        }

        private bool SaveToSwapFile()
        {
            string[] lines = classlib.changeList.Select(item => string.Format("{0}:{1}", classlib.characterPathToIndex[item.Key], classlib.characterPathToIndex[item.Value])).ToArray();
            string settingsFileName = "bigfile_swapper_settings_" + DateTime.Now.ToString("yyyyMMdd") + ".swap";

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

        private bool ReadSwapFile(string settingsFileName)
        {
            // get bigfile MD5 hash to compare if original
            string[] lines = File.ReadAllLines(settingsFileName);
            Dictionary<int, int> data = new Dictionary<int, int>();
            foreach (string line in lines)
            {
                string[] replacement = line.Split(':');
                int original = Int32.Parse(replacement[0].Trim());
                int replaceWith = Int32.Parse(replacement[1].Trim());
                data[original] = replaceWith;
            }
            if (data.Count() > 0)
            {
                // clear all swaps
                foreach (KeyValuePair<string, string> changes in classlib.changeList) bigfileClass.RemoveSwap(classlib.characterPathToIndex[changes.Key]);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                classlib.changeList.Clear();
                classlib.changeTo.Clear();
                foreach (KeyValuePair<int, int> pair in data)
                {
                    if (pair.Key != pair.Value) classlib.AddToList(this, pair.Key, pair.Value);
                }
                ResetForm();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid settings file!", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //classlib.ResetForm();
                return false;
            }
        }



        // controls
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //classlib.ResetForm();
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
                    info.labelValidBigfile.Text = "modded v5 bigfile";
                    info.labelValidBigfile.ForeColor = Color.Crimson;
                    //labelBackupMade.Text = "A backup named \"bigfile_custom_backup\" will be made.";
                    info.labelBackupMade.Visible = false;
                }

                classlib.gameDir = Path.GetDirectoryName(bigfilePath);

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
                string settingsFilename = ofdLoadDialog.FileName;
                bool settingsSuccess = ReadSwapFile(settingsFilename);
                if (settingsSuccess == true)
                {
                    info.labelLoadedSwapFile.Text = Path.GetFileName(ofdLoadDialog.FileName);
                    info.labelLoadedSwap.Visible = true;
                    info.labelLoadedSwapFile.Visible = true;
                    swapper.btnClearSwapList.Enabled = true;
                    swapper.btnClearSwapList.Visible = true;
                    randomizer.btnClearSwapList.Enabled = true;
                    randomizer.btnClearSwapList.Visible = true;
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
            if (container.panelMain.Contains(randomizer))
            {
                btnShowRandomPanel.Text = "Randomizer";
                container.panelMain.Controls.Clear();
                container.panelMain.Controls.Add(swapper);
                swapper.Show();
            }
            else
            {
                btnShowRandomPanel.Text = "Swapper";
                container.panelMain.Controls.Clear();
                container.panelMain.Controls.Add(randomizer);
                randomizer.Show();

            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //var changeindex = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                // 1. get hidden INT value of replaced character
                int changed = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                // 2. check if changed character showed in the table really exists in the changeList
                if (classlib.changeList.ContainsKey(Library.characterDictionary[changed].Path))
                {
                    // 3. remove the character from the changeList
                    bigfileClass.RemoveSwap(changed);
                    classlib.changeList.Remove(Library.characterDictionary[changed].Path);

                    // 4. remove the character from the table, clear the table, then refresh
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    // 5. check if changeList still has any content
                    if (classlib.changeList.Count > 0)
                    {
                        Dictionary<string, string> tempChangeList = new Dictionary<string, string>(classlib.changeList);

                        // 6. iterate through each item in the changeList and add them back to the table
                        foreach (KeyValuePair<string, string> changes in tempChangeList)
                        {
                            classlib.AddToList(this, classlib.characterPathToIndex[changes.Key], classlib.characterPathToIndex[changes.Value], "graphic");
                        }
                    }
                    dataGridView1.Refresh();
                }
            }
            ResetForm();
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
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
