using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using SOR4GameExplorer;

namespace SOR4_Swapper.forms
{
    public partial class TextEditor : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        DataTable mainTable = new();
        string currentlyLoadedFile = "";
        Dictionary<string, GameText> customTextInMemory = new();
        string prevSelectedLanguage = "en";
        GameTextCollection gameTextCollection = new();

        public TextEditor(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            dataGridView1.AutoGenerateColumns = false;

            classlib.gameText = classlib.bigfileClass.GetGameText();
            cmbLang.Items.Clear();
            foreach (var textpair in classlib.gameText)
            {
                string language = Library.languages[textpair.Key];
                GameText gametext = new();
                gametext.Language = textpair.Key;
                gametext.Entries = new(classlib.gameText[textpair.Key].Entries);
                customTextInMemory.Add(textpair.Key, gametext);
                customTextInMemory[textpair.Key].Language = textpair.Key;
                cmbLang.Items.Add(language);
            }
            InitializeTable();

            if (Properties.Settings.Default.language == "")
                Properties.Settings.Default.language = "en";
            if ((Properties.Settings.Default.language != "") && classlib.gameText.ContainsKey(Properties.Settings.Default.language))
            {
                cmbLang.SelectedIndex = Library.languages.ToList().IndexOf(new KeyValuePair<string, string>(Properties.Settings.Default.language, Library.languages[Properties.Settings.Default.language]));
                prevSelectedLanguage = Properties.Settings.Default.language;
                ResetTable();
            }
        }

        #region User Interface
        private void ResetTable(GameText text = null)
        {
            if ((classlib.gameText != null) && (cmbLang.SelectedIndex != -1))
            {
                string selectedLanguage = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                mainTable.Rows.Clear();
                mainTable.Columns.Clear();

                DataColumn colIndex = new();
                colIndex.ColumnName = "Index";
                mainTable.Columns.Add(colIndex);

                DataColumn colText = new();
                colText.ColumnName = "Text";
                mainTable.Columns.Add(colText);

                bool customized = false;
                if (text == null)
                {
                    text = classlib.gameText[selectedLanguage];
                }
                else
                {
                    cmbLang.SelectedIndex = Library.languages.ToList().IndexOf(new KeyValuePair<string, string>(text.Language, Library.languages[text.Language]));
                    text = customTextInMemory[selectedLanguage];
                    text.Language = selectedLanguage;
                    customized = true;
                }

                foreach (KeyValuePair<string, string> textpair in classlib.gameText[selectedLanguage].Entries)
                {
                    if (customized)
                    {
                        if (text.Entries.ContainsKey(textpair.Key))
                            mainTable.Rows.Add(new object[] { textpair.Key, text.Entries[textpair.Key] });
                        else
                            mainTable.Rows.Add(new object[] { textpair.Key, textpair.Value });
                    }
                    else
                    {
                        mainTable.Rows.Add(new object[] { textpair.Key, textpair.Value });
                    }
                }
                InitializeTable();

                dataGridView1.Update();
                dataGridView1.Refresh();

                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AllowUserToResizeColumns = true;

                // this block rechecks all cells for changes and sets the color
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[1].Value != null)
                    {
                        string index = dr.Cells[0].Value.ToString();
                        string entry = dr.Cells[1].Value.ToString();
                        
                        if (entry != classlib.gameText[selectedLanguage].Entries[index])
                        {
                            dr.Cells[0].Style.ForeColor = Color.Crimson;
                            dr.Cells[1].Style.ForeColor = Color.Crimson;
                        }
                    }
                }

                txtGridIndex.Width = dataGridView1.Columns[0].Width;
                txtGridText.Location = new Point(txtGridIndex.Location.X + txtGridIndex.Width, txtGridIndex.Location.Y);
                txtGridText.Width = dataGridView1.Columns[1].Width;

