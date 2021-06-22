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
            string playableTooltipText = "Excludes:\n";
            string bossTooltipText = "Includes:\n";
            string minibossTooltipText = "Includes:\n";
            labelShowListArrow.Text = "\u25B6";

            foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
            {
                if (character.Value.IsPlayable) playableTooltipText = playableTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsBoss) bossTooltipText = bossTooltipText + " - " + character.Value.Name + "\n";
                if (character.Value.IsMiniboss) minibossTooltipText = minibossTooltipText + " - " + character.Value.Name + "\n";
            }

            toolTipEnemiesOnly.SetToolTip(btnRandomize, playableTooltipText);
            toolTipBoss.SetToolTip(checkIgnoreBoss, bossTooltipText);
            toolTipMiniboss.SetToolTip(checkIgnoreMiniboss, minibossTooltipText);
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
                Random randomObj = new Random();
                int randomValue;

                List<int> randomList = Library.characterDictionary.Keys.ToList();
                List<int> bossList = new List<int>(randomList);
                List<int> minibossList = new List<int>(randomList);

                // remove all characters based on conditions
                foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
                {
                    if ((target == "enemies") && character.Value.IsPlayable) randomList.Remove(character.Key);
                    //if (checkIgnoreBoss.Checked && character.Value.IsBoss) randomList.Remove(character.Key);
                    if (character.Value.IsBoss)
                    {
                        if (checkIgnoreBoss.Checked || (!checkIgnoreBoss.Checked && checkBossToBoss.Checked))
                            randomList.Remove(character.Key);
                    }
                    if (character.Value.IsMiniboss)
                    {
                        if (checkIgnoreMiniboss.Checked || (!checkIgnoreMiniboss.Checked && checkMiniToMini.Checked))
                        randomList.Remove(character.Key);
                    }
                    if (character.Value.IsExcluded) randomList.Remove(character.Key);
                    if (classlib.changeList.ContainsKey(character.Value.Path)) randomList.Remove(character.Key);
                    if (!character.Value.IsBoss) bossList.Remove(character.Key);
                    if (!character.Value.IsMiniboss) minibossList.Remove(character.Key);
                }

                foreach (KeyValuePair<int, Library.Character> character in Library.characterDictionary)
                {
                    // consider only if:
                    // 1. if target is "enemies" and current character is NOT playable
                    // 2. if target is "everybody" (NOT enemies only)
                    // 3. if Ignore Boss is checked and current character is NOT boss
                    // 4. if Ignore Miniboss is checked and current character is NOT miniboss
                    // 5. if character is NOT excluded
                    if ((((target == "enemies") && !character.Value.IsPlayable) || (target != "enemies")) &&
                        (!checkIgnoreBoss.Checked || (checkIgnoreBoss.Checked && !character.Value.IsBoss)) &&
                        (!checkIgnoreMiniboss.Checked || (checkIgnoreMiniboss.Checked && !character.Value.IsMiniboss)) &&
                        !character.Value.IsExcluded &&
                        !classlib.changeList.ContainsKey(character.Value.Path)
                        )
                    {
                        if (!checkIgnoreBoss.Checked && checkBossToBoss.Checked && character.Value.IsBoss)
                        {
                            randomValue = randomObj.Next(0, bossList.Count());
                            classlib.AddToList(_mainwindow, character.Key, bossList[randomValue]);
                            if (checkDuplicates.Checked)
                            {
                                randomList.Remove(bossList[randomValue]);
                                bossList.RemoveAt(randomValue);
                            }
                        }
                        else
                        if (!checkIgnoreMiniboss.Checked && checkMiniToMini.Checked && character.Value.IsMiniboss)
                        {
                            randomValue = randomObj.Next(0, minibossList.Count());
                            classlib.AddToList(_mainwindow, character.Key, minibossList[randomValue]);
                            if (checkDuplicates.Checked)
                            {
                                randomList.Remove(minibossList[randomValue]);
                                minibossList.RemoveAt(randomValue);
                            }
                        }
                        else
                        {
                            randomValue = randomObj.Next(0, randomList.Count());
                            classlib.AddToList(_mainwindow, character.Key, randomList[randomValue]);
                            if (checkDuplicates.Checked) randomList.RemoveAt(randomValue);
                        }
                    }
                }

                btnClearSwapList.Enabled = true;
                _mainwindow.swapper.btnClearSwapList.Enabled = true;
                _mainwindow.dataGridView1.Visible = true;
                _mainwindow.container.btnStartReplace.Enabled = true;
                _mainwindow.ResetForm();
            }
            else
            {
                MessageBox.Show("You ...", "Randomization cancelled", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps();
        }

        private void checkIgnoreBoss_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreBoss.Checked)
            {
                checkBossToBoss.Enabled = false;
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
            }
            else
            {
                checkMiniToMini.Enabled = true;
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
                _mainwindow.Width = _mainwindow.fullWindowWidth;
                btnShowList.Text = "Hide list";
                labelShowListArrow.Text = "\u25C0";
            }
            else
            {
                _mainwindow.Width = _mainwindow.initialWindowWidth;
                btnShowList.Text = "Show list";
                labelShowListArrow.Text = "\u25B6";
            }
        }
    }
}
