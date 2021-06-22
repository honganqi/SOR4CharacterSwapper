using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SOR4_Replacer
{
    public partial class Swapper : Form
    {
        Assembly imageAssembly = Assembly.GetExecutingAssembly();
        private MainWindow _mainwindow;
        Library classlib;

        public Swapper(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            labelShowListArrow.Text = "\u25B6";
            labelOrigToReplace.Text = "\u2794";
        }

        public void getThumbnail(string mode, int characterIndex)
        {
            string thumbString = Library. characterDictionary[characterIndex].Path;
            thumbString = thumbString.Replace('/', '.');
            Stream thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer." + thumbString + ".png");
            Bitmap thumbBitmap = new Bitmap(thumbStream);
            switch (mode)
            {
                case "original":
                    picThumbOrig.Image = thumbBitmap;
                    break;
                case "replacement":
                    picThumbSwap.Image = thumbBitmap;
                    break;
                case "origList":
                    break;
                case "replaceList":
                    break;
            }
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            getThumbnail("original", cmb.SelectedIndex);
        }

        private void replacementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            getThumbnail("replacement", cmb.SelectedIndex);
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            if ((characterList.SelectedIndex > -1) && (replacementComboBox.SelectedIndex > -1))
            {
                int original = characterList.SelectedIndex;
                int replace = replacementComboBox.SelectedIndex;

                if (!classlib.changeList.ContainsKey(Library.characterDictionary[original].Path))
                {
                    if (original != replace)
                    {
                        if (_mainwindow.Width < 1019) _mainwindow.Width = 1019;
                        btnClearSwapList.Enabled = true;
                        _mainwindow.randomizer.btnClearSwapList.Enabled = true;
                        _mainwindow.dataGridView1.Visible = true;
                        _mainwindow.container.btnStartReplace.Enabled = true;

                        classlib.AddToList(_mainwindow, original, replace);

                        if ((_mainwindow.info.labelLoadedSwapFile.Visible) && (!_mainwindow.info.labelLoadedSwapFile.Text.Contains(" (modified)"))) _mainwindow.info.labelLoadedSwapFile.Text += " (modified)";
                    }
                    else
                    {
                        MessageBox.Show("Uh, really?", "Same characters swapped", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _mainwindow.ClearSwaps();
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
                _mainwindow.Width = _mainwindow.fullWindowWidth;
                btnShowList.Text = "Hide list";
                labelShowListArrow.Text = "\u25C0";
            }
            else
            {
                _mainwindow.Width = _mainwindow.initialWindowWidth;
                btnShowList.Text = "Show list";
                labelShowListArrow.Text = "\u25B6";
            }
        }
    }
}