                panelTable.Show();
                panelFilters.Show();
            }
        }

        public void InitializeTable()
        {
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn colIndexCol = new();
            colIndexCol.Name = "Index";
            colIndexCol.DataPropertyName = "Index";
            colIndexCol.ReadOnly = true;

            DataGridViewTextBoxColumn colTextCol = new();
            colTextCol.Name = "Text";
            colTextCol.DataPropertyName = "Text";

            DataGridViewButtonColumn buttoncol = new();
            buttoncol.Name = "Reset";
            buttoncol.Text = "Reset";
            buttoncol.UseColumnTextForButtonValue = true;
            buttoncol.Width = 60;

            dataGridView1.DataSource = mainTable;
            dataGridView1.Columns.Add(colIndexCol);
            dataGridView1.Columns.Add(colTextCol);
            dataGridView1.Columns.Add(buttoncol);

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 580;
            dataGridView1.Columns[0].ReadOnly = true;

        }
        #endregion

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string language = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
            if (language == null)
                language = "en";

            if (customTextInMemory.ContainsKey(language))
                ResetTable(customTextInMemory[language]);
            else
                ResetTable();

            prevSelectedLanguage = language;
        }

        public GameText GetGameTextFromUI(bool export = false)
        {
            GameText transit = new();
            if ((chkTextApply.Enabled) || (export))
            {
                transit.Language = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                Dictionary<string, string> entries = new();
                mainTable = (DataTable)dataGridView1.DataSource;
                foreach (DataRow row in mainTable.Rows)
                    entries.Add(row["Index"].ToString(), row["Text"].ToString());
                    
                transit.Entries = entries;
            }

            return transit;
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("Are you sure you want to reset all game text to their default settings?", "Confirm Reset All Text", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitAsk == DialogResult.Yes)
            {
                string language = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                GameText gametext = new();
                gametext.Language = language;
                gametext.Entries = new(classlib.gameText[language].Entries);
                customTextInMemory[language] = gametext;
                labelDateCreated.Hide();
                ResetTable();
            }
               
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Swapper Text Mod|*.swaptext",
                Title = "Swapper Text Mod",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GameTextCollection loadFile = JsonConvert.DeserializeObject<GameTextCollection>(File.ReadAllText(ofd.FileName));
                ImportTextSwap(loadFile);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string settingsFileName = "swapper_custom_text_" + DateTime.Now.ToString("yyyyMMdd") + ".swaptext";
            if (currentlyLoadedFile != "")
                settingsFileName = currentlyLoadedFile;

            SaveFileDialog sfd = new()
            {
                Filter = "Swapper Text Mod|*.swaptext",
                Title = "Swapper Text Mod",
                FileName = settingsFileName
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // If the file name is not an empty string open it for saving.
                if (sfd.FileName != "")
                {
                    //GameText gametext = GetGameTextFromUI(true);
                    FileStream fs = File.Open(sfd.FileName, FileMode.Create);
                    using StreamWriter sw = new(fs, Encoding.UTF8);
                    gameTextCollection = ExportTextSwap();
                    string json = JsonConvert.SerializeObject(gameTextCollection);
                    sw.Write(json);
                }
            }
        }

        public void ImportTextSwap(GameTextCollection source)
        {
            try
            {
                txtAuthor.Text = source.Author;
                txtTitle.Text = source.Title;
                chkTextApply.Checked = source.IncludeWhenApplied;
                chkSwapFile.Checked = source.IncludeInSave;
                chkAffectAll.Checked = source.ApplyToAllLanguages;
                labelDateCreated.Text = "Date Created: " + source.DateCreated.ToLocalTime().ToString();
                labelDateCreated.Show();
                Dictionary<string, GameText> gametext = source.Collection;
                if (gametext != null)
                {
                    foreach (KeyValuePair<string, GameText> textpair in gametext)
                        customTextInMemory[textpair.Key] = textpair.Value;
                    string language = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                    ResetTable(customTextInMemory[language]);
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new();
                msg.AppendLine(ex.GetType().FullName);
                msg.AppendLine(ex.Message);
                System.Diagnostics.StackTrace st = new();
                msg.AppendLine(st.ToString());
                msg.AppendLine();
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string path = $"{exePath}sor4swapper_error_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log";
                File.AppendAllText(path, msg.ToString());
                MessageBox.Show("An error occurred. A log file has been saved in " + path + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public GameTextCollection ExportTextSwap(bool applyChanges = false)
        {
            gameTextCollection.Author = txtAuthor.Text;
            gameTextCollection.Title = txtTitle.Text;
            gameTextCollection.DateCreated = DateTime.UtcNow;
            gameTextCollection.IncludeWhenApplied = chkTextApply.Checked;
            gameTextCollection.IncludeInSave = chkSwapFile.Checked;
            gameTextCollection.ApplyToAllLanguages = chkAffectAll.Checked;
            if ((chkSwapFile.Checked && !applyChanges) || (chkTextApply.Checked && applyChanges))
                gameTextCollection.Collection = customTextInMemory;

            labelDateCreated.Show();

            return gameTextCollection;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.H))
            {
                //ShowReplaceDialog() or whatever it is you want to do here.
                return true; //we handled the key
            }

            return base.ProcessCmdKey(ref msg, keyData); //we didn't handle it
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbLang.Items.Count > 0)
            {
                string language = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                string index = dataGridView1[0, e.RowIndex].Value.ToString();
                if (chkAffectAll.Checked)
                {
                    foreach (KeyValuePair<string, string> pair in Library.languages)
                        customTextInMemory[pair.Key].Entries[index] = dataGridView1[1, e.RowIndex].Value.ToString();
                }
                else
                {
                    customTextInMemory[language].Entries[index] = dataGridView1[1, e.RowIndex].Value.ToString();
                }
                Color color = Color.Black;
                if (classlib.gameText[language].Entries[index] != dataGridView1[1, e.RowIndex].Value.ToString())
                    color = Color.Crimson;
                dataGridView1[0, e.RowIndex].Style.ForeColor = color;
                dataGridView1[1, e.RowIndex].Style.ForeColor = color;
            }
        }

        private void txtGridIndex_TextChanged(object sender, EventArgs e)
        {
            if (txtGridIndex.Text != "")
                mainTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", "Index", txtGridIndex.Text, "Text", txtGridText.Text);
            else
                mainTable.DefaultView.RowFilter = "";
        }

        private void txtGridText_TextChanged(object sender, EventArgs e)
        {
            if (txtGridText.Text != "")
                mainTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", "Index", txtGridIndex.Text, "Text", txtGridText.Text);
            else
                mainTable.DefaultView.RowFilter = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string selectedLanguage = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                List<string> entriesList = classlib.gameText[selectedLanguage].Entries.Keys.ToList();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = classlib.gameText[selectedLanguage].Entries[entriesList[e.RowIndex]];
            }
        }

        private void btnCopyToAll_Click(object sender, EventArgs e)
        {
            DialogResult copyAsk = MessageBox.Show("Copy all entries to all the other languages? This will overwrite all modifications. Please make sure you have a backup copy of your text modifications if you have a lot of them.", "Confirm Copy All Text", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (copyAsk == DialogResult.Yes)
            {
                string selectedLanguage = Library.languages.ElementAt(cmbLang.SelectedIndex).Key;
                foreach (var textpair in classlib.gameText)
                {
                    if (textpair.Key != selectedLanguage)
                        customTextInMemory[textpair.Key].Entries = customTextInMemory[selectedLanguage].Entries;
                }
            }
        }
    }
}
