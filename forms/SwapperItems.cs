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

namespace SOR4_Swapper
{
    public partial class SwapperItems : Form
    {
        Assembly imageAssembly = Assembly.GetExecutingAssembly();
        private MainWindow _mainwindow;
        Library classlib;

        public SwapperItems(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            labelOrigToReplace.Text = "\u2794";
            cmbItemOriginalList.DrawMode = DrawMode.OwnerDrawFixed;
            cmbItemOriginalList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(itemList_DrawItem);
            cmbItemOriginalList.SelectedIndexChanged += new System.EventHandler(cmbItemOriginalList_SelectedIndexChanged);
            cmbItemReplacementList.DrawMode = DrawMode.OwnerDrawFixed;
            cmbItemReplacementList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(itemList_DrawItem);
            cmbItemReplacementList.SelectedIndexChanged += new System.EventHandler(cmbItemReplacementList_SelectedIndexChanged);
        }

        private void itemList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            if (Library.itemDictionary[e.Index].Path == "n/a")
            {
                fontToUse = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Regular);
            }
            else
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
                e.DrawFocusRectangle();
            }
            e.Graphics.DrawString(cmbItemOriginalList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }

        private void cmbItemOriginalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.Text != "") picThumbOrig.Image = _mainwindow.thumbnailslib.getThumbnail("item", cmb.SelectedIndex);
            if (cmb.SelectedIndex != -1)
            {
                if (Library.itemDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void cmbItemReplacementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.Text != "") picThumbSwap.Image = _mainwindow.thumbnailslib.getThumbnail("item", cmb.SelectedIndex);
            if (cmb.SelectedIndex != -1)
            {
                if (Library.itemDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            if ((cmbItemOriginalList.SelectedIndex > -1) && (cmbItemReplacementList.SelectedIndex > -1))
            {
                int original = cmbItemOriginalList.SelectedIndex;
                int replace = cmbItemReplacementList.SelectedIndex;

                if (!classlib.itemChangeList.ContainsKey(original))
                {
                    if (original != replace)
                    {
                        if (_mainwindow.Width < _mainwindow.fullWindowWidth) _mainwindow.Width = _mainwindow.fullWindowWidth;
                        _mainwindow.ToggleShowHideListLabels(true);
                        btnClearSwapList.Enabled = true;
                        //_mainwindow.randomizer.btnClearSwapList.Enabled = true;
                        _mainwindow.swaplistitempanel.dataGridView2.Visible = true;
                        _mainwindow.container.btnStartReplace.Enabled = true;
                        _mainwindow.container.btnClearAllSwaps.Enabled = true;

                        classlib.AddToList(_mainwindow, "item", original, replace);

                        if ((_mainwindow.info.labelLoadedSwapFile.Visible) && (!_mainwindow.info.labelLoadedSwapFile.Text.Contains(" (modified)"))) _mainwindow.info.labelLoadedSwapFile.Text += " (modified)";
                    }
                    else
                    {
                        MessageBox.Show("Uh, really? May we have some sense, please?", "Same items swapped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The item has already been replaced. Please check again.", "Swap already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //classlib.ResetForm();
            }
            else
            {
                MessageBox.Show("Please make sure, uh... Yeah.", "Item name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("item", "swap");
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
