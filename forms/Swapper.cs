﻿using System;
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
            labelOrigToReplace.Text = "\u2794";
            characterList.DrawMode = DrawMode.OwnerDrawFixed;
            characterList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(characterList_DrawItem);
            characterList.SelectedIndexChanged += new System.EventHandler(characterList_SelectedIndexChanged);
            replacementComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            replacementComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(characterList_DrawItem);
            replacementComboBox.SelectedIndexChanged += new System.EventHandler(replacementComboBox_SelectedIndexChanged);
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
            }
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
                        if (_mainwindow.Width < _mainwindow.fullWindowWidth) _mainwindow.Width = _mainwindow.fullWindowWidth;
                        _mainwindow.ToggleShowHideListLabels(true);
                        btnClearSwapList.Enabled = true;
                        _mainwindow.randomizer.btnClearSwapList.Enabled = true;
                        _mainwindow.swaplistpanel.dataGridView1.Visible = true;
                        _mainwindow.container.btnStartReplace.Enabled = true;
                        _mainwindow.container.btnClearAllSwaps.Enabled = true;
                        _mainwindow.btnSave.Enabled = true;
                        _mainwindow.btnSave.Visible = true;

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
            _mainwindow.ClearSwaps("character");
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
