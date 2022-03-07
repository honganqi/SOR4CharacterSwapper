using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public partial class CustomizerLevels : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public CustomizerLevels(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
        }

        private void Swapper_MouseDown(object sender, MouseEventArgs e)
        {
            //_mainwindow.lastLocation = e.Location;
        }

        private void Swapper_MouseMove(object sender, MouseEventArgs e)
        {
            //_mainwindow.MoveWindow(e);
        }

        private void btnEnableAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvLevelSettings.Rows)
            {
                dr.Cells["teams"].Value = true;
            }
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvLevelSettings.Rows)
            {
                dr.Cells["teams"].Value = false;
            }
        }

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            // add levels to level customizer
            foreach (DataGridViewRow dr in dgvLevelSettings.Rows)
            {
                int levelKey = (int)dr.Cells["origKey"].Value;
                dr.Cells["teams"].Value = classlib.bigfileClass.levelCollection[levelKey].Teams;
            }
        }

        public Dictionary<int, LevelClass> GetValues()
        {
            Dictionary<int, LevelClass> levelCustomizationQueue = new();
            foreach (DataGridViewRow dr in dgvLevelSettings.Rows)
            {
                int levelKey = (int)dr.Cells["origKey"].Value;
                LevelClass levelClass = new(classlib.bigfileClass.levelCollection[levelKey]);
                levelClass.Teams = (bool)dr.Cells["teams"].Value;
                levelCustomizationQueue[levelKey] = levelClass;
            }
            return levelCustomizationQueue;
        }

        private void btnBattleRoyale_Click(object sender, EventArgs e)
        {
            int teamIterator = 3;
            foreach (KeyValuePair<int, Library.Character> charData in Library.characterDictionary)
            {
                if (charData.Value.Path != "n/a")
                {
                    int assetKey = charData.Key;
                    int targetKey = assetKey;

                    // initialize characterClass with original character's original attributes
                    CharacterClass characterClass = new(classlib.bigfileClass.characterCollection[assetKey]);

                    // if character is found in swap list, change characterClass into swap target's original attributes
                    if (classlib.changeList.ContainsKey(assetKey))
                    {
                        targetKey = classlib.changeList[assetKey];
                        characterClass = new(classlib.bigfileClass.characterCollection[targetKey]);
                    }

                    // if character is found in customization list
                    if (classlib.characterCustomizationQueue.ContainsKey(assetKey))
                    {
                        characterClass = new(classlib.characterCustomizationQueue[assetKey]);
                    }

                    characterClass.Team = teamIterator;

                    // if character has an entry in "memory" but not yet added to list
                    if (!classlib.characterCustomizationInMemory.ContainsKey(assetKey))
                    {
                        classlib.characterCustomizationInMemory[assetKey] = characterClass;
                    }
                    classlib.AddCustom(_mainwindow, "character", assetKey, characterClass);
                    foreach (DataGridViewRow dr in dgvLevelSettings.Rows)
                    {
                        dr.Cells["teams"].Value = true;
                    }
                    teamIterator++;
                }

            }
        }
    }
}
