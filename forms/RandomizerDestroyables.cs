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

namespace SOR4_Swapper
{
    public partial class RandomizerDestroyables : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public RandomizerDestroyables(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            string regularsTooltipText = "Randomize all breakables except:\n";
            string destructiveTooltipText = "Randomize only these breakables among themselves:\n";
            string everythingTooltipText = "Mix all breakables! \nMight make for a tough game!";

            foreach (KeyValuePair<int, Library.Destroyable> asset in Library.destroyableDictionary)
            {
                if (asset.Value.IsDestructive)
                {
                    regularsTooltipText = regularsTooltipText + " - " + asset.Value.Name + "\n";
                    destructiveTooltipText = destructiveTooltipText + " - " + asset.Value.Name + "\n";
                }
            }

            toolTipRegularList.SetToolTip(btnRandRegulars, regularsTooltipText);
            toolTipDestructiveList.SetToolTip(btnRandDestructive, destructiveTooltipText);
            toolTipEverything.SetToolTip(btnRandEverything, everythingTooltipText);
            
        }

        private void btnRandRegulars_Click(object sender, EventArgs e)
        {
            Randomize("regulars");
        }

        private void btnRandDestructive_Click(object sender, EventArgs e)
        {
            Randomize("destructive");
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
                case "regulars":
                    questionString = "Are you sure you want to randomize regular breakables only?";
                    break;
                case "destructive":
                    questionString = "Are you sure you want to randomize DESTRUCTIVE breakables only?";
                    break;
                default:
                    questionString = "Are you sure you want to randomize ALL breakable items?";
                    break;
            }

            DialogResult randomAsk = MessageBox.Show(questionString, "Randomize breakable items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (randomAsk == DialogResult.Yes)
            {
                _mainwindow.RandomizeDestroyables(target);
                _mainwindow.swaplistdestroyablepanel.dataGridView2.Visible = true;
                _mainwindow.ResetForm();
            }
            else
            {
                MessageBox.Show("You ... *sigh*", "Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("destroyable", "swap");
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
