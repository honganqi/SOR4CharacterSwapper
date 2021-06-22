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

namespace SOR4_Replacer
{
    public partial class Info : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public Info(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
        }

        public void UpdateContents()
        {
            labelValidBigfile.Text = "original v5 bigfile";
            labelValidBigfile.ForeColor = Color.ForestGreen;
            labelValidBigfile.Visible = true;
        }

        private void btnRestoreBigfile_Click(object sender, EventArgs e)
        {
            string backupPath = Path.Combine(classlib.gameDir, "bigfile_rep_backup");

            if (File.Exists(backupPath))
            {
                DialogResult res = MessageBox.Show("Are you sure you want to restore all characters to their original settings?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    // this will return false only if backup is not a valid v5 bigfile
                    if (classlib.RestoreBackupFile())
                    {
                        labelValidBigfile.Text = "original v5 bigfile";
                        labelValidBigfile.ForeColor = Color.ForestGreen;
                        _mainwindow.ResetForm();
                        MessageBox.Show("\"bigfile\" has been restored to the original v5 version.", "Bigfile restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _mainwindow.ResetForm();
                        MessageBox.Show("The backup file \"bigfile_rep_backup\" is not a valid v5 backup.", "Bigfile NOT restored", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _mainwindow.ResetForm();
                    MessageBox.Show("You cancelled the bigfile restoration.", "Bigfile restoration cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                _mainwindow.ResetForm();
                MessageBox.Show("The backup file \"bigfile_rep_backup\" does not exist.", "Bigfile NOT restored", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void Info_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void labelBigfileLocationInfo_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void labelBigfileLocationInfo_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void labelBackupMade_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void labelBackupMade_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void labelLoadedSwap_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void labelLoadedSwapFile_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void labelLoadedSwap_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void labelLoadedSwapFile_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }
    }
}
