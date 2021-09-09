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
    public partial class RandomizerPresets : Form
    {
        private MainWindow _mainwindow;
        Library classlib;

        public string chaosOneTooltipText = "";
        public string chaosTwoTooltipText = "";
        public string chaosThreeTooltipText = "";
        public string chaosFourTooltipText = "";
        public string chaosFiveTooltipText = "";
        public string chaosSixTooltipText = "";


        public RandomizerPresets(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            chaosOneTooltipText = "CHARACTERS:\n" +
                "   Bosses: mixed with all characters (Diva can replace Galsia)\n" +
                "   Minibosses: mixed with all characters\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: mixed with all pickups\n" +
                "   Weapons: mixed with all weapons including Golden Weapons\n" +
                "BREAKABLES: mixed with all breakables\n" +
                "LEVELS:\n" +
                "   Story Levels: mixed with all Story Levels\n" +
                "   Boss Rush: included in Story Levels pool\n" +
                "   Survival Levels: mixed with all Survival Levels";

            chaosTwoTooltipText = "CHARACTERS:\n" +
                "   Bosses: isolated in their own pool\n" +
                "   Minibosses: mixed with all characters\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: mixed with all pickups\n" +
                "   Weapons: mixed with all weapons including Golden Weapons\n" +
                "BREAKABLES: mixed with all breakables\n" +
                "LEVELS:\n" +
                "   Story Levels: mixed with all Story Levels\n" +
                "   Boss Rush: included in Story Levels pool\n" +
                "   Survival Levels: mixed with all Survival Levels";

            chaosThreeTooltipText = "CHARACTERS:\n" +
                "   Bosses: isolated in the \"boss\" pool\n" +
                "   Minibosses: isolated in the \"miniboss\" pool\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: not randomized\n" +
                "   Weapons: mixed with all weapons including Golden Weapons\n" +
                "BREAKABLES: mixed with all breakables\n" +
                "LEVELS:\n" +
                "   Story Levels: mixed with all Story Levels\n" +
                "   Boss Rush: not included in randomization\n" +
                "   Survival Levels: mixed with all Survival Levels";

            chaosFourTooltipText = "CHARACTERS:\n" +
                "   Bosses: isolated in the \"boss\" pool\n" +
                "   Minibosses: isolated in the \"miniboss\" pool\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: not randomized\n" +
                "   Weapons: randomized but Golden Weapons are isolated in their own pool\n" +
                "BREAKABLES: mixed with all breakables\n" +
                "LEVELS:\n" +
                "   Story Levels: mixed with all Story Levels\n" +
                "   Boss Rush: not included in randomization\n" +
                "   Survival Levels: mixed with all Survival Levels";

            chaosFiveTooltipText = "CHARACTERS:\n" +
                "   Bosses: isolated in the \"boss\" pool\n" +
                "   Minibosses: isolated in the \"miniboss\" pool\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: not randomized\n" +
                "   Weapons: randomizes all weapons but Golden Weapons are not randomized at all\n" +
                "BREAKABLES: breakables are randomized in 2 separate pools, Breakables and Destructive\n" +
                "LEVELS:\n" +
                "   Story Levels: mixed with all Story Levels\n" +
                "   Boss Rush: not included in randomization\n" +
                "   Survival Levels: mixed with all Survival Levels";

            chaosSixTooltipText = "CHARACTERS:\n" +
                "   Bosses: not randomized\n" +
                "   Minibosses: isolated in the \"miniboss\" pool\n" +
                "   Regular+: mixed with all characters\n" +
                "ITEMS:\n" +
                "   Pickups: not randomized\n" +
                "   Weapons: not randomized\n" +
                "BREAKABLES: breakables are randomized in 2 separate pools, Breakables and Destructive\n" +
                "LEVELS:\n" +
                "   Story Levels: not randomized\n" +
                "   Boss Rush: not included in randomization\n" +
                "   Survival Levels: not randomized";

            toolTipChaosOne.SetToolTip(btnChaosOne, chaosOneTooltipText);
            toolTipChaosTwo.SetToolTip(btnChaosTwo, chaosTwoTooltipText);
            toolTipChaosThree.SetToolTip(btnChaosThree, chaosThreeTooltipText);
            toolTipChaosFour.SetToolTip(btnChaosFour, chaosFourTooltipText);
            toolTipChaosFive.SetToolTip(btnChaosFive, chaosFiveTooltipText);
            toolTipChaosSix.SetToolTip(btnChaosSix, chaosSixTooltipText);
        }

        private void btnChaosOne_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(1);
        }

        private void btnChaosTwo_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(2);
        }
        private void btnChaosThree_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(3);
        }
        private void btnChaosFour_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(4);
        }
        private void btnChaosFive_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(5);
        }
        private void btnChaosSix_Click(object sender, EventArgs e)
        {
            _mainwindow.ExecuteRandomPreset(6);
        }
        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("character");
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
