using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace SOR4_Swapper
{
    public partial class Swapper : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public Swapper(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            labelOrigToReplace.Text = "\u2794";
            characterList.DrawMode = DrawMode.OwnerDrawFixed;
            characterList.DrawItem += new DrawItemEventHandler(characterList_DrawItem);
            characterList.SelectedIndexChanged += new EventHandler(characterList_SelectedIndexChanged);
            replacementComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            replacementComboBox.DrawItem += new DrawItemEventHandler(characterList_DrawItem);
            replacementComboBox.SelectedIndexChanged += new EventHandler(replacementComboBox_SelectedIndexChanged);
        }

        private void characterList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            if (Library.characterDictionary[e.Index].Path == "n/a")
            {
                fontToUse = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Regular);
            }
            else
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
                e.DrawFocusRectangle();
            }
            e.Graphics.DrawString(characterList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.Text != "") picThumbOrig.Image = _mainwindow.thumbnailslib.getThumbnail("character", cmb.SelectedIndex);
            if (cmb.SelectedIndex != -1)
            {
                if (Library.characterDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
                else
                {
                    if ((replacementComboBox.SelectedIndex != -1) && (Library.characterDictionary[replacementComboBox.SelectedIndex].Path != "n/a"))
                    {
                        btnSetItem.Enabled = true;
                    }
                    else
                    {
                        btnSetItem.Enabled = false;
                    }
                }
            }
        }

        private void replacementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.Text != "") picThumbSwap.Image = _mainwindow.thumbnailslib.getThumbnail("character", cmb.SelectedIndex);
            if (cmb.SelectedIndex != -1)
            {
                if (Library.characterDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
                else
                {
                    if ((characterList.SelectedIndex != -1) && (Library.characterDictionary[characterList.SelectedIndex].Path != "n/a"))
                    {
                        btnSetItem.Enabled = true;
                    }
                    else
                    {
                        btnSetItem.Enabled = false;
                    }
                }
            }
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            if ((characterList.SelectedIndex > -1) && (replacementComboBox.SelectedIndex > -1))
            {
                int original = characterList.SelectedIndex;
                int replace = replacementComboBox.SelectedIndex;

                if (!classlib.changeList.ContainsKey(original))
                {
                    if (original != replace)
                    {
                        if (_mainwindow.Width < _mainwindow.fullWindowWidth) _mainwindow.Width = _mainwindow.fullWindowWidth;
                        _mainwindow.ToggleShowHideListLabels(true);
                        btnClearSwapList.Enabled = true;
                        _mainwindow.randomizer.btnClearSwapList.Enabled = true;
                        _mainwindow.swaplistpanel.dataGridView1.Visible = true;
                        _mainwindow.container.btnStartReplace.Enabled = true;
                        _mainwindow.container.btnClearAllSwaps.Enabled = true;

                        classlib.AddToList(_mainwindow, "character", original, replace);

                        if ((_mainwindow.info.labelLoadedSwapFile.Visible) && (!_mainwindow.info.labelLoadedSwapFile.Text.Contains(" (modified)"))) _mainwindow.info.labelLoadedSwapFile.Text += " (modified)";
                    }
                    else
                    {
                        MessageBox.Show("Uh, really? May we have some sense, please?", "Same characters swapped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The character has already been replaced. Please check again.", "Swap already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //classlib.ResetForm();
            }
            else
            {
                MessageBox.Show("Please make sure, uh... Yeah.", "Character name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("character", "swap");
        }

        private void Swapper_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void Swapper_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void picThumbSwap_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void picThumbSwap_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void picThumbOrig_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void picThumbOrig_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (_mainwindow.Width < _mainwindow.fullWindowWidth)
            {
                _mainwindow.ToggleSwapList(true);
            }
            else
            {
                _mainwindow.ToggleSwapList(false);
            }
        }
    }
}
