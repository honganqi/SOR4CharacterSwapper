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
    public partial class Randomizer : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public Randomizer(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            string playableTooltipText = "Excludes the following from randomization:\n";
            string bossTooltipText = "Excludes the following from randomization:\n";
            string minibossTooltipText = "Excludes the following from randomization:\n";
            string regularplusTooltipText = "Excludes the following from randomization::\n";
            string bossIsolateTooltipText = "Isolates the following in their own pool:\n";
            string minibossIsolateTooltipText = "Isolates the following in their own pool:\n";
            string regularplusIsolateTooltipText = "Isolates the following in their own pool:\n";

            foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
            {
                if (character.Value.IsPlayable) playableTooltipText = playableTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsBoss) bossTooltipText = bossTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsMiniboss) minibossTooltipText = minibossTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsRegularPlus) regularplusTooltipText = regularplusTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsBoss) bossIsolateTooltipText = bossIsolateTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsMiniboss) minibossIsolateTooltipText = minibossIsolateTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsRegularPlus) regularplusIsolateTooltipText = regularplusIsolateTooltipText + " - " + character.Value.Name + "\n";
            }

            toolTipEnemiesOnly.SetToolTip(btnRandomize, playableTooltipText);
            toolTipBoss.SetToolTip(checkIgnoreBoss, bossTooltipText);
            toolTipMiniboss.SetToolTip(checkIgnoreMiniboss, minibossTooltipText);
            toolTipRegularplus.SetToolTip(checkIgnoreRegularplus, regularplusTooltipText);
            toolTipBossIsolate.SetToolTip(checkBossToBoss, bossIsolateTooltipText);
            toolTipMinibossIsolate.SetToolTip(checkMiniToMini, minibossIsolateTooltipText);
            toolTipRegularplusIsolate.SetToolTip(checkRegplusToRegplus, regularplusIsolateTooltipText);
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            RandomizePeople("enemies");
        }

        private void btnRandomizeEverybody_Click(object sender, EventArgs e)
        {
            RandomizePeople("everybody");
        }

        private void RandomizePeople(string target)
        {
            string questionString;
            if (target == "enemies")
            {
                questionString = "Are you sure you want to randomize ENEMIES?";
            }
            else
            {
                questionString = "Are you sure you want to randomize EVERYBODY including playables?";
            }

            DialogResult randomAsk = MessageBox.Show(questionString, "Randomize swaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (randomAsk == DialogResult.Yes)
            {
                _mainwindow.RandomizePeople(target);
                _mainwindow.ResetForm();
            }
            else
            {
                MessageBox.Show("You ... *sigh*", "Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("character");
        }

        private void checkIgnoreBoss_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreBoss.Checked)
            {
                checkBossToBoss.Enabled = false;
                checkBossToBoss.Checked = true;
            }
            else
            {
                checkBossToBoss.Enabled = true;
            }

        }

        private void checkIgnoreMiniboss_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreMiniboss.Checked)
            {
                checkMiniToMini.Enabled = false;
                checkMiniToMini.Checked = true;
            }
            else
            {
                checkMiniToMini.Enabled = true;
            }
        }

        private void checkIgnoreRegPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreRegularplus.Checked)
            {
                checkRegplusToRegplus.Enabled = false;
                checkRegplusToRegplus.Checked = true;
            }
            else
            {
                checkRegplusToRegplus.Enabled = true;
            }
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
