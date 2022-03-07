using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace SOR4_Swapper
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
            List<Button> buttons = new()
            {
                btnCharPanel,
                btnItemPanel,
                btnDestroyablesPanel,
                btnLevelPanel,
            };
            Button btnTo = new();
            Form targetForm = new();
            Form listPanelToSwitchTo = new();

            switch (screen)
            {
                case "characters":
                    btnTo = btnCharPanel;
                    listPanelToSwitchTo = _mainwindow.swaplistpanel;
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            targetForm = _mainwindow.swapper;
                            break;
                        case "randomizer":
                            targetForm = _mainwindow.randomizer;
                            break;
                        case "custom":
                            listPanelToSwitchTo = _mainwindow.charactercustomizerpanel;
                            targetForm = _mainwindow.charactercustomizerscreen;
                            break;
                    }
                    break;
                case "items":
                    btnTo = btnItemPanel;
                    listPanelToSwitchTo = _mainwindow.swaplistitempanel;
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            targetForm = _mainwindow.swapperitems;
                            break;
                        case "randomizer":
                            targetForm = _mainwindow.randomizeritems;
                            break;
                        case "custom":
                            listPanelToSwitchTo = _mainwindow.charactercustomizerpanel;
                            targetForm = _mainwindow.charactercustomizerscreen;
                            break;
                    }
                    break;

                case "destroyables":
                    btnTo = btnDestroyablesPanel;
                    listPanelToSwitchTo = _mainwindow.swaplistdestroyablepanel;
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            targetForm = _mainwindow.swapperdestroyables;
                            break;
                        case "randomizer":
                            targetForm = _mainwindow.randomizerdestroyables;
                            break;
                        case "custom":
                            listPanelToSwitchTo = _mainwindow.charactercustomizerpanel;
                            targetForm = _mainwindow.charactercustomizerscreen;
                            break;
                    }
                    break;

                case "levels":
                    btnTo = btnLevelPanel;
                    listPanelToSwitchTo = _mainwindow.swaplistlevelpanel;
                    switch (_mainwindow.functionmode)
                    {
                        case "swapper":
                            targetForm = _mainwindow.swapperlevels;
                            break;
                        case "randomizer":
                            targetForm = _mainwindow.randomizerlevels;
                            break;
                        case "custom":
                            listPanelToSwitchTo = _mainwindow.charactercustomizerpanel;
                            targetForm = _mainwindow.levelcustomizerscreen;
                            break;
                    }
                    break;
                case "presets":
                    btnTo = btnPresetsPanel;
                    targetForm = _mainwindow.randomizerpresets;
                    break;
            }

            if (_mainwindow.functionmode == "randomizer")
            {
                btnPresetsPanel.Show();
            }
            else
            {
                btnPresetsPanel.Hide();
            }

            foreach (Button button in buttons)
            {
                if (
                    (_mainwindow.functionmode == "custom" && button != btnCharPanel)
                    && (_mainwindow.functionmode == "custom" && button != btnLevelPanel)
                    )
                {
                    button.Hide();
                }
                else
                {
                    button.Show();
                    if (button == btnTo)
                    {
                        btnTo.ForeColor = SystemColors.ControlText;
                        btnTo.FlatAppearance.MouseOverBackColor = btnCharPanel.BackColor;
                        btnTo.FlatAppearance.MouseDownBackColor = btnCharPanel.BackColor;
                    }
                    else
                    {
                        button.ForeColor = SystemColors.ControlDarkDark;
                        button.FlatAppearance.MouseOverBackColor = default;
                        button.FlatAppearance.MouseDownBackColor = default;
                    }

                }
            }

            _mainwindow.screenmode = screen;

            if (panelMain.Controls.Find(targetForm.Name, true).FirstOrDefault() == null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(targetForm);
                targetForm.Show();
                panelDivider.BringToFront();
                btnTo.BringToFront();
                panelMain.BringToFront();

                if (listPanelToSwitchTo.Name != "")
                {
                    if (panelMain.Controls.Find(listPanelToSwitchTo.Name, true).FirstOrDefault() == null)
                    {
                        _mainwindow.panelSwapList.Controls.Clear();
                        _mainwindow.panelSwapList.Controls.Add(listPanelToSwitchTo);
                        listPanelToSwitchTo.Show();
                    }
                }
            }
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

        private void btnPresetsPanel_Click(object sender, EventArgs e)
        {
            if (_mainwindow.screenmode != "presets") SwitchTabs("presets");
        }

        private void btnClearAllSwaps_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("all", "swap");
        }

        private void btnClearAllCustomizations_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("all", "custom");
        }

        private void btnUpdateNotif_Click(object sender, EventArgs e)
        {
            _mainwindow.GetUpdate();
        }
    }
}
