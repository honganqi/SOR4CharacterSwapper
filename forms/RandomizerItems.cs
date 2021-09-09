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
    public partial class RandomizerItems : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public RandomizerItems(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            string pickupTooltipText = "Includes:\n";
            string weaponTooltipText = "Includes:\n";
            string goldenTooltipText = "Excludes the following from randomization:\n";
            string goldenIsolateTooltipText = "Isolates the following in their own pool:\n";

            foreach (KeyValuePair<int, Library.Item> item in Library.itemDictionary)
            {
                if (item.Value.IsPickup) pickupTooltipText = pickupTooltipText + " - " + item.Value.Name + "\n";
                if (item.Value.IsWeapon) weaponTooltipText = weaponTooltipText + " - " + item.Value.Name + "\n";
                if (item.Value.IsGolden) goldenTooltipText = goldenTooltipText + " - " + item.Value.Name + "\n";
                if (item.Value.IsGolden) goldenIsolateTooltipText = goldenIsolateTooltipText + " - " + item.Value.Name + "\n";
            }

            toolTipPickups.SetToolTip(btnRandPickups, pickupTooltipText);
            toolTipIgnoreGolden.SetToolTip(checkIgnoreGolden, goldenTooltipText);
            toolTipIsolateGolden.SetToolTip(checkGoldToGold, goldenIsolateTooltipText);
        }

        private void btnRandPickups_Click(object sender, EventArgs e)
        {
            RandomizeItems("pickups");
        }

        private void btnRandWeapons_Click(object sender, EventArgs e)
        {
            RandomizeItems("weapons");
        }

        private void RandomizeItems(string target)
        {
            string questionString;
            if (target == "pickups")
            {
                questionString = "Are you sure you want to randomize PICKUPS?";
            }
            else
            {
                questionString = "Are you sure you want to randomize WEAPONS?";
            }

            DialogResult randomAsk = MessageBox.Show(questionString, "Randomize item swaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (randomAsk == DialogResult.Yes)
            {
                _mainwindow.RandomizeItems(target);
                _mainwindow.ResetForm();
            }
            else
            {
                MessageBox.Show("You ... *sigh*", "Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void RandomizeDestroyables()
        {
            Random randomObj = new Random();
            int randomValue;

            List<int> randomList = Library.destroyableDictionary.Keys.ToList();

            foreach (KeyValuePair<int, Library.Destroyable> asset in Library.destroyableDictionary)
            {
                randomValue = randomObj.Next(0, randomList.Count());
                classlib.AddToList(_mainwindow, "destroyable", asset.Key, randomList[randomValue]);
                if (!allowDuplicates.Checked) randomList.RemoveAt(randomValue);
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("item");
        }

        private void checkIgnoreBoss_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreGolden.Checked)
            {
                checkGoldToGold.Enabled = false;
                checkGoldToGold.Checked = true;
            }
            else
            {
                checkGoldToGold.Enabled = true;
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
