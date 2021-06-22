using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4_Replacer
{
    public partial class Container : Form
    {
        private MainWindow _mainwindow;

        public Container(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            btnStartReplace.Text = "\u25B6 Apply changes";
        }

        public void ShowForm(string formname)
        {
            switch (formname)
            {
                case "swapper":
                    panelMain.Controls.Add(_mainwindow.swapper);
                    _mainwindow.swapper.Show();
                    break;
                case "randomizer":
                    panelMain.Controls.Add(_mainwindow.randomizer);
                    _mainwindow.randomizer.Show();
                    break;
            }
        }

        private void btnStartReplace_Click(object sender, EventArgs e)
        {
            DialogResult confirmStart = MessageBox.Show("Are you sure you want to do this?\nAs surely as good coffee is black?", "Apply changes?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmStart == DialogResult.OK)
            {
                _mainwindow.ApplyChanges();
            }
            else
            {
                MessageBox.Show("You backed out of a great experience.", "Sad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void imgBMCSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/honganqi");
        }

        private void imgYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/honganqi");
        }

        private void imgTwitch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitch.tv/honganqi");
        }

        private void imgSF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/sor4-character-swapper/");
        }

        private void Container_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void Container_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void labelPending_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void labelPending_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }
    }
}
