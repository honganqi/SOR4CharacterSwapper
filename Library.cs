using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SOR4CharacterExplorer;
using System.Reflection;
using System.Drawing;
using System.Security.Cryptography;

namespace SOR4_Replacer
{
    public class Library
    {
        public BigfileExplorer bigfileClass = new BigfileExplorer();

        public class Character
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public bool IsPlayable { get; set; }
            public bool IsBoss { get; set; }
            public bool IsMiniboss { get; set; }
            public bool IsExcluded { get; set; }
        }

        public static Dictionary<int, Character> characterDictionary = new Dictionary<int, Character>
        {
            {0, new Character {Name = "Axel SOR4", Path = "characters/sor4_playables/chrsor4axel", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {1, new Character {Name = "Blaze SOR4", Path = "characters/sor4_playables/chrsor4blaze", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {2, new Character {Name = "Floyd SOR4", Path = "characters/sor4_playables/chrsor4floyd", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {3, new Character {Name = "Cherry SOR4", Path = "characters/sor4_playables/chrsor4cherry", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {4, new Character {Name = "Adam SOR4", Path = "characters/sor4_playables/chrsor4adam", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {5, new Character {Name = "Axel SOR1", Path = "characters/sor1_playables/chrsor1axel", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {6, new Character {Name = "Blaze SOR1", Path = "characters/sor1_playables/chrsor1blaze", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {7, new Character {Name = "Adam SOR1", Path = "characters/sor1_playables/chrsor1adam", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {8, new Character {Name = "Axel SOR2", Path = "characters/sor2_playables/chrsor2axel", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {9, new Character {Name = "Blaze SOR2", Path = "characters/sor2_playables/chrsor2blaze", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {10, new Character {Name = "Max SOR2", Path = "characters/sor2_playables/chrsor2max", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {11, new Character {Name = "Skate SOR2", Path = "characters/sor2_playables/chrsor2skate", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {12, new Character {Name = "Axel SOR3", Path = "characters/sor3_playables/chrsor3axel", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {13, new Character {Name = "Blaze SOR3", Path = "characters/sor3_playables/chrsor3blaze", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {14, new Character {Name = "Skate SOR3", Path = "characters/sor3_playables/chrsor3skate", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {15, new Character {Name = "Dr. Zan SOR3", Path = "characters/sor3_playables/chrsor3zan", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {16, new Character {Name = "Shiva SOR3", Path = "characters/sor3_playables/chrsor3shiva", IsPlayable = true, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {17, new Character {Name = "Diva", Path = "characters/sor4_enemies/chrsor4diva", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {18, new Character {Name = "Commissioner", Path = "characters/sor4_enemies/chrsor4commisser", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {19, new Character {Name = "Nora", Path = "characters/sor4_enemies/nora/chrsor4noraboss", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {20, new Character {Name = "Estel (boss)", Path = "characters/sor4_enemies/estel/chrsor4estel", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {21, new Character {Name = "Barbon", Path = "characters/sor4_enemies/chrsor4barbon", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {22, new Character {Name = "Shiva (boss)", Path = "characters/sor4_enemies/shiva/chrsor4shiva", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {23, new Character {Name = "Shiva (spirit)", Path = "characters/sor4_enemies/shiva/chrsor4shivadouble", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {24, new Character {Name = "Estel (Stage 7)", Path = "characters/sor4_enemies/estel/chrsor4estel_lvl7", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {25, new Character {Name = "Commissioner (Stage 7)", Path = "characters/sor4_enemies/chrsor4commisser_7", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {26, new Character {Name = "Riha", Path = "characters/sor4_enemies/diva/chrsor4mariah", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {27, new Character {Name = "Beyo", Path = "characters/sor4_enemies/diva/chrsor4kalaas", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {28, new Character {Name = "Max (boss)", Path = "characters/sor4_enemies/max/chrsor4max", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {29, new Character {Name = "DJ K-Washi", Path = "characters/sor4_enemies/kwashi/chrsor4kwashi", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {30, new Character {Name = "Mr. Y", Path = "characters/sor4_enemies/mry/chrsor4mry", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {31, new Character {Name = "Ms. Y", Path = "characters/sor4_enemies/msy/chrsor4msy", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {32, new Character {Name = "Mr. Y (end)", Path = "characters/sor4_enemies/mry/chrsor4mry_12", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {33, new Character {Name = "Ms. Y (end)", Path = "characters/sor4_enemies/msy/chrsor4msy_12", IsPlayable = false, IsBoss = true, IsMiniboss = false, IsExcluded = false}},
            {34, new Character {Name = "Koobo", Path = "characters/sor4_enemies/chrsor4koobo", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {35, new Character {Name = "Baabo", Path = "characters/sor4_enemies/koobo/chrsor4baabo", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {36, new Character {Name = "Goro", Path = "characters/sor4_enemies/karate/chrsor4karate_l3_goro", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {37, new Character {Name = "Dokuja", Path = "characters/sor4_enemies/karate/chrsor4karate_l0_masa", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {38, new Character {Name = "Big Ben", Path = "characters/sor4_enemies/bigben/chrsor4bigbenboss", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {39, new Character {Name = "Anry", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l2_anry", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {40, new Character {Name = "Gourmand", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l3_bongo", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {41, new Character {Name = "Heart", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l4_heart", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {42, new Character {Name = "Galsia", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {43, new Character {Name = "B.T.", Path = "characters/sor4_enemies/galsia/chrsor4_l3_bt", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {44, new Character {Name = "Brash", Path = "characters/sor4_enemies/galsia/chrsor4_l4_brash", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {45, new Character {Name = "Garam", Path = "characters/sor4_enemies/galsia/chrsor4_l6_garam", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {46, new Character {Name = "Jonathan", Path = "characters/sor4_enemies/galsia/chrsor4_l7_jonathan", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {47, new Character {Name = "Joseph", Path = "characters/sor4_enemies/galsia/chrsor4_l0_joseph", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {48, new Character {Name = "Galsiaaaaa", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsiasuper", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {49, new Character {Name = "Donovan", Path = "characters/sor4_enemies/donovan/chrsor4_l0_donovan", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {50, new Character {Name = "Altet", Path = "characters/sor4_enemies/donovan/chrsor4_l1_altet", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {51, new Character {Name = "Gudden", Path = "characters/sor4_enemies/donovan/chrsor4_l2_gudden", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {52, new Character {Name = "Z", Path = "characters/sor4_enemies/donovan/chrsor4_l3_z", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {53, new Character {Name = "Y. Signal", Path = "characters/sor4_enemies/chrsor4signal", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {54, new Character {Name = "G. Signal", Path = "characters/sor4_enemies/chrsor4signal_alt", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {55, new Character {Name = "R. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l3_signal_r", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {56, new Character {Name = "D. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l4_signal_d", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {57, new Character {Name = "Dylan", Path = "characters/sor4_enemies/dylan/chrsor4_l0_dylan", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {58, new Character {Name = "Kevin", Path = "characters/sor4_enemies/dylan/chrsor4_l3_kevin", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {59, new Character {Name = "Francis", Path = "characters/sor4_enemies/dylan/chrsor4_l4_francis", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {60, new Character {Name = "Brandon", Path = "characters/sor4_enemies/dylan/chrsor4_l5_brandon", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {61, new Character {Name = "Feroccio", Path = "characters/sor4_enemies/chrsor4cop", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {62, new Character {Name = "Dick", Path = "characters/sor4_enemies/cop/chrsor4cop_l6_grab", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {63, new Character {Name = "Lou", Path = "characters/sor4_enemies/cop/chrsor4cop_l8_badgrab", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {64, new Character {Name = "Barney", Path = "characters/sor4_enemies/cop/chrsor4cop_l3_chief", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {65, new Character {Name = "Murphy", Path = "characters/sor4_enemies/chrsor4elite", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {66, new Character {Name = "Dunphy", Path = "characters/sor4_enemies/elite/chrsor4_l4_elitedark2", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {67, new Character {Name = "Shadow", Path = "characters/sor4_enemies/elite/chrsor4_l5_eliteshadow", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {68, new Character {Name = "Sand", Path = "characters/sor4_enemies/elite/chrsor4_l6_elitelight", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {69, new Character {Name = "Diamond", Path = "characters/sor4_enemies/diamond/chrsor4_l0_diamond", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {70, new Character {Name = "Ruby", Path = "characters/sor4_enemies/diamond/chrsor4_l1_ruby", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {71, new Character {Name = "Garnet", Path = "characters/sor4_enemies/diamond/chrsor4_l2_garnet", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {72, new Character {Name = "Pyrop", Path = "characters/sor4_enemies/diamond/chrsor4_l4_pyrop", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {73, new Character {Name = "Saphyr", Path = "characters/sor4_enemies/diamond/chrsor4_l5_saphyr", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {74, new Character {Name = "Sugar", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l0_sugar", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {75, new Character {Name = "Honey", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l1_honey", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {76, new Character {Name = "Candy", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l2_janet", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {77, new Character {Name = "Caramel", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l3_georgia", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {78, new Character {Name = "Victoria", Path = "characters/sor4_enemies/chrsor4victoria", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {79, new Character {Name = "Elizabeth", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l2_toxyne", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {80, new Character {Name = "Margaret", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffie", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {81, new Character {Name = "Anne", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l4_anne", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {82, new Character {Name = "Raven", Path = "characters/sor4_enemies/raven/chrsor4raven_l0_raven", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {83, new Character {Name = "Condor", Path = "characters/sor4_enemies/raven/chrsor4raven_l1_condor", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {84, new Character {Name = "Sparrow", Path = "characters/sor4_enemies/raven/chrsor4raven_l2_sparrow", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {85, new Character {Name = "Pheasant", Path = "characters/sor4_enemies/raven/chrsor4raven_l4_pheasant", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {86, new Character {Name = "Gold", Path = "characters/sor4_enemies/gold/chrsor4_l0_gold", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {87, new Character {Name = "Silver", Path = "characters/sor4_enemies/gold/chrsor4_l1_silver", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {88, new Character {Name = "Iron", Path = "characters/sor4_enemies/gold/chrsor4_l2_tin", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {89, new Character {Name = "Bronze", Path = "characters/sor4_enemies/gold/chrsor4_l3_bronze", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {90, new Character {Name = "Electra", Path = "characters/sor4_enemies/nora/chrsor4electra", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {91, new Character {Name = "Queen", Path = "characters/sor4_enemies/nora/chrsor4queen", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {92, new Character {Name = "Stiletto", Path = "characters/sor4_enemies/nora/chrsor4stiletto", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {93, new Character {Name = "Jack SOR2", Path = "characters/sor2_enemies/chrsor2jack", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {94, new Character {Name = "Abadede SOR2", Path = "characters/sor2_enemies/chrsor2abadede_challenge", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {95, new Character {Name = "Zamza SOR2", Path = "characters/sor2_enemies/chrsor2zamza_challenge", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {96, new Character {Name = "Galsia SOR2", Path = "characters/sor2_enemies/chrsor2galsia", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {97, new Character {Name = "Donovan SOR2", Path = "characters/sor2_enemies/chrsor2donovan", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {98, new Character {Name = "Mr. X SOR2", Path = "characters/sor2_enemies/chrsor2mrx_challenge", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {99, new Character {Name = "Shiva SOR2 boss", Path = "characters/sor2_enemies/chrsor2shiva_challenge", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},

            {100, new Character {Name = "Galsia (Nora)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsiamaso", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {101, new Character {Name = "B.T. (boss)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia_bt_boss", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {102, new Character {Name = "Galsia (Stage 2 hostage)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia_lowstruggle", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {103, new Character {Name = "Goro (alt)", Path = "characters/sor4_enemies/chrsor4karate", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {104, new Character {Name = "Tatsu", Path = "characters/sor4_enemies/karate/chrsor4karate_l6_tetsu", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {105, new Character {Name = "Tora", Path = "characters/sor4_enemies/karate/chrsor4karate_l7_tiger", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {106, new Character {Name = "Barney (alt)", Path = "characters/sor4_enemies/cop/chrsor4cop_l7_bad", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {107, new Character {Name = "Dunphy (Electro)", Path = "characters/sor4_enemies/elite/chrsor4_l4_elitedark", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {108, new Character {Name = "Ralphy", Path = "characters/sor4_enemies/elite/chrsor4_l3_elitegold", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = false}},
            {109, new Character {Name = "Margaret (non-attacking)", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffie_turret", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {110, new Character {Name = "Riha (Mariah)", Path = "characters/sor4_enemies/diva/chrsor4_l4_tania", IsPlayable = false, IsBoss = false, IsMiniboss = true, IsExcluded = false}},
            {111, new Character {Name = "Koobo (Koobig)", Path = "characters/sor4_enemies/koobo/chrsor4koobig", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {112, new Character {Name = "Gold (alt)", Path = "characters/sor4_enemies/chrsor4gold", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {113, new Character {Name = "Big Ben (Galsia slapper)", Path = "characters/sor4_enemies/chrsor4bigben", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
            {114, new Character {Name = "Raven (alt)", Path = "characters/sor4_enemies/chrsor4raven", IsPlayable = false, IsBoss = false, IsMiniboss = false, IsExcluded = true}},
        };

        public Dictionary<string, int> characterPathToIndex = new Dictionary<string, int>();

        // internal variables
        public Dictionary<string, string> changeList = new Dictionary<string, string>();
        public Dictionary<int, dynamic> changeTo = new Dictionary<int, dynamic>();


        public string bigfile_v5_md5hash = "5e09e0fbb6c351009aae725696afa7fc";
        public string backupLogicState = "none";
        public string gameDir;
        public string bigfilePath;

        public string CreateBackup()
        {
            string filename = "";
            // if loaded v5 bigfile exists (no reason it shouldn't except if user deletes the file while app is running)
            if (File.Exists(bigfilePath))
            {
                if (CheckBigfile(bigfilePath))
                {
                    // create backup of original v5 bigfile if it doesn't exist
                    if (!CheckBigfile(Path.Combine(gameDir, "bigfile_rep_backup"))) filename = "bigfile_rep_backup";
                }
                // if bigfile is modded
                else
                {
                    filename = "bigfile_custom_backup";
                }

            }

            if (filename != "") File.Copy(Path.Combine(bigfilePath), Path.Combine(gameDir, filename), true);

            return filename;
        }

        public bool CheckBigfile(string path = "")
        {
            string thispath = "";
            // if indicated bigfile exists (no reason it shouldn't except if user deletes the file while app is running)
            if (File.Exists(path) && (path != ""))
            {
                // get bigfile MD5 hash to compare if original
                thispath = path;
            }
            else if ((path == null) && (bigfilePath != null))
            {
                thispath = bigfilePath;
            }

            if (thispath != "")
            {
                bigfilePath = thispath;
                gameDir = Path.GetDirectoryName(thispath);
                FileStream file = new FileStream(thispath, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++) sb.Append(retVal[i].ToString("x2"));

                if (sb.ToString() == bigfile_v5_md5hash)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool RestoreBackupFile()
        {
            string backupPath = Path.Combine(gameDir, "bigfile_rep_backup");
            if (File.Exists(backupPath))
            {
                File.Copy(backupPath, Path.Combine(gameDir, "bigfile"), true);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddToList(MainWindow mainwindow, int orig, int replace, string mode = "alldata")
        {
            if (orig != replace)
            {
                Assembly imageAssembly = Assembly.GetExecutingAssembly();
                string thumbString = characterDictionary[orig].Path;
                thumbString = thumbString.Replace('/', '.');
                Stream thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer." + thumbString + ".png");
                Bitmap origThumb = new Bitmap(thumbStream);
                thumbString = characterDictionary[replace].Path;
                thumbString = thumbString.Replace('/', '.');
                thumbStream = imageAssembly.GetManifestResourceStream("SOR4_Replacer." + thumbString + ".png");
                Bitmap newThumb = new Bitmap(thumbStream);
                mainwindow.dataGridView1.Rows.Add("\u2716", origThumb, characterDictionary[orig].Name, "\u2794", newThumb, characterDictionary[replace].Name, orig);

                changeList[characterDictionary[orig].Path] = characterDictionary[replace].Path;
                bigfileClass.AddSwap(orig, replace);

                mainwindow.hasNoPending = false;
                mainwindow.container.labelPending.Visible = true;
                mainwindow.swapper.btnShowList.Enabled = true;
                mainwindow.randomizer.btnShowList.Enabled = true;
            }
        }


    }
}
