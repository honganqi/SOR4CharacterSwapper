using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SOR4_Swapper
{
    public partial class Info : Form
    {
        MainWindow _mainwindow;
        Library classlib;
        public ToolTip tooltip = new();

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
            string backup_filename;
            string gameVer;
            switch (classlib.gameVer)
            {
                case 5:
                    gameVer = "5";
                    backup_filename = "bigfile_rep_backup";
                    break;
                case 7:
                    gameVer = "7";
                    backup_filename = "bigfile_rep7_backup";
                    break;
                case 713648:
                    gameVer = "7-s r13648";
                    backup_filename = "bigfile_rep7_13648_backup";
                    break;
                default:
                    gameVer = "7-s r13648";
                    backup_filename = "bigfile_rep7_13648_backup";
                    break;
            }
            string backupPath = Path.Combine(classlib.gameDir, backup_filename);

            if (File.Exists(backupPath))
            {
                DialogResult res = MessageBox.Show("Are you sure you want to restore all characters to their original settings?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    /***** v5 stuff *****/
                    // this will return false only if backup is not a valid v5 bigfile
                    if (classlib.RestoreBackupFile())
                    {
                        labelValidBigfile.Text = "original v" + gameVer + " bigfile";
                        labelValidBigfile.ForeColor = Color.ForestGreen;
                        _mainwindow.ResetForm();
                        MessageBox.Show("\"bigfile\" has been restored to the original v" + gameVer + " version.", "Bigfile restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _mainwindow.ResetForm();
                        MessageBox.Show("The backup file \"" + backup_filename + "\" is not a valid v5 backup.", "Bigfile NOT restored", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("The backup file \"" + backup_filename + "\" does not exist.", "Bigfile NOT restored", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
