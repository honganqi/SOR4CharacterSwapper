using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOR4_Swapper
{
    public partial class RandomizerLevels : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public RandomizerLevels(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            string pickupTooltipText = "Randomize these levels among themselves:\n";
            string weaponTooltipText = "Randomize these levels among themselves:\n";
            string everythingTooltipText = "WARNING:\nIf a Survival level gets into Arcade or Stage Select, you will get stuck because the portal will not work.";

            foreach (KeyValuePair<int, Library.Level> asset in Library.levelDictionary)
            {
                if (asset.Value.IsStory || asset.Value.IsChallenge || asset.Value.IsBossRush) pickupTooltipText = pickupTooltipText + " - " + asset.Value.Name + "\n";
                if (asset.Value.IsSurvival) weaponTooltipText = weaponTooltipText + " - " + asset.Value.Name + "\n";
            }

            toolTipEnemiesOnly.SetToolTip(btnRandPlayables, pickupTooltipText);
            toolTipBoss.SetToolTip(btnRandSurvival, weaponTooltipText);
            toolTipMiniboss.SetToolTip(btnRandEverything, everythingTooltipText);
        }

        private void btnRandPickups_Click(object sender, EventArgs e)
        {
            Randomize("playables");
        }

        private void btnRandWeapons_Click(object sender, EventArgs e)
        {
            Randomize("survival");
        }
        private void btnRandEverything_Click(object sender, EventArgs e)
        {
            Randomize("everything");
        }

        private void Randomize(string target)
        {
            string questionString;
            switch (target)
            {
                case "playables":
                    questionString = "Are you sure you want to randomize STORY levels?";
                    break;
                case "survival":
                    questionString = "Are you sure you want to randomize SURVIVAL levels?";
                    break;
                default:
                    questionString = "Are you sure you want to randomize and mix ALL levels?";
                    break;
            }


            DialogResult randomAsk = MessageBox.Show(questionString, "Randomize level swaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (randomAsk == DialogResult.Yes)
            {
                _mainwindow.RandomizeLevels(target);
                _mainwindow.swaplistlevelpanel.dataGridView2.Visible = true;
                _mainwindow.ResetForm();
            }
            else
            {
                MessageBox.Show("You ... *sigh*", "Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("level", "swap");
        }

        private void Randomizer_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void Randomizer_MouseMove(object sender, MouseEventArgs e)
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
