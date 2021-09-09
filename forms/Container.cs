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
            btnCharPanel.FlatAppearance.MouseOverBackColor = btnCharPanel.BackColor;
            btnCharPanel.FlatAppearance.MouseDownBackColor = btnCharPanel.BackColor;
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

        public void SwitchTabs(string screen)
        {
            List<Button> buttons = new List<Button>
            {
                btnCharPanel,
                btnItemPanel,
                btnDestroyablesPanel,
                btnLevelPanel,
                btnPresetsPanel,
            };
            Button btnTo = btnCharPanel;

            panelMain.Controls.Clear();
            _mainwindow.panelSwapList.Controls.Clear();

            switch (screen)
            {
                case "characters":
                    btnTo = btnCharPanel;
                    _mainwindow.panelSwapList.Controls.Add(_mainwindow.swaplistpanel);
                    _mainwindow.swaplistpanel.Show();
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            panelMain.Controls.Add(_mainwindow.swapper);
                            _mainwindow.swapper.BringToFront();
                            _mainwindow.swapper.Show();
                            break;
                        case "randomizer":
                            panelMain.Controls.Add(_mainwindow.randomizer);
                            _mainwindow.randomizer.BringToFront();
                            _mainwindow.randomizer.Show();
                            break;
                    }
                    break;
                case "items":
                    btnTo = btnItemPanel;
                    _mainwindow.panelSwapList.Controls.Add(_mainwindow.swaplistitempanel);
                    _mainwindow.swaplistitempanel.Show();
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            panelMain.Controls.Add(_mainwindow.swapperitems);
                            _mainwindow.swapperitems.BringToFront();
                            _mainwindow.swapperitems.Show();
                            break;
                        case "randomizer":
                            panelMain.Controls.Add(_mainwindow.randomizeritems);
                            _mainwindow.randomizeritems.BringToFront();
                            _mainwindow.randomizeritems.Show();
                            break;
                    }
                    break;

                case "destroyables":
                    btnTo = btnDestroyablesPanel;
                    _mainwindow.panelSwapList.Controls.Add(_mainwindow.swaplistdestroyablepanel);
                    _mainwindow.swaplistdestroyablepanel.Show();
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            panelMain.Controls.Add(_mainwindow.swapperdestroyables);
                            _mainwindow.swapperdestroyables.BringToFront();
                            _mainwindow.swapperdestroyables.Show();
                            break;
                        case "randomizer":
                            panelMain.Controls.Add(_mainwindow.randomizerdestroyables);
                            _mainwindow.randomizerdestroyables.BringToFront();
                            _mainwindow.randomizerdestroyables.Show();
                            break;
                    }
                    break;

                case "levels":
                    btnTo = btnLevelPanel;
                    _mainwindow.panelSwapList.Controls.Add(_mainwindow.swaplistlevelpanel);
                    _mainwindow.swaplistlevelpanel.Show();
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            panelMain.Controls.Add(_mainwindow.swapperlevels);
                            _mainwindow.swapperlevels.BringToFront();
                            _mainwindow.swapperlevels.Show();
                            break;
                        case "randomizer":
                            panelMain.Controls.Add(_mainwindow.randomizerlevels);
                            _mainwindow.randomizerlevels.BringToFront();
                            _mainwindow.randomizerlevels.Show();
                            break;
                    }
                    break;
                case "presets":
                    btnTo = btnPresetsPanel;
                    //_mainwindow.panelSwapList.Controls.Add(_mainwindow.swaplistlevelpanel);
                    //_mainwindow.swaplistlevelpanel.Show();
                    panelMain.Controls.Add(_mainwindow.randomizerpresets);
                    _mainwindow.randomizerpresets.BringToFront();
                    _mainwindow.randomizerpresets.Show();
                    /*
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            panelMain.Controls.Add(_mainwindow.swapperlevels);
                            _mainwindow.swapperlevels.BringToFront();
                            _mainwindow.swapperlevels.Show();
                            break;
                        case "randomizer":
                            panelMain.Controls.Add(_mainwindow.randomizerlevels);
                            _mainwindow.randomizerlevels.BringToFront();
                            _mainwindow.randomizerlevels.Show();
                            break;
                    }
                    */
                    break;
            }

            foreach (Button button in buttons)
            {
                button.ForeColor = SystemColors.ControlDarkDark;
                button.FlatAppearance.MouseOverBackColor = default(Color);
                button.FlatAppearance.MouseDownBackColor = default(Color);
            }
            btnTo.ForeColor = SystemColors.ControlText;
            btnTo.FlatAppearance.MouseOverBackColor = btnCharPanel.BackColor;
            btnTo.FlatAppearance.MouseDownBackColor = btnCharPanel.BackColor;

            _mainwindow.screenmode = screen;

            // simulate tabs
            panelDivider.BringToFront();
            btnTo.BringToFront();
            panelMain.BringToFront();
        }

        private void btnCharPanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "characters") SwitchTabs("characters");
        }

        private void btnItemPanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "items") SwitchTabs("items");
        }

        private void btnDestroyablePanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "destroyables") SwitchTabs("destroyables");
        }

        private void btnLevelPanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "levels") SwitchTabs("levels");
        }

        private void btnClearAllSwaps_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("all");
        }

        private void btnPresetsPanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "presets") SwitchTabs("presets");
        }
    }
}
