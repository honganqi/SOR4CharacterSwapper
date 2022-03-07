using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Security.Cryptography;
using System.Data;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public class Library
    {
        public BigfileExplorer bigfileClass = new();
        public class VersionClass
        {
            [Newtonsoft.Json.JsonProperty("release_date")]
            public String ReleaseDate { get; set; }

            [Newtonsoft.Json.JsonProperty("version")]
            public String Version { get; set; }
            [Newtonsoft.Json.JsonProperty("download_url")]
            public String DownloadURL { get; set; }
            [Newtonsoft.Json.JsonProperty("description")]
            public String Description { get; set; }
        }

        public class Character
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public string Thumbnail { get; set; }
            public string NameIndex { get; set; }
            public string CustomNameIndex { get; set; }
            public bool IsPlayable { get; set; }
            public bool IsBoss { get; set; }
            public bool ReplaceRegs { get; set; }
            public bool ReplacedByRegs { get; set; }
            public bool IsMiniboss { get; set; }
            public bool IsRegularPlus { get; set; }
            public bool IsExcluded { get; set; }
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public string Thumbnail { get; set; }
            public bool IsPickup { get; set; }
            public bool IsWeapon { get; set; }
            public bool IsGolden { get; set; }
            public bool IsExcluded { get; set; }
        }

        public class Destroyable
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public string Thumbnail { get; set; }
            public bool IsBreakable { get; set; }
            public bool IsDestructive { get; set; }
            public bool IsUnbreakable { get; set; }
            public bool IsExcluded { get; set; }
        }
        public class Level
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public string Thumbnail { get; set; }
            public bool IsStory { get; set; }
            public bool IsChallenge { get; set; }
            public bool IsBossRush { get; set; }
            public bool IsBattle { get; set; }
            public bool IsSurvival { get; set; }
            public bool IsTraining { get; set; }
            public bool IsExcluded { get; set; }
        }
        public static Dictionary<int, Character> characterDictionary = new()
        {
            [0] = new Character { Name = "--- PLAYABLES ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [1] = new Character { Name = "Axel SOR4", Path = "characters/sor4_playables/chrsor4axel", Thumbnail = "gui/hud/hud_axel_face", NameIndex = "CHR_SOR4_AXEL", CustomNameIndex = "CHR_SOR4_AXEL", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [2] = new Character { Name = "Blaze SOR4", Path = "characters/sor4_playables/chrsor4blaze", Thumbnail = "gui/hud/hud_blaze_face", NameIndex = "CHR_SOR4_BLAZE", CustomNameIndex = "CHR_SOR4_BLAZE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [3] = new Character { Name = "Cherry SOR4", Path = "characters/sor4_playables/chrsor4cherry", Thumbnail = "gui/hud/hud_cherry_face", NameIndex = "CHR_SOR4_CHERRY", CustomNameIndex = "CHR_SOR4_CHERRY", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [4] = new Character { Name = "Floyd SOR4", Path = "characters/sor4_playables/chrsor4floyd", Thumbnail = "gui/hud/hud_floyd_face", NameIndex = "CHR_SOR4_FLOYD", CustomNameIndex = "CHR_SOR4_FLOYD", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [5] = new Character { Name = "Adam SOR4", Path = "characters/sor4_playables/chrsor4adam", Thumbnail = "gui/hud/hud_adam_face", NameIndex = "CHR_SOR4_ADAM", CustomNameIndex = "CHR_SOR4_ADAM", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [6] = new Character { Name = "Estel SOR4", Path = "characters/sor4_playables/chrsor4estel_playable", Thumbnail = "gui/hud/hud_estel_face", NameIndex = "CHR_ESTEL", CustomNameIndex = "CHR_ESTEL", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [7] = new Character { Name = "Max SOR4", Path = "characters/sor4_playables/chrsor4max_playable", Thumbnail = "gui/hud/hud_max_face", NameIndex = "CHR_MAX", CustomNameIndex = "CHR_MAX", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [8] = new Character { Name = "Shiva SOR4", Path = "characters/sor4_playables/chrsor4shiva", Thumbnail = "gui/hud/hud_shiva_face", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [9] = new Character { Name = "Axel SOR1", Path = "characters/sor1_playables/chrsor1axel", Thumbnail = "gui/hud/hud_sor1_axel", NameIndex = "CHR_SOR1_AXEL", CustomNameIndex = "CHR_SOR1_AXEL", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [10] = new Character { Name = "Blaze SOR1", Path = "characters/sor1_playables/chrsor1blaze", Thumbnail = "gui/hud/hud_sor1_blaze", NameIndex = "CHR_SOR1_BLAZE", CustomNameIndex = "CHR_SOR1_BLAZE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [11] = new Character { Name = "Adam SOR1", Path = "characters/sor1_playables/chrsor1adam", Thumbnail = "gui/hud/hud_sor1_adam", NameIndex = "CHR_SOR1_ADAM", CustomNameIndex = "CHR_SOR1_ADAM", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [12] = new Character { Name = "Axel SOR2", Path = "characters/sor2_playables/chrsor2axel", Thumbnail = "gui/hud/hud_sor2_axel", NameIndex = "CHR_SOR2_AXEL", CustomNameIndex = "CHR_SOR2_AXEL", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [13] = new Character { Name = "Blaze SOR2", Path = "characters/sor2_playables/chrsor2blaze", Thumbnail = "gui/hud/hud_sor2_blaze", NameIndex = "CHR_SOR2_BLAZE", CustomNameIndex = "CHR_SOR2_BLAZE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [14] = new Character { Name = "Max SOR2", Path = "characters/sor2_playables/chrsor2max", Thumbnail = "gui/hud/hud_sor2_max", NameIndex = "CHR_SOR2_MAX", CustomNameIndex = "CHR_SOR2_MAX", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [15] = new Character { Name = "Skate SOR2", Path = "characters/sor2_playables/chrsor2skate", Thumbnail = "gui/hud/hud_sor2_skate", NameIndex = "CHR_SOR2_SKATE", CustomNameIndex = "CHR_SOR2_SKATE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [16] = new Character { Name = "Axel SOR3", Path = "characters/sor3_playables/chrsor3axel", Thumbnail = "gui/hud/hud_sor3_axel", NameIndex = "CHR_SOR3_AXEL", CustomNameIndex = "CHR_SOR3_AXEL", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [17] = new Character { Name = "Blaze SOR3", Path = "characters/sor3_playables/chrsor3blaze", Thumbnail = "gui/hud/hud_sor3_blaze", NameIndex = "CHR_SOR3_BLAZE", CustomNameIndex = "CHR_SOR3_BLAZE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [18] = new Character { Name = "Skate SOR3", Path = "characters/sor3_playables/chrsor3skate", Thumbnail = "gui/hud/hud_sor3_skate", NameIndex = "CHR_SOR3_SKATE", CustomNameIndex = "CHR_SOR3_SKATE", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [19] = new Character { Name = "Dr. Zan SOR3", Path = "characters/sor3_playables/chrsor3zan", Thumbnail = "gui/hud/hud_sor3_zan", NameIndex = "CHR_SOR3_ZAN", CustomNameIndex = "CHR_SOR3_ZAN", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [20] = new Character { Name = "Shiva SOR3", Path = "characters/sor3_playables/chrsor3shiva", Thumbnail = "gui/hud/hud_sor3_shiva", NameIndex = "CHR_SOR3_SHIVA", CustomNameIndex = "CHR_SOR3_SHIVA", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [21] = new Character { Name = "Roo SOR3", Path = "characters/sor3_playables/chrsor3roo", Thumbnail = "gui/hud/hud_sor3_roo", NameIndex = "CHR_SOR3_ROO", CustomNameIndex = "CHR_SOR3_ROO", IsPlayable = true, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [22] = new Character { Name = "--- DIVA ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [23] = new Character { Name = "Diva", Path = "characters/sor4_enemies/diva/chrsor4diva", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4diva", NameIndex = "CHR_DIVA", CustomNameIndex = "CHR_DIVA", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [24] = new Character { Name = "Diva (survival)", Path = "characters/sor4_enemies/diva/chrsor4diva_survival", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4diva", NameIndex = "CHR_DIVA", CustomNameIndex = "CHR_DIVA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [25] = new Character { Name = "Riha", Path = "characters/sor4_enemies/diva/chrsor4mariah", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4mariah", NameIndex = "CHR_RIHA", CustomNameIndex = "CHR_RIHA", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [26] = new Character { Name = "Riha (survival)", Path = "characters/sor4_enemies/diva/chrsor4mariah_survival", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4mariah", NameIndex = "CHR_RIHA", CustomNameIndex = "CHR_RIHA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [27] = new Character { Name = "Beyo", Path = "characters/sor4_enemies/diva/chrsor4kalaas", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4kalaas", NameIndex = "CHR_BEYO", CustomNameIndex = "CHR_BEYO", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [28] = new Character { Name = "Beyo (survival)", Path = "characters/sor4_enemies/diva/chrsor4kalaas_survival", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4kalaas", NameIndex = "CHR_BEYO", CustomNameIndex = "CHR_BEYO_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [29] = new Character { Name = "Weetnee", Path = "characters/sor4_enemies/diva/chrsor4_l4_tania", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4divav4", NameIndex = "CHR_WEETNEE", CustomNameIndex = "CHR_WEETNEE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [30] = new Character { Name = "Weetnee (elite)", Path = "characters/sor4_enemies/diva/chrsor4_l4_tania_elite", Thumbnail = "animatedsprites/sor4/enemies/diva/sprsor4divav4", NameIndex = "CHR_WEETNEE", CustomNameIndex = "CHR_WEETNEE_SURV", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [31] = new Character { Name = "--- COMMISSIONER ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [32] = new Character { Name = "Commissioner", Path = "characters/sor4_enemies/commisser/chrsor4commisser", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisser", NameIndex = "CHR_COMMISSER", CustomNameIndex = "CHR_COMMISSER", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [33] = new Character { Name = "Commissioner (survival)", Path = "characters/sor4_enemies/commisser/chrsor4commisser_survival", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisser", NameIndex = "CHR_COMMISSER", CustomNameIndex = "CHR_COMMISSER_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [34] = new Character { Name = "Commissioner (Stage 7)", Path = "characters/sor4_enemies/commisser/chrsor4commisser_7", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisser", NameIndex = "CHR_COMMISSER", CustomNameIndex = "CHR_COMMISSER_SEVEN", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [35] = new Character { Name = "Deputy", Path = "characters/sor4_enemies/commisser/chrsor4deputy", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisserv3", NameIndex = "CHR_DEPUTY", CustomNameIndex = "CHR_DEPUTY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [36] = new Character { Name = "Deputy (elite)", Path = "characters/sor4_enemies/commisser/chrsor4deputy_elite", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisserv3", NameIndex = "CHR_DEPUTY", CustomNameIndex = "CHR_DEPUTY_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [37] = new Character { Name = "Lieutenant", Path = "characters/sor4_enemies/commisser/chrsor4lieutenant", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisserv2", NameIndex = "CHR_LIEUTENANT", CustomNameIndex = "CHR_LIEUTENANT", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [38] = new Character { Name = "--- NORA ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [39] = new Character { Name = "Nora", Path = "characters/sor4_enemies/nora/chrsor4noraboss", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4nora", NameIndex = "CHR_NORA", CustomNameIndex = "CHR_NORA", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [40] = new Character { Name = "Nora (survival)", Path = "characters/sor4_enemies/nora/chrsor4norabosssurvival", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4nora", NameIndex = "CHR_NORA", CustomNameIndex = "CHR_NORA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [41] = new Character { Name = "Belle", Path = "characters/sor4_enemies/nora/chrsor4electra", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4electra", NameIndex = "CHR_BELLE", CustomNameIndex = "CHR_BELLE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [42] = new Character { Name = "Stiletto", Path = "characters/sor4_enemies/nora/chrsor4queen", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4stiletto", NameIndex = "CHR_STILETTO", CustomNameIndex = "CHR_STILETTO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [43] = new Character { Name = "Stiletto (elite)", Path = "characters/sor4_enemies/nora/chrsor4queen_elite", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4stiletto", NameIndex = "CHR_STILETTO", CustomNameIndex = "CHR_STILETTO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [44] = new Character { Name = "Queen", Path = "characters/sor4_enemies/nora/chrsor4stiletto", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4queen", NameIndex = "CHR_QUEEN", CustomNameIndex = "CHR_QUEEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [45] = new Character { Name = "--- ESTEL ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [46] = new Character { Name = "Estel (boss)", Path = "characters/sor4_enemies/estel/chrsor4estel", Thumbnail = "animatedsprites/sor4/enemies/estel/sprsor4estel", NameIndex = "CHR_ESTEL", CustomNameIndex = "CHR_ESTEL", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [47] = new Character { Name = "Estel (survival)", Path = "characters/sor4_enemies/estel/chrsor4estel_survival", Thumbnail = "animatedsprites/sor4/enemies/estel/sprsor4estel", NameIndex = "CHR_ESTEL", CustomNameIndex = "CHR_ESTEL_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [48] = new Character { Name = "Estel (Stage 7)", Path = "characters/sor4_enemies/estel/chrsor4estel_lvl7", Thumbnail = "animatedsprites/sor4/enemies/estel/sprsor4estel", NameIndex = "CHR_ESTEL", CustomNameIndex = "CHR_ESTEL_SEVEN", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [49] = new Character { Name = "--- BARBON ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [50] = new Character { Name = "Barbon", Path = "characters/sor4_enemies/barbon/chrsor4barbon", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbon", NameIndex = "CHR_BARBON", CustomNameIndex = "CHR_BARBON", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [51] = new Character { Name = "Barbon (survival)", Path = "characters/sor4_enemies/barbon/chrsor4barbonsurvival", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbon", NameIndex = "CHR_BARBON", CustomNameIndex = "CHR_BARBON_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [52] = new Character { Name = "Vulture", Path = "characters/sor4_enemies/barbon/chrsor4vulture", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbonv3", NameIndex = "CHR_VULTURE", CustomNameIndex = "CHR_VULTURE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [53] = new Character { Name = "Wayne", Path = "characters/sor4_enemies/barbon/chrsor4wayne", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbonv2", NameIndex = "CHR_WAYNE", CustomNameIndex = "CHR_WAYNE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [54] = new Character { Name = "Wayne (elite)", Path = "characters/sor4_enemies/barbon/chrsor4wayne_elite", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbonv2", NameIndex = "CHR_WAYNE", CustomNameIndex = "CHR_WAYNE_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [55] = new Character { Name = "--- SHIVA ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [56] = new Character { Name = "Shiva (boss)", Path = "characters/sor4_enemies/shiva/chrsor4shiva", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_BOSS", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [57] = new Character { Name = "Shiva (survival)", Path = "characters/sor4_enemies/shiva/chrsor4shivasurvival", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [58] = new Character { Name = "--- MAX ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [59] = new Character { Name = "Max (boss)", Path = "characters/sor4_enemies/max/chrsor4max", Thumbnail = "animatedsprites/sor4/enemies/max/sprsor4max", NameIndex = "CHR_MAX", CustomNameIndex = "CHR_MAX_BOSS", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [60] = new Character { Name = "Max (survival)", Path = "characters/sor4_enemies/max/chrsor4maxsurvival", Thumbnail = "animatedsprites/sor4/enemies/max/sprsor4max", NameIndex = "CHR_MAX", CustomNameIndex = "CHR_MAX_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [61] = new Character { Name = "--- DJ K-WASHI ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [62] = new Character { Name = "DJ K-Washi", Path = "characters/sor4_enemies/kwashi/chrsor4kwashi", Thumbnail = "animatedsprites/sor4/enemies/dj_k-washi/sprsor4kwashi", NameIndex = "CHR_KWASHI", CustomNameIndex = "CHR_KWASHI", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [63] = new Character { Name = "DJ K-Washi (survival)", Path = "characters/sor4_enemies/kwashi/chrsor4kwashi_survival", Thumbnail = "animatedsprites/sor4/enemies/dj_k-washi/sprsor4kwashi", NameIndex = "CHR_KWASHI", CustomNameIndex = "CHR_KWASHI_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [64] = new Character { Name = "DJ K-Zushi", Path = "characters/sor4_enemies/kwashi/chrsor4kwashiv2", Thumbnail = "animatedsprites/sor4/enemies/dj_k-washi/sprsor4kwashiv2", NameIndex = "CHR_KZUSHI", CustomNameIndex = "CHR_KZUSHI", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [65] = new Character { Name = "DJ K-Nashi", Path = "characters/sor4_enemies/kwashi/chrsor4kwashiv3", Thumbnail = "animatedsprites/sor4/enemies/dj_k-washi/sprsor4kwashiv3", NameIndex = "CHR_KNASHI", CustomNameIndex = "CHR_KNASHI", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [66] = new Character { Name = "--- MR. Y ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [67] = new Character { Name = "Mr. Y", Path = "characters/sor4_enemies/mry/chrsor4mry", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mry", NameIndex = "CHR_MRY", CustomNameIndex = "CHR_MRY", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [68] = new Character { Name = "Mr. Y (survival)", Path = "characters/sor4_enemies/mry/chrsor4mrysurvival", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mry", NameIndex = "CHR_MRY", CustomNameIndex = "CHR_MRY_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [69] = new Character { Name = "Mr. Y (end)", Path = "characters/sor4_enemies/mry/chrsor4mry_12", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mry", NameIndex = "CHR_MRY", CustomNameIndex = "CHR_MRY_END", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [70] = new Character { Name = "Mr. What", Path = "characters/sor4_enemies/mry/chrsor4mry_12_survival", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mryv2", NameIndex = "CHR_MRWHY", CustomNameIndex = "CHR_MRWHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [71] = new Character { Name = "Mr. Whatever", Path = "characters/sor4_enemies/mry/chrsor4mrysurvival2", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mryv3", NameIndex = "CHR_MRKNOWWHY", CustomNameIndex = "CHR_MRKNOWWHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [72] = new Character { Name = "--- MS. Y ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [73] = new Character { Name = "Ms. Y", Path = "characters/sor4_enemies/msy/chrsor4msy", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msy", NameIndex = "CHR_MSY", CustomNameIndex = "CHR_MSY", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [74] = new Character { Name = "Ms. Y (survival)", Path = "characters/sor4_enemies/msy/chrsor4msysurvival", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msy", NameIndex = "CHR_MSY", CustomNameIndex = "CHR_MSY_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [75] = new Character { Name = "Ms. Y (end)", Path = "characters/sor4_enemies/msy/chrsor4msy_12", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msy", NameIndex = "CHR_MSY", CustomNameIndex = "CHR_MSY_END", IsPlayable = false, IsBoss = true, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [76] = new Character { Name = "Ms. What", Path = "characters/sor4_enemies/msy/chrsor4msy_12survival", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msyv2", NameIndex = "CHR_MSWHY", CustomNameIndex = "CHR_MSWHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [77] = new Character { Name = "Ms. Whatever", Path = "characters/sor4_enemies/msy/chrsor4msy_12survival_2", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msyv3", NameIndex = "CHR_MSKNOWWHY", CustomNameIndex = "CHR_MSKNOWWHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [78] = new Character { Name = "Ms. Whatever (elite)", Path = "characters/sor4_enemies/msy/chrsor4msy_12survival_2_elite", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msyv3", NameIndex = "CHR_MSKNOWWHY", CustomNameIndex = "CHR_MSKNOWWHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [79] = new Character { Name = "--- GALSIA ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [80] = new Character { Name = "Galsia", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4galsia", NameIndex = "CHR_GALSIA", CustomNameIndex = "CHR_GALSIA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [81] = new Character { Name = "Joseph", Path = "characters/sor4_enemies/galsia/chrsor4_l0_joseph", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4joseph", NameIndex = "CHR_JOSEPH", CustomNameIndex = "CHR_JOSEPH", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [82] = new Character { Name = "B.T.", Path = "characters/sor4_enemies/galsia/chrsor4_l3_bt", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4bt", NameIndex = "CHR_BT", CustomNameIndex = "CHR_BT", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [83] = new Character { Name = "Brash", Path = "characters/sor4_enemies/galsia/chrsor4_l4_brash", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4brash", NameIndex = "CHR_BRASH", CustomNameIndex = "CHR_BRASH", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [84] = new Character { Name = "Garam", Path = "characters/sor4_enemies/galsia/chrsor4_l6_garam", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4garam", NameIndex = "CHR_GARAM", CustomNameIndex = "CHR_GARAM", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [85] = new Character { Name = "Jonathan", Path = "characters/sor4_enemies/galsia/chrsor4_l7_jonathan", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4jonathan", NameIndex = "CHR_JONATHAN", CustomNameIndex = "CHR_JONATHAN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [86] = new Character { Name = "Jonathan (elite)", Path = "characters/sor4_enemies/galsia/chrsor4_l7_jonathan_elite", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4jonathan", NameIndex = "CHR_JONATHAN", CustomNameIndex = "CHR_JONATHAN_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [87] = new Character { Name = "Surger", Path = "characters/sor4_enemies/galsia/chrsor4_l8_surger", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4surger", NameIndex = "CHR_SURGER", CustomNameIndex = "CHR_SURGER", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [88] = new Character { Name = "B.T. (boss)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia_bt_boss", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4bt", NameIndex = "CHR_GALSIA", CustomNameIndex = "CHR_GALSIA_BTBOSS", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [89] = new Character { Name = "Galsia (Nora)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsiamaso", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4galsia", NameIndex = "CHR_GALSIA", CustomNameIndex = "CHR_GALSIA_NORA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [90] = new Character { Name = "Galsiaaaaa", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsiasuper", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4galsia", NameIndex = "CHR_GALSIASUPER", CustomNameIndex = "CHR_GALSIASUPER", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [91] = new Character { Name = "Galsia (Stage 2 hostage)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia_lowstruggle", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4galsia", NameIndex = "CHR_GALSIA", CustomNameIndex = "CHR_GALSIA_HOSTAGE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [92] = new Character { Name = "--- SIGNAL ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [93] = new Character { Name = "Y. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l0_signal_y", Thumbnail = "animatedsprites/sor4/enemies/signal/sprsor4signal_y", NameIndex = "CHR_SIGNAL_Y", CustomNameIndex = "CHR_SIGNAL_Y", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [94] = new Character { Name = "G. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l1_signal_g", Thumbnail = "animatedsprites/sor4/enemies/signal/sprsor4signal_g", NameIndex = "CHR_SIGNAL_G", CustomNameIndex = "CHR_SIGNAL_G", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [95] = new Character { Name = "R. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l3_signal_r", Thumbnail = "animatedsprites/sor4/enemies/signal/sprsor4signal_r", NameIndex = "CHR_SIGNAL_R", CustomNameIndex = "CHR_SIGNAL_R", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [96] = new Character { Name = "D. Signal", Path = "characters/sor4_enemies/signal/chrsor4_l4_signal_d", Thumbnail = "animatedsprites/sor4/enemies/signal/sprsor4signal_d", NameIndex = "CHR_SIGNAL_D", CustomNameIndex = "CHR_SIGNAL_D", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [97] = new Character { Name = "D. Signal (elite)", Path = "characters/sor4_enemies/signal/chrsor4_l4_signal_d_elite", Thumbnail = "animatedsprites/sor4/enemies/signal/sprsor4signal_d", NameIndex = "CHR_SIGNAL_D", CustomNameIndex = "CHR_SIGNAL_D_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [98] = new Character { Name = "--- DONOVAN ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [99] = new Character { Name = "Donovan", Path = "characters/sor4_enemies/donovan/chrsor4_l0_donovan", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4donovan", NameIndex = "CHR_DONOVAN", CustomNameIndex = "CHR_DONOVAN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [100] = new Character { Name = "Altet", Path = "characters/sor4_enemies/donovan/chrsor4_l1_altet", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4altet", NameIndex = "CHR_ALTET", CustomNameIndex = "CHR_ALTET", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [101] = new Character { Name = "Gudden", Path = "characters/sor4_enemies/donovan/chrsor4_l2_gudden", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4gudden", NameIndex = "CHR_GUDDEN", CustomNameIndex = "CHR_GUDDEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [102] = new Character { Name = "Z", Path = "characters/sor4_enemies/donovan/chrsor4_l3_z", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4z", NameIndex = "CHR_Z", CustomNameIndex = "CHR_Z", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [103] = new Character { Name = "Z (elite)", Path = "characters/sor4_enemies/donovan/chrsor4_l3_z_elite", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4z", NameIndex = "CHR_Z", CustomNameIndex = "CHR_Z_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [104] = new Character { Name = "--- DYLAN ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [105] = new Character { Name = "Dylan", Path = "characters/sor4_enemies/dylan/chrsor4_l0_dylan", Thumbnail = "animatedsprites/sor4/enemies/dylan/sprsor4dylan", NameIndex = "CHR_DYLAN", CustomNameIndex = "CHR_DYLAN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [106] = new Character { Name = "Kevin", Path = "characters/sor4_enemies/dylan/chrsor4_l3_kevin", Thumbnail = "animatedsprites/sor4/enemies/dylan/sprsor4kevin", NameIndex = "CHR_KEVIN", CustomNameIndex = "CHR_KEVIN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [107] = new Character { Name = "Francis", Path = "characters/sor4_enemies/dylan/chrsor4_l4_francis", Thumbnail = "animatedsprites/sor4/enemies/dylan/sprsor4francis", NameIndex = "CHR_FRANCIS", CustomNameIndex = "CHR_FRANCIS", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [108] = new Character { Name = "Brandon", Path = "characters/sor4_enemies/dylan/chrsor4_l5_brandon", Thumbnail = "animatedsprites/sor4/enemies/dylan/sprsor4brandon", NameIndex = "CHR_BRANDON", CustomNameIndex = "CHR_BRANDON", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [109] = new Character { Name = "Brandon (elite)", Path = "characters/sor4_enemies/dylan/chrsor4_l5_brandon_elite", Thumbnail = "animatedsprites/sor4/enemies/dylan/sprsor4brandon", NameIndex = "CHR_BRANDON", CustomNameIndex = "CHR_BRANDON_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [110] = new Character { Name = "--- DIAMOND ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [111] = new Character { Name = "Diamond", Path = "characters/sor4_enemies/diamond/chrsor4_l0_diamond", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4diamond", NameIndex = "CHR_DIAMOND", CustomNameIndex = "CHR_DIAMOND", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [112] = new Character { Name = "Ruby", Path = "characters/sor4_enemies/diamond/chrsor4_l1_ruby", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4ruby", NameIndex = "CHR_RUBY", CustomNameIndex = "CHR_RUBY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [113] = new Character { Name = "Garnet", Path = "characters/sor4_enemies/diamond/chrsor4_l2_garnet", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4garnet", NameIndex = "CHR_GARNET", CustomNameIndex = "CHR_GARNET", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [114] = new Character { Name = "Garnet (elite)", Path = "characters/sor4_enemies/diamond/chrsor4_l2_garnet_elite", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4garnet", NameIndex = "CHR_GARNET", CustomNameIndex = "CHR_GARNET_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [115] = new Character { Name = "Pyrop", Path = "characters/sor4_enemies/diamond/chrsor4_l4_pyrop", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4ruby", NameIndex = "CHR_PYROP", CustomNameIndex = "CHR_PYROP", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [116] = new Character { Name = "Saphyr", Path = "characters/sor4_enemies/diamond/chrsor4_l5_saphyr", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4saphyr", NameIndex = "CHR_SAPHYR", CustomNameIndex = "CHR_SAPHYR", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [117] = new Character { Name = "--- BIKER GIRLS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [118] = new Character { Name = "Sugar", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l0_sugar", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4sugar", NameIndex = "CHR_SUGAR", CustomNameIndex = "CHR_SUGAR", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [119] = new Character { Name = "Honey", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l1_honey", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4honey", NameIndex = "CHR_HONEY", CustomNameIndex = "CHR_HONEY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [120] = new Character { Name = "Candy", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l2_janet", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4janet", NameIndex = "CHR_CANDY", CustomNameIndex = "CHR_CANDY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [121] = new Character { Name = "Candy (elite)", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l2_janet_elite", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4janet", NameIndex = "CHR_CANDY", CustomNameIndex = "CHR_CANDY_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [122] = new Character { Name = "Caramel", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l3_georgia", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4georgia", NameIndex = "CHR_CARAMEL", CustomNameIndex = "CHR_CARAMEL", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [123] = new Character { Name = "--- KICKBOXERS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [124] = new Character { Name = "Raven", Path = "characters/sor4_enemies/raven/chrsor4raven_l0_raven", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4raven", NameIndex = "CHR_RAVEN", CustomNameIndex = "CHR_RAVEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [125] = new Character { Name = "Condor", Path = "characters/sor4_enemies/raven/chrsor4raven_l1_condor", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4condor", NameIndex = "CHR_CONDOR", CustomNameIndex = "CHR_CONDOR", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [126] = new Character { Name = "Sparrow", Path = "characters/sor4_enemies/raven/chrsor4raven_l2_sparrow", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4sparrow", NameIndex = "CHR_SPARROW", CustomNameIndex = "CHR_SPARROW", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [127] = new Character { Name = "Sparrow (elite)", Path = "characters/sor4_enemies/raven/chrsor4raven_l2_sparrow_elite", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4sparrow", NameIndex = "CHR_SPARROW", CustomNameIndex = "CHR_SPARROW_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [128] = new Character { Name = "Pheasant", Path = "characters/sor4_enemies/raven/chrsor4raven_l4_pheasant", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4pheasant", NameIndex = "CHR_PHEASANT", CustomNameIndex = "CHR_PHEASANT", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [129] = new Character { Name = "--- BOMBER GIRLS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [130] = new Character { Name = "Victoria", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l1_victoria", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4victoria", NameIndex = "CHR_VICTORIA", CustomNameIndex = "CHR_VICTORIA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [131] = new Character { Name = "Victoria (elite)", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l1_victoria_elite", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4victoria", NameIndex = "CHR_VICTORIA", CustomNameIndex = "CHR_VICTORIA_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [132] = new Character { Name = "Elizabeth", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l2_toxyne", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4elizabeth", NameIndex = "CHR_ELIZABETH", CustomNameIndex = "CHR_ELIZABETH", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [133] = new Character { Name = "Margaret", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffie", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4margaret", NameIndex = "CHR_MARGARET", CustomNameIndex = "CHR_MARGARET", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [134] = new Character { Name = "Margaret (flashbang)", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffiestun", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4margaret", NameIndex = "CHR_MARGARET", CustomNameIndex = "CHR_MARGARET_FLASH", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [135] = new Character { Name = "Margaret (non-attacking)", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffie_turret", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4margaret", NameIndex = "CHR_MARGARET", CustomNameIndex = "CHR_MARGARET_NON", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [136] = new Character { Name = "Anne", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l4_anne", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4anne", NameIndex = "CHR_ANNE", CustomNameIndex = "CHR_ANNE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [137] = new Character { Name = "--- GUNMEN ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [138] = new Character { Name = "Gold", Path = "characters/sor4_enemies/gold/chrsor4_l0_gold", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4gold", NameIndex = "CHR_GOLD", CustomNameIndex = "CHR_GOLD", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [139] = new Character { Name = "Silver", Path = "characters/sor4_enemies/gold/chrsor4_l1_silver", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4silver", NameIndex = "CHR_SILVER", CustomNameIndex = "CHR_SILVER", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [140] = new Character { Name = "Iron", Path = "characters/sor4_enemies/gold/chrsor4_l2_tin", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4tin", NameIndex = "CHR_IRON", CustomNameIndex = "CHR_IRON", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [141] = new Character { Name = "Iron (elite)", Path = "characters/sor4_enemies/gold/chrsor4_l2_tin_elite", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4tin", NameIndex = "CHR_IRON", CustomNameIndex = "CHR_IRON_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [142] = new Character { Name = "Bronze", Path = "characters/sor4_enemies/gold/chrsor4_l3_bronze", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4bronze", NameIndex = "CHR_BRONZE", CustomNameIndex = "CHR_BRONZE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [143] = new Character { Name = "--- POLICE ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [144] = new Character { Name = "Feroccio", Path = "characters/sor4_enemies/cop/chrsor4cop_l0_cop", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4cop", NameIndex = "CHR_FEROCCIO", CustomNameIndex = "CHR_FEROCCIO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [145] = new Character { Name = "Barney", Path = "characters/sor4_enemies/cop/chrsor4cop_l3_chief", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4copbad", NameIndex = "CHR_BARNEY", CustomNameIndex = "CHR_BARNEY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [146] = new Character { Name = "Dick", Path = "characters/sor4_enemies/cop/chrsor4cop_l6_grab", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4cop2", NameIndex = "CHR_DICK", CustomNameIndex = "CHR_DICK", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [147] = new Character { Name = "Lou", Path = "characters/sor4_enemies/cop/chrsor4cop_l8_badgrab", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4copbad2", NameIndex = "CHR_LOU", CustomNameIndex = "CHR_LOU", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [148] = new Character { Name = "Barnaby", Path = "characters/sor4_enemies/cop/chrsor4cop_l8_rookie", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4copv5", NameIndex = "CHR_BARNABY", CustomNameIndex = "CHR_BARNABY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [149] = new Character { Name = "Barnaby (elite)", Path = "characters/sor4_enemies/cop/chrsor4cop_l8_rookie_elite", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4copv5", NameIndex = "CHR_BARNABY", CustomNameIndex = "CHR_BARNABY_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [150] = new Character { Name = "--- SHIELDS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [151] = new Character { Name = "Murphy", Path = "characters/sor4_enemies/elite/chrsor4_l0_elite", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite", NameIndex = "CHR_MURPHY", CustomNameIndex = "CHR_MURPHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [152] = new Character { Name = "Ralphy", Path = "characters/sor4_enemies/elite/chrsor4_l3_elitegold", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l3_gold", NameIndex = "CHR_RALPHY", CustomNameIndex = "CHR_RALPHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [153] = new Character { Name = "Ralphy (survival)", Path = "characters/sor4_enemies/elite/chrsor4_l3_elitegoldhalberd", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l3_gold", NameIndex = "CHR_RALPHY", CustomNameIndex = "CHR_RALPHY_SURV", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [154] = new Character { Name = "Ralphy (survival elite)", Path = "characters/sor4_enemies/elite/chrsor4_l3_elitegoldhalberd_elite", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l3_gold", NameIndex = "CHR_RALPHY", CustomNameIndex = "CHR_RALPHY_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [155] = new Character { Name = "Dunphy", Path = "characters/sor4_enemies/elite/chrsor4_l4_elitedark2", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l4_dark", NameIndex = "CHR_DUNPHY", CustomNameIndex = "CHR_DUNPHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [156] = new Character { Name = "Dunphy (Electro)", Path = "characters/sor4_enemies/elite/chrsor4_l4_elitedark", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l4_dark", NameIndex = "CHR_DUNPHY", CustomNameIndex = "CHR_DUNPHY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [157] = new Character { Name = "Shadow", Path = "characters/sor4_enemies/elite/chrsor4_l5_eliteshadow", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l5_shadow", NameIndex = "CHR_SHADOW", CustomNameIndex = "CHR_SHADOW", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [158] = new Character { Name = "Sand", Path = "characters/sor4_enemies/elite/chrsor4_l6_elitelight", Thumbnail = "animatedsprites/sor4/enemies/elite/sprsor4elite_l6_light", NameIndex = "CHR_SAND", CustomNameIndex = "CHR_SAND", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [159] = new Character { Name = "--- KARATE ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [160] = new Character { Name = "Dokuja", Path = "characters/sor4_enemies/karate/chrsor4karate_l0_masa", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate_masa", NameIndex = "CHR_DOKUJA", CustomNameIndex = "CHR_DOKUJA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [161] = new Character { Name = "Goro", Path = "characters/sor4_enemies/karate/chrsor4karate_l3_goro", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate", NameIndex = "CHR_GORO", CustomNameIndex = "CHR_GORO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [162] = new Character { Name = "Goro (elite)", Path = "characters/sor4_enemies/karate/chrsor4karate_l3_goro_elite", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate", NameIndex = "CHR_GORO", CustomNameIndex = "CHR_GORO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [163] = new Character { Name = "Tatsu", Path = "characters/sor4_enemies/karate/chrsor4karate_l6_tetsu", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate2", NameIndex = "CHR_TATSU", CustomNameIndex = "CHR_TATSU", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [164] = new Character { Name = "Tora", Path = "characters/sor4_enemies/karate/chrsor4karate_l7_tiger", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate_tiger", NameIndex = "CHR_TORA", CustomNameIndex = "CHR_TORA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [165] = new Character { Name = "--- BIG BEN ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [166] = new Character { Name = "Big Ben", Path = "characters/sor4_enemies/bigben/chrsor4bigbenboss", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4bigben", NameIndex = "CHR_BIGBEN", CustomNameIndex = "CHR_BIGBEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [167] = new Character { Name = "Big Ben (elite)", Path = "characters/sor4_enemies/bigben/chrsor4bigbenboss_elite", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4bigben", NameIndex = "CHR_BIGBEN", CustomNameIndex = "CHR_BIGBEN_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [168] = new Character { Name = "Big Ben (Galsia slapper)", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l0_bigben", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4bigben", NameIndex = "CHR_BIGBEN", CustomNameIndex = "CHR_BIGBEN_GALSIA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [169] = new Character { Name = "Anry", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l2_anry", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4anry", NameIndex = "CHR_ANRY", CustomNameIndex = "CHR_ANRY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [170] = new Character { Name = "Gourmand", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l3_bongo", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4bongo", NameIndex = "CHR_GOURMAND", CustomNameIndex = "CHR_GOURMAND", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [171] = new Character { Name = "Heart", Path = "characters/sor4_enemies/bigben/chrsor4bigben_l4_heart", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4heart", NameIndex = "CHR_HEART", CustomNameIndex = "CHR_HEART", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [172] = new Character { Name = "--- KOOBO ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [173] = new Character { Name = "Koobo", Path = "characters/sor4_enemies/koobo/chrsor4koobo", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobo", NameIndex = "CHR_KOOBO", CustomNameIndex = "CHR_KOOBO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [174] = new Character { Name = "Koobo (less life)", Path = "characters/sor4_enemies/koobo/chrsor4koobolesslife", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobo", NameIndex = "CHR_KOOBO", CustomNameIndex = "CHR_KOOBO_LESS", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [175] = new Character { Name = "Baabo", Path = "characters/sor4_enemies/koobo/chrsor4baabo", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4baabo", NameIndex = "CHR_BAABO", CustomNameIndex = "CHR_BAABO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [176] = new Character { Name = "Baabo (less life)", Path = "characters/sor4_enemies/koobo/chrsor4baabolesslife", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4baabo", NameIndex = "CHR_BAABO", CustomNameIndex = "CHR_BAABO_LESS", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [177] = new Character { Name = "Baabo (less life elite)", Path = "characters/sor4_enemies/koobo/chrsor4baabolesslife_elite", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4baabo", NameIndex = "CHR_BAABO", CustomNameIndex = "CHR_BAABO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [178] = new Character { Name = "Zeebo", Path = "characters/sor4_enemies/koobo/chrsor4zeebo", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobov3", NameIndex = "CHR_ZEEBO", CustomNameIndex = "CHR_ZEEBO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [179] = new Character { Name = "Fuubo", Path = "characters/sor4_enemies/koobo/chrsor4fuubo", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobov4", NameIndex = "CHR_FUUBO", CustomNameIndex = "CHR_FUUBO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [180] = new Character { Name = "--- RETRO SOR1 ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [181] = new Character { Name = "Antonio SOR1", Path = "characters/sor1_enemies/chrsor1antonio", Thumbnail = "animatedsprites/sor1/enemies/sprsor1antonio", NameIndex = "CHR_SOR1_ANTONIO", CustomNameIndex = "CHR_SOR1_ANTONIO", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [182] = new Character { Name = "Antonio SOR1 (elite)", Path = "characters/sor1_enemies/chrsor1antonio_elite", Thumbnail = "animatedsprites/sor1/enemies/sprsor1antonio", NameIndex = "CHR_SOR1_ANTONIO", CustomNameIndex = "CHR_SOR1_ANTONIO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [183] = new Character { Name = "Souther SOR1", Path = "characters/sor1_enemies/chrsor1souther", Thumbnail = "animatedsprites/sor1/enemies/sprsor1souther", NameIndex = "CHR_SOR1_SOUTHER", CustomNameIndex = "CHR_SOR1_SOUTHER", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [184] = new Character { Name = "Souther SOR1 (elite)", Path = "characters/sor1_enemies/chrsor1souther_elite", Thumbnail = "animatedsprites/sor1/enemies/sprsor1souther", NameIndex = "CHR_SOR1_SOUTHER", CustomNameIndex = "CHR_SOR1_SOUTHER_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [185] = new Character { Name = "Abadede SOR1", Path = "characters/sor1_enemies/chrsor1abadede", Thumbnail = "animatedsprites/sor1/enemies/sprsor1abadede", NameIndex = "CHR_SOR1_ABADEDE", CustomNameIndex = "CHR_SOR1_ABADEDE", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [186] = new Character { Name = "Abadede SOR1 (elite)", Path = "characters/sor1_enemies/chrsor1abadede_elite", Thumbnail = "animatedsprites/sor1/enemies/sprsor1abadede", NameIndex = "CHR_SOR1_ABADEDE", CustomNameIndex = "CHR_SOR1_ABADEDE_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [187] = new Character { Name = "Bongo SOR1", Path = "characters/sor1_enemies/chrsor1bongo", Thumbnail = "animatedsprites/sor1/enemies/sprsor1bongo", NameIndex = "CHR_SOR1_BONGO", CustomNameIndex = "CHR_SOR1_BONGO", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [188] = new Character { Name = "Bongo SOR1 (elite)", Path = "characters/sor1_enemies/chrsor1bongo_elite", Thumbnail = "animatedsprites/sor1/enemies/sprsor1bongo", NameIndex = "CHR_SOR1_BONGO", CustomNameIndex = "CHR_SOR1_BONGO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [189] = new Character { Name = "Mr. X SOR1", Path = "characters/sor1_enemies/chrsor1mrx", Thumbnail = "animatedsprites/sor1/enemies/sprsor1mrx", NameIndex = "CHR_SOR1_MRX", CustomNameIndex = "CHR_SOR1_MRX", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [190] = new Character { Name = "Mr. X SOR1 (elite)", Path = "characters/sor1_enemies/chrsor1mrx_elite", Thumbnail = "animatedsprites/sor1/enemies/sprsor1mrx", NameIndex = "CHR_SOR1_MRX", CustomNameIndex = "CHR_SOR1_MRX_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [191] = new Character { Name = "--- RETRO SOR2 ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [192] = new Character { Name = "Galsia SOR2", Path = "characters/sor2_enemies/chrsor2galsia", Thumbnail = "animatedsprites/sor2/enemies/sprsor2galsia", NameIndex = "CHR_SOR2_GALSIA", CustomNameIndex = "CHR_SOR2_GALSIA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [193] = new Character { Name = "Donovan SOR2", Path = "characters/sor2_enemies/chrsor2donovan", Thumbnail = "animatedsprites/sor2/enemies/sprsor2donovan", NameIndex = "CHR_SOR2_DONOVAN", CustomNameIndex = "CHR_SOR2_DONOVAN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [194] = new Character { Name = "Y. Signal SOR2", Path = "characters/sor2_enemies/chrsor2signal", Thumbnail = "animatedsprites/sor2/enemies/sprsor2signal", NameIndex = "CHR_SOR2_SIGNAL", CustomNameIndex = "CHR_SOR2_SIGNAL", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [195] = new Character { Name = "Fog SOR2", Path = "characters/sor2_enemies/chrsor2fog", Thumbnail = "animatedsprites/sor2/enemies/sprsor2fog", NameIndex = "CHR_SOR2_FOG", CustomNameIndex = "CHR_SOR2_FOG", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [196] = new Character { Name = "Raven SOR2", Path = "characters/sor2_enemies/chrsor2raven", Thumbnail = "animatedsprites/sor2/enemies/sprsor2raven", NameIndex = "CHR_SOR2_RAVEN", CustomNameIndex = "CHR_SOR2_RAVEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [197] = new Character { Name = "Electra SOR2", Path = "characters/sor2_enemies/chrsor2electra_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2electra", NameIndex = "CHR_SOR2_ELECTRA", CustomNameIndex = "CHR_SOR2_ELECTRA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [198] = new Character { Name = "Hakuyo SOR2", Path = "characters/sor2_enemies/chrsor2hakuyo", Thumbnail = "animatedsprites/sor2/enemies/sprsor2hakuyo", NameIndex = "CHR_SOR2_HAKUYO", CustomNameIndex = "CHR_SOR2_HAKUYO", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [199] = new Character { Name = "Kusanagi SOR2", Path = "characters/sor2_enemies/chrsor2kusanagi", Thumbnail = "animatedsprites/sor2/enemies/sprsor2kusanagi", NameIndex = "CHR_SOR2_KUSANAGI", CustomNameIndex = "CHR_SOR2_KUSANAGI", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [200] = new Character { Name = "Big Ben SOR2", Path = "characters/sor2_enemies/chrsor2bigben", Thumbnail = "animatedsprites/sor2/enemies/sprsor2bigben", NameIndex = "CHR_BIGBEN", CustomNameIndex = "CHR_BIGBEN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [201] = new Character { Name = "Jack SOR2", Path = "characters/sor2_enemies/chrsor2jack", Thumbnail = "animatedsprites/sor2/enemies/sprsor2jack", NameIndex = "CHR_JACK", CustomNameIndex = "CHR_JACK", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [202] = new Character { Name = "Barbon SOR2", Path = "characters/sor2_enemies/chrsor2barbon_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2barbon", NameIndex = "CHR_SOR2_BARBON", CustomNameIndex = "CHR_SOR2_BARBON", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [203] = new Character { Name = "Barbon SOR2 (elite)", Path = "characters/sor2_enemies/chrsor2barbon_challenge_elite", Thumbnail = "animatedsprites/sor2/enemies/sprsor2barbon", NameIndex = "CHR_SOR2_BARBON", CustomNameIndex = "CHR_SOR2_BARBON_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [204] = new Character { Name = "Abadede SOR2", Path = "characters/sor2_enemies/chrsor2abadede_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2abadede", NameIndex = "CHR_ABADEDE", CustomNameIndex = "CHR_ABADEDE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [205] = new Character { Name = "Abadede SOR2 (survival)", Path = "characters/sor2_enemies/chrsor2abadede_challenge_survival", Thumbnail = "animatedsprites/sor2/enemies/sprsor2abadede", NameIndex = "CHR_ABADEDE", CustomNameIndex = "CHR_ABADEDE_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [206] = new Character { Name = "Abadede SOR2 (survival elite)", Path = "characters/sor2_enemies/chrsor2abadede_challenge_survival_elite", Thumbnail = "animatedsprites/sor2/enemies/sprsor2abadede", NameIndex = "CHR_ABADEDE", CustomNameIndex = "CHR_ABADEDE_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [207] = new Character { Name = "R. Bear SOR2", Path = "characters/sor2_enemies/chrsor2rbear_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2rbear", NameIndex = "CHR_SOR2_RBEAR", CustomNameIndex = "CHR_SOR2_RBEAR", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [208] = new Character { Name = "R. Bear SOR2 (survival elite)", Path = "characters/sor2_enemies/chrsor2rbear_challenge_elite", Thumbnail = "animatedsprites/sor2/enemies/sprsor2rbear", NameIndex = "CHR_SOR2_RBEAR", CustomNameIndex = "CHR_SOR2_RBEAR_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [209] = new Character { Name = "Zamza SOR2", Path = "characters/sor2_enemies/chrsor2zamza_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2zamza", NameIndex = "CHR_ZAMZA", CustomNameIndex = "CHR_ZAMZA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [210] = new Character { Name = "Zamza SOR2 (survival)", Path = "characters/sor2_enemies/chrsor2zamza_challenge_survival", Thumbnail = "animatedsprites/sor2/enemies/sprsor2zamza", NameIndex = "CHR_ZAMZA", CustomNameIndex = "CHR_ZAMZA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [211] = new Character { Name = "Zamza SOR2 (survival elite)", Path = "characters/sor2_enemies/chrsor2zamza_challenge_survival_elite", Thumbnail = "animatedsprites/sor2/enemies/sprsor2zamza", NameIndex = "CHR_ZAMZA", CustomNameIndex = "CHR_ZAMZA_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [212] = new Character { Name = "Mr. X SOR2", Path = "characters/sor2_enemies/chrsor2mrx_challenge", Thumbnail = "animatedsprites/sor2/enemies/sprsor2mrx", NameIndex = "CHR_MRX", CustomNameIndex = "CHR_MRX", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [213] = new Character { Name = "Mr. X SOR2 (survival)", Path = "characters/sor2_enemies/chrsor2mrx_challenge_survival", Thumbnail = "animatedsprites/sor2/enemies/sprsor2mrx", NameIndex = "CHR_MRX", CustomNameIndex = "CHR_MRX_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [214] = new Character { Name = "Mr. X SOR2 (survival elite)", Path = "characters/sor2_enemies/chrsor2mrx_challenge_survival_elite", Thumbnail = "animatedsprites/sor2/enemies/sprsor2mrx", NameIndex = "CHR_MRX", CustomNameIndex = "CHR_MRX_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [215] = new Character { Name = "Shiva SOR2", Path = "characters/sor2_enemies/chrsor2shiva_challenge", Thumbnail = "animatedsprites/sor2/playables/sprsor2shiva", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [216] = new Character { Name = "Shiva SOR2 (survival)", Path = "characters/sor2_enemies/chrsor2shiva_challenge_survival", Thumbnail = "animatedsprites/sor2/playables/sprsor2shiva", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SURV", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [217] = new Character { Name = "Shiva SOR2 (survival elite)", Path = "characters/sor2_enemies/chrsor2shiva_challenge_survival_elite", Thumbnail = "animatedsprites/sor2/playables/sprsor2shiva", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SURV_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [218] = new Character { Name = "--- RETRO SOR3 ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [219] = new Character { Name = "Bruce (spawn)", Path = "characters/sor3_enemies/chrsor3bruce_spawn", Thumbnail = "animatedsprites/sor3/enemies/sprsor3bruce", NameIndex = "CHR_SOR3_BRUCE", CustomNameIndex = "CHR_SOR3_BRUCE_SPAWN", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [220] = new Character { Name = "Galsia SOR3", Path = "characters/sor3_enemies/chrsor3galsia", Thumbnail = "animatedsprites/sor3/enemies/sprsor3galsia", NameIndex = "CHR_SOR3_GALSIA", CustomNameIndex = "CHR_SOR3_GALSIA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [221] = new Character { Name = "Zack/Vice SOR3", Path = "characters/sor3_enemies/chrsor3zack", Thumbnail = "animatedsprites/sor3/enemies/sprsor3zack", NameIndex = "CHR_SOR3_ZACK", CustomNameIndex = "CHR_SOR3_ZACK", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [222] = new Character { Name = "Goldie/Slum SOR3", Path = "characters/sor3_enemies/chrsor3goldie", Thumbnail = "animatedsprites/sor3/enemies/sprsor3goldie", NameIndex = "CHR_SOR3_GOLDIE", CustomNameIndex = "CHR_SOR3_GOLDIE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [223] = new Character { Name = "Tiger SOR3", Path = "characters/sor3_enemies/chrsor3tiger", Thumbnail = "animatedsprites/sor3/enemies/sprsor3tiger", NameIndex = "CHR_SOR3_TIGER", CustomNameIndex = "CHR_SOR3_TIGER", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [224] = new Character { Name = "Mona SOR3", Path = "characters/sor3_enemies/chrsor3monalisa", Thumbnail = "animatedsprites/sor3/enemies/sprsor3monalisa", NameIndex = "CHR_SOR3_MONA", CustomNameIndex = "CHR_SOR3_MONA", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [225] = new Character { Name = "Mona SOR3 (elite)", Path = "characters/sor3_enemies/chrsor3monalisa_elite", Thumbnail = "animatedsprites/sor3/enemies/sprsor3monalisa", NameIndex = "CHR_SOR3_MONA", CustomNameIndex = "CHR_SOR3_MONA_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [226] = new Character { Name = "Lisa SOR3", Path = "characters/sor3_enemies/chrsor3lisamona", Thumbnail = "animatedsprites/sor3/enemies/sprsor3monalisa", NameIndex = "CHR_SOR3_LISA", CustomNameIndex = "CHR_SOR3_LISA", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [227] = new Character { Name = "Lisa SOR3 (less life)", Path = "characters/sor3_enemies/chrsor3lisamonalesslife", Thumbnail = "animatedsprites/sor3/enemies/sprsor3monalisa", NameIndex = "CHR_SOR3_LISA", CustomNameIndex = "CHR_SOR3_LISA_LESS", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = true },
            [228] = new Character { Name = "Yamato SOR3", Path = "characters/sor3_enemies/chrsor3yamato", Thumbnail = "animatedsprites/sor3/enemies/sprsor3yamato", NameIndex = "CHR_SOR3_YAMATO", CustomNameIndex = "CHR_SOR3_YAMATO", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [229] = new Character { Name = "Yamato SOR3 (elite)", Path = "characters/sor3_enemies/chrsor3yamato_elite", Thumbnail = "animatedsprites/sor3/enemies/sprsor3yamato", NameIndex = "CHR_SOR3_YAMATO", CustomNameIndex = "CHR_SOR3_YAMATO_ELITE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [230] = new Character { Name = "Yamato SOR3 (clone)", Path = "characters/sor3_enemies/chrsor3yamatoclone", Thumbnail = "animatedsprites/sor3/enemies/sprsor3yamato", NameIndex = "CHR_SOR3_YAMATO", CustomNameIndex = "CHR_SOR3_YAMATO_CLONE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = true },
            [231] = new Character { Name = "Bruce SOR3", Path = "characters/sor3_enemies/chrsor3bruce", Thumbnail = "animatedsprites/sor3/enemies/sprsor3bruce", NameIndex = "CHR_SOR3_BRUCE", CustomNameIndex = "CHR_SOR3_BRUCE", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [232] = new Character { Name = "Robo X", Path = "characters/sor3_enemies/chrsor3robotx", Thumbnail = "animatedsprites/sor3/enemies/sprsor3robotx", NameIndex = "CHR_SOR3_ROBOX", CustomNameIndex = "CHR_SOR3_ROBOX", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [233] = new Character { Name = "--- ALLIES ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [234] = new Character { Name = "Galsia (ally)", Path = "characters/sor4_enemies/galsia/chrsor4_l0_galsia_ally", Thumbnail = "animatedsprites/sor4/enemies/galsia/sprsor4galsia", NameIndex = "CHR_GALSIA", CustomNameIndex = "CHR_GALSIA_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [235] = new Character { Name = "Donovan (ally)", Path = "characters/sor4_enemies/donovan/chrsor4_l0_donovan_ally", Thumbnail = "animatedsprites/sor4/enemies/donovan/sprsor4donovan", NameIndex = "CHR_DONOVAN", CustomNameIndex = "CHR_DONOVAN_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [236] = new Character { Name = "Dick (ally)", Path = "characters/sor4_enemies/cop/chrsor4cop_l6_grab_ally", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4cop2", NameIndex = "CHR_DICK", CustomNameIndex = "CHR_DICK_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [237] = new Character { Name = "Koobo (ally)", Path = "characters/sor4_enemies/koobo/chrsor4koobolesslife_ally", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobo", NameIndex = "CHR_KOOBO", CustomNameIndex = "CHR_KOOBO_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [238] = new Character { Name = "Big Ben (ally)", Path = "characters/sor4_enemies/bigben/chrsor4bigbenboss_ally", Thumbnail = "animatedsprites/sor4/enemies/bigben/sprsor4bigben", NameIndex = "CHR_BIGBEN", CustomNameIndex = "CHR_BIGBEN_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [239] = new Character { Name = "Garnet (ally)", Path = "characters/sor4_enemies/diamond/chrsor4_l2_garnet_ally", Thumbnail = "animatedsprites/sor4/enemies/diamond/sprsor4garnet", NameIndex = "CHR_GARNET", CustomNameIndex = "CHR_GARNET_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [240] = new Character { Name = "Caramel (ally)", Path = "characters/sor4_enemies/sugar/chrsor4sugar_l3_georgia_ally", Thumbnail = "animatedsprites/sor4/enemies/sugar/sprsor4georgia", NameIndex = "CHR_CARAMEL", CustomNameIndex = "CHR_CARAMEL_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [241] = new Character { Name = "Condor (ally)", Path = "characters/sor4_enemies/raven/chrsor4raven_l1_condor_ally", Thumbnail = "animatedsprites/sor4/enemies/raven/sprsor4condor", NameIndex = "CHR_CONDOR", CustomNameIndex = "CHR_CONDOR_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [242] = new Character { Name = "Goro (ally)", Path = "characters/sor4_enemies/karate/chrsor4karate_l3_goro_ally", Thumbnail = "animatedsprites/sor4/enemies/karate/sprsor4karate", NameIndex = "CHR_GORO", CustomNameIndex = "CHR_GORO_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [243] = new Character { Name = "Margaret (ally)", Path = "characters/sor4_enemies/victoria/chrsor4victoria_l3_steffie_ally", Thumbnail = "animatedsprites/sor4/enemies/victoria/sprsor4margaret", NameIndex = "CHR_MARGARET", CustomNameIndex = "CHR_MARGARET_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [244] = new Character { Name = "Gold (ally)", Path = "characters/sor4_enemies/gold/chrsor4_l0_gold_ally", Thumbnail = "animatedsprites/sor4/enemies/gold/sprsor4gold", NameIndex = "CHR_GOLD", CustomNameIndex = "CHR_GOLD_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [245] = new Character { Name = "Stiletto (ally)", Path = "characters/sor4_enemies/nora/chrsor4stiletto_ally", Thumbnail = "animatedsprites/sor4/enemies/nora/sprsor4stiletto", NameIndex = "CHR_QUEEN", CustomNameIndex = "CHR_QUEEN_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = true, IsExcluded = false },
            [246] = new Character { Name = "Commissioner (ally)", Path = "characters/sor4_enemies/commisser/chrsor4commisser_survival_ally", Thumbnail = "animatedsprites/sor4/enemies/commisser/sprsor4commisser", NameIndex = "CHR_COMMISSER", CustomNameIndex = "CHR_COMMISSER_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [247] = new Character { Name = "Barbon (ally)", Path = "characters/sor4_enemies/barbon/chrsor4barbonsurvival_ally", Thumbnail = "animatedsprites/sor4/enemies/barbon/sprsor4barbon", NameIndex = "CHR_BARBON", CustomNameIndex = "CHR_BARBON_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [248] = new Character { Name = "Mr. Y (ally)", Path = "characters/sor4_enemies/mry/chrsor4mrysurvival_ally", Thumbnail = "animatedsprites/sor4/enemies/mry/sprsor4mry", NameIndex = "CHR_MRY", CustomNameIndex = "CHR_MRY_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [249] = new Character { Name = "Ms. Y (ally)", Path = "characters/sor4_enemies/msy/chrsor4msysurvival_ally", Thumbnail = "animatedsprites/sor4/enemies/msy/sprsor4msy", NameIndex = "CHR_MSY", CustomNameIndex = "CHR_MSY_ALLY", IsPlayable = false, IsBoss = false, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = true, IsRegularPlus = false, IsExcluded = false },
            [250] = new Character { Name = "--- DOPPELGANGERS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [251] = new Character { Name = "Break (doppelganger)", Path = "characters/sor4_enemies/doppelgangers/chrsor4axel_boss", Thumbnail = "animatedsprites/sor4/playables/sprsor4axel", NameIndex = "CHR_SOR4_BREAK", CustomNameIndex = "CHR_SOR4_BREAK", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [252] = new Character { Name = "Blaze (doppelganger)", Path = "characters/sor4_enemies/doppelgangers/chrsor4blaze_boss", Thumbnail = "animatedsprites/sor4/playables/sprsor4blaze", NameIndex = "CHR_SOR4_BLAZE", CustomNameIndex = "CHR_SOR4_BLAZE_DOPPEL", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [253] = new Character { Name = "Adam (doppelganger)", Path = "characters/sor4_enemies/doppelgangers/chrsor4adam_boss", Thumbnail = "animatedsprites/sor4/playables/sprsor4adam", NameIndex = "CHR_SOR4_ADAM", CustomNameIndex = "CHR_SOR4_ADAM_DOPPEL", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [254] = new Character { Name = "Floyd (doppelganger)", Path = "characters/sor4_enemies/doppelgangers/chrsor4floyd_boss", Thumbnail = "animatedsprites/sor4/playables/sprsor4floyd", NameIndex = "CHR_SOR4_FLOYD", CustomNameIndex = "CHR_SOR4_FLOYD_DOPPEL", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [255] = new Character { Name = "Cherry (doppelganger)", Path = "characters/sor4_enemies/doppelgangers/chrsor4cherry_boss", Thumbnail = "animatedsprites/sor4/playables/sprsor4cherry", NameIndex = "CHR_SOR4_CHERRY", CustomNameIndex = "CHR_SOR4_CHERRY_DOPPEL", IsPlayable = false, IsBoss = true, ReplaceRegs = true, ReplacedByRegs = true, IsMiniboss = false, IsRegularPlus = false, IsExcluded = false },
            [256] = new Character { Name = "--- MISCELLANEOUS ---", Path = "n/a", Thumbnail = "", NameIndex = "", CustomNameIndex = "", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [257] = new Character { Name = "Shiva (boss spirit)", Path = "characters/sor4_enemies/shiva/chrsor4shivadouble", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_BOSS_SPIRIT", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [258] = new Character { Name = "Shiva (special forward)", Path = "characters/sor4_playables/chrsor4shivaspecialforward", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SPECFWD", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [259] = new Character { Name = "Shiva (air special 1)", Path = "characters/sor4_playables/chrsor4shivaairspecial1", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SPECAIR1", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [260] = new Character { Name = "Shiva (air special 2)", Path = "characters/sor4_playables/chrsor4shivaairspecial2", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_SPECAIR2", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [261] = new Character { Name = "Shiva (ultra)", Path = "characters/sor4_playables/chrsor4shivaultra", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_ULTRA", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [262] = new Character { Name = "Shiva (double survival)", Path = "characters/sor4_enemies/shiva/chrsor4shivadoublesurvival", Thumbnail = "animatedsprites/sor4/enemies/shiva/sprsor4shiva_double", NameIndex = "CHR_SHIVA", CustomNameIndex = "CHR_SHIVA_DOUBLE", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [263] = new Character { Name = "Barney (alt)", Path = "characters/sor4_enemies/cop/chrsor4cop_l7_bad", Thumbnail = "animatedsprites/sor4/enemies/cop/sprsor4copbad", NameIndex = "CHR_BARNEY", CustomNameIndex = "CHR_BARNEY_ALT", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
            [264] = new Character { Name = "Koobo (Koobig)", Path = "characters/sor4_enemies/koobo/chrsor4koobig", Thumbnail = "animatedsprites/sor4/enemies/koobo/sprsor4koobo", NameIndex = "CHR_KOOBIG", CustomNameIndex = "CHR_KOOBIG", IsPlayable = false, IsBoss = false, ReplaceRegs = false, ReplacedByRegs = false, IsMiniboss = false, IsRegularPlus = false, IsExcluded = true },
        };
        public static Dictionary<int, Item> itemDictionary = new()
        {
            [0] = new Item { Name = "--- PICKUPS ---", Path = "n/a", Thumbnail = "", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [1] = new Item { Name = "Star", Path = "objects/pickup_star", Thumbnail = "animatedsprites/sor4/pickups/sprstarobj/starobj0000", IsPickup = true, IsWeapon = false, IsGolden = false, IsExcluded = false },
            [2] = new Item { Name = "Chicken", Path = "objects/pickup_chicken", Thumbnail = "animatedsprites/sor4/pickups/chicken", IsPickup = true, IsWeapon = false, IsGolden = false, IsExcluded = false },
            [3] = new Item { Name = "Apple", Path = "objects/pickup_apple", Thumbnail = "animatedsprites/sor4/pickups/apple", IsPickup = true, IsWeapon = false, IsGolden = false, IsExcluded = false },
            [4] = new Item { Name = "Money (big)", Path = "objects/pickup_money_big", Thumbnail = "animatedsprites/sor4/pickups/money_case", IsPickup = true, IsWeapon = false, IsGolden = false, IsExcluded = false },
            [5] = new Item { Name = "Money (small)", Path = "objects/pickup_money_small", Thumbnail = "animatedsprites/sor4/pickups/money_bag", IsPickup = true, IsWeapon = false, IsGolden = false, IsExcluded = false },
            [6] = new Item { Name = "--- WEAPONS ---", Path = "n/a", Thumbnail = "", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [7] = new Item { Name = "Axe", Path = "objects/pickup_axe", Thumbnail = "animatedsprites/sor4/weapons/hache/hache_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [8] = new Item { Name = "Ball", Path = "objects/pickup_ball", Thumbnail = "animatedsprites/sor4/weapons/ball", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [9] = new Item { Name = "Baseball Bat", Path = "objects/pickup_bat", Thumbnail = "animatedsprites/sor4/weapons/baseballbat", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [10] = new Item { Name = "Big Hammer", Path = "objects/pickup_mass", Thumbnail = "animatedsprites/sor4/weapons/mass/mass", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [11] = new Item { Name = "Big Knife", Path = "objects/pickup_bigknife", Thumbnail = "animatedsprites/sor4/weapons/big_knife/big_knife_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [12] = new Item { Name = "Bike Seat", Path = "objects/pickup_torque", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_barbon/ul_moto_barbon", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [13] = new Item { Name = "Boomerang", Path = "objects/pickup_boomrang", Thumbnail = "animatedsprites/sor4/weapons/boomerang/boomerang", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [14] = new Item { Name = "Boomerang (golden)", Path = "objects/pickup_boomrang_gold", Thumbnail = "animatedsprites/sor4/weapons/golden_boomerang/golden_boomerang", IsPickup = false, IsWeapon = true, IsGolden = true, IsExcluded = false },
            [15] = new Item { Name = "Bottle", Path = "objects/pickup_bottle", Thumbnail = "animatedsprites/sor4/weapons/bouteille/bouteille_step2", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [16] = new Item { Name = "Bottle (broken)", Path = "objects/pickup_bottle_broken", Thumbnail = "animatedsprites/sor4/weapons/bouteille/bouteille_step1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [17] = new Item { Name = "Bowling Ball", Path = "objects/pickup_bowling_ball", Thumbnail = "animatedsprites/sor4/weapons/bowling/bowling", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [18] = new Item { Name = "Brick", Path = "objects/pickup_brick", Thumbnail = "animatedsprites/sor4/weapons/brick/brick", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [19] = new Item { Name = "Broom", Path = "objects/pickup_broom", Thumbnail = "animatedsprites/sor4/weapons/broom/broom_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [20] = new Item { Name = "Butcher Knife", Path = "objects/pickup_butcherknife", Thumbnail = "animatedsprites/sor4/weapons/butcher", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [21] = new Item { Name = "Chicken (golden)", Path = "objects/pickup_golden_chicken", Thumbnail = "animatedsprites/sor4/destroyables/sprgoldenchicken/poulet_or_object", IsPickup = false, IsWeapon = true, IsGolden = true, IsExcluded = false },
            [22] = new Item { Name = "Chili Pepper", Path = "objects/pickup_pepper", Thumbnail = "animatedsprites/sor4/weapons/pepper/chili_pepper_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [23] = new Item { Name = "Chinese Sword", Path = "objects/pickup_chinese_sword", Thumbnail = "animatedsprites/sor4/weapons/chinese_swords/blue_chinese_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [24] = new Item { Name = "Chinese Sword (big)", Path = "objects/pickup_big_chinese_sword", Thumbnail = "animatedsprites/sor4/weapons/chinese_swords/red_chinese_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [25] = new Item { Name = "Durian", Path = "objects/pickup_durian", Thumbnail = "animatedsprites/sor4/weapons/durian/durian", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [26] = new Item { Name = "Eel", Path = "objects/pickup_eel", Thumbnail = "animatedsprites/sor4/weapons/eel/eel_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [27] = new Item { Name = "Gladiator Stick", Path = "objects/pickup_gladiator_stick", Thumbnail = "animatedsprites/sor4/weapons/gladiator_stick/gladiator_stick_red_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [28] = new Item { Name = "Golf Club", Path = "objects/pickup_golf", Thumbnail = "animatedsprites/sor4/weapons/golf/golf_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [29] = new Item { Name = "Grenade", Path = "objects/pickup_grenade", Thumbnail = "animatedsprites/sor4/weapons/grenade_military", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [30] = new Item { Name = "Grenade (Estel fast)", Path = "objects/pickup_grenade_estel_fast", Thumbnail = "animatedsprites/sor4/weapons/grenade_military", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [31] = new Item { Name = "Grenade (Estel stun fast)", Path = "objects/pickup_grenade_stun_estel_fast", Thumbnail = "animatedsprites/sor4/weapons/grenade/grenade_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [32] = new Item { Name = "Grenade (Estel)", Path = "objects/pickup_grenade_estel", Thumbnail = "animatedsprites/sor4/weapons/grenade_military", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [33] = new Item { Name = "Grenade (Mr. Y)", Path = "objects/pickup_grenade_mry", Thumbnail = "animatedsprites/sor4/weapons/grenade_military", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [34] = new Item { Name = "Grenade (stun long)", Path = "objects/pickup_grenade_stun_long", Thumbnail = "animatedsprites/sor4/weapons/grenade/grenade_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [35] = new Item { Name = "Grenade (stun)", Path = "objects/pickup_grenade_stun", Thumbnail = "animatedsprites/sor4/weapons/grenade/grenade_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [36] = new Item { Name = "Halberd", Path = "objects/pickup_halberd", Thumbnail = "animatedsprites/sor4/weapons/halberd/halberd01", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [37] = new Item { Name = "Halberd (golden)", Path = "objects/pickup_halberd_gold", Thumbnail = "animatedsprites/sor4/weapons/golden_hallebarde/golden_halberd01", IsPickup = false, IsWeapon = true, IsGolden = true, IsExcluded = false },
            [38] = new Item { Name = "Hammer", Path = "objects/pickup_hammer", Thumbnail = "animatedsprites/sor4/weapons/hammer/hammer_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [39] = new Item { Name = "Hockey Stick", Path = "objects/survival/pickup_cross", Thumbnail = "animatedsprites/sor4/weapons/cross/blue_cross", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [40] = new Item { Name = "Katana", Path = "objects/pickup_katana", Thumbnail = "animatedsprites/sor4/weapons/katana", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [41] = new Item { Name = "Knife", Path = "objects/pickup_knife", Thumbnail = "animatedsprites/sor4/weapons/knife", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [42] = new Item { Name = "Knife (golden)", Path = "objects/pickup_knife_gold", Thumbnail = "animatedsprites/sor4/weapons/golden_knife/golden_knife", IsPickup = false, IsWeapon = true, IsGolden = true, IsExcluded = false },
            [43] = new Item { Name = "Land Mine", Path = "objects/pickup_mine", Thumbnail = "animatedsprites/sor4/weapons/mine/mine_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [44] = new Item { Name = "Lead Pipe", Path = "objects/pickup_lead_pipe", Thumbnail = "animatedsprites/sor4/weapons/pipe", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [45] = new Item { Name = "Lead Pipe (golden)", Path = "objects/pickup_gold_pipe", Thumbnail = "animatedsprites/sor4/weapons/golden_pipe/golden_pipe", IsPickup = false, IsWeapon = true, IsGolden = true, IsExcluded = false },
            [46] = new Item { Name = "Lead Pipe (invincible)", Path = "objects/pickup_lead_pipe_invincible", Thumbnail = "animatedsprites/sor4/weapons/pipe", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [47] = new Item { Name = "Lightsaber", Path = "objects/pickup_laser_sabre", Thumbnail = "animatedsprites/sor4/weapons/lightsaber/lightsaber_blade", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [48] = new Item { Name = "Morning Star", Path = "objects/pickup_fleau", Thumbnail = "animatedsprites/sor4/weapons/fleau", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [49] = new Item { Name = "Nailed Bat", Path = "objects/pickup_nailed_bat", Thumbnail = "animatedsprites/sor4/weapons/naileddown_bat/naileddown_bat", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [50] = new Item { Name = "Pool Cue", Path = "objects/pickup_pool_queue", Thumbnail = "animatedsprites/sor4/weapons/canne_billard/canne_billard_normal", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [51] = new Item { Name = "Pool Cue (broken)", Path = "objects/pickup_pool_queue_broken", Thumbnail = "animatedsprites/sor4/weapons/canne_billard/canne_break", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [52] = new Item { Name = "Pufferfish", Path = "objects/pickup_fugu", Thumbnail = "animatedsprites/sor4/weapons/fugu/fugu_ground_2", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [53] = new Item { Name = "Road Sign", Path = "objects/pickup_roadsign", Thumbnail = "animatedsprites/sor4/weapons/road_sign/road_sign_2", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [54] = new Item { Name = "Sai", Path = "objects/pickup_sai", Thumbnail = "animatedsprites/sor4/weapons/sai/sai_1", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [55] = new Item { Name = "Shuriken", Path = "objects/pickup_shuriken", Thumbnail = "animatedsprites/sor4/weapons/shuriken/shuriken", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [56] = new Item { Name = "Sword", Path = "objects/pickup_sword", Thumbnail = "animatedsprites/sor4/weapons/epee", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [57] = new Item { Name = "Sword (black)", Path = "objects/pickup_black_sword", Thumbnail = "animatedsprites/sor4/weapons/sword_black/black_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [58] = new Item { Name = "Sword (fire)", Path = "objects/pickup_fire_sword", Thumbnail = "animatedsprites/sor4/weapons/sword_red/red_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [59] = new Item { Name = "Sword (poison)", Path = "objects/pickup_poison_sword", Thumbnail = "animatedsprites/sor4/weapons/sword_green/green_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [60] = new Item { Name = "Sword (thunder)", Path = "objects/pickup_thunder_sword", Thumbnail = "animatedsprites/sor4/weapons/sword_blue/blue_sword_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [61] = new Item { Name = "Swordfish", Path = "objects/pickup_espadon", Thumbnail = "animatedsprites/sor4/weapons/espadon/espadon_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [62] = new Item { Name = "Taser", Path = "objects/pickup_taser", Thumbnail = "animatedsprites/sor4/weapons/taser", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [63] = new Item { Name = "Tonfa", Path = "objects/pickup_tonfa", Thumbnail = "animatedsprites/sor4/weapons/matraque", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [64] = new Item { Name = "Trident", Path = "objects/pickup_trident", Thumbnail = "animatedsprites/sor4/weapons/trident/trident_1_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [65] = new Item { Name = "Tuna", Path = "objects/pickup_tuna", Thumbnail = "animatedsprites/sor4/weapons/tuna/tuna_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [66] = new Item { Name = "Umbrella", Path = "objects/pickup_umbrella", Thumbnail = "animatedsprites/sor4/weapons/parapluie/papapluie_ground", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [67] = new Item { Name = "Vial (electric)", Path = "objects/pickup_blue_vial", Thumbnail = "animatedsprites/sor4/weapons/fiole/fiole_electrique", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [68] = new Item { Name = "Vial (fire)", Path = "objects/pickup_red_vial", Thumbnail = "animatedsprites/sor4/weapons/fiole/fiole_feux", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [69] = new Item { Name = "Vial (poison)", Path = "objects/pickup_green_vial", Thumbnail = "animatedsprites/sor4/weapons/fiole/fiole_poison", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [70] = new Item { Name = "Zan Ball", Path = "objects/pickup_zan_ball", Thumbnail = "animatedsprites/sor3/playables/sprsor3zan/zan81", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [71] = new Item { Name = "Zan Ball (lesser)", Path = "objects/pickup_zan_ball_lesser", Thumbnail = "animatedsprites/sor3/playables/sprsor3zan/zan81", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [72] = new Item { Name = "--- RETRO  ---", Path = "n/a", Thumbnail = "", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [73] = new Item { Name = "Boomerang SOR1", Path = "objects/pickup_sor1boomrang", Thumbnail = "animatedsprites/sor1/enemies/sprsor1antonio/antonio021", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [74] = new Item { Name = "Katana SOR2", Path = "objects/pickup_sor2_katana", Thumbnail = "animatedsprites/sor2/objects/sor2_katana", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [75] = new Item { Name = "Knife SOR2", Path = "objects/pickup_sor2knife", Thumbnail = "animatedsprites/sor2/enemies/sprsor2jack/jack035", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [76] = new Item { Name = "Lead Pipe SOR2", Path = "objects/pickup_sor2_lead_pipe", Thumbnail = "animatedsprites/sor2/objects/sor2_pipe", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [77] = new Item { Name = "Lead Pipe SOR2 1HP", Path = "objects/pickup_sor2_lead_pipe_1hp", Thumbnail = "animatedsprites/sor2/objects/sor2_pipe", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [78] = new Item { Name = "Lead Pipe SOR2 Start", Path = "objects/pickup_sor2_lead_pipe_start", Thumbnail = "animatedsprites/sor2/objects/sor2_pipe", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [79] = new Item { Name = "Shuriken SOR2", Path = "objects/pickup_sor2_shuriken", Thumbnail = "animatedsprites/sor2/objects/sor2_shuriken01", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [80] = new Item { Name = "Shuriken SOR3", Path = "objects/pickup_sor3_shuriken", Thumbnail = "animatedsprites/sor3/enemies/sprsor3yamato/yamoto045", IsPickup = false, IsWeapon = true, IsGolden = false, IsExcluded = false },
            [81] = new Item { Name = "--- MISCELLANEOUS  ---", Path = "n/a", Thumbnail = "", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [82] = new Item { Name = "Training Spawner 1", Path = "objects/pickup_trainingspawner1", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [83] = new Item { Name = "Training Spawner 2", Path = "objects/pickup_trainingspawner2", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [84] = new Item { Name = "Training Spawner 3", Path = "objects/pickup_trainingspawner3", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [85] = new Item { Name = "Training Spawner 4", Path = "objects/pickup_trainingspawner4", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [86] = new Item { Name = "Training Spawner 5", Path = "objects/pickup_trainingspawner5", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [87] = new Item { Name = "Training Spawner 6", Path = "objects/pickup_trainingspawner6", Thumbnail = "animatedsprites/sor4/pickups/spawner1_ground", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
            [88] = new Item { Name = "Walkie Talkie", Path = "objects/pickup_talkie_walkie", Thumbnail = "animatedsprites/sor4/weapons/talkie_military", IsPickup = false, IsWeapon = false, IsGolden = false, IsExcluded = true },
        };
        public static Dictionary<int, Destroyable> destroyableDictionary = new()
        {
            [0] = new Destroyable { Name = "--- BREAKABLES ---", Path = "n/a", Thumbnail = "", IsBreakable = false, IsDestructive = false, IsUnbreakable = false, IsExcluded = true },
            [1] = new Destroyable { Name = "Arcade Machine (Bar)", Path = "objects/object_arcade_bar", Thumbnail = "animatedsprites/sor4/destroyables/sprarcade/arcade_bar/arcade_bar_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [2] = new Destroyable { Name = "Arcade Machine (Gallery)", Path = "objects/object_arcade_gallery", Thumbnail = "animatedsprites/sor4/destroyables/sprarcade/arcade_gallery/arcade_gallery_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [3] = new Destroyable { Name = "Arcade Machine (Pier)", Path = "objects/object_arcade", Thumbnail = "animatedsprites/sor4/destroyables/sprarcade/arcade_iso/arcade_pier_step1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [4] = new Destroyable { Name = "Arcade Machine (Prison)", Path = "objects/object_arcade_prison", Thumbnail = "animatedsprites/sor4/destroyables/sprarcade/arcade_pier/arcade_iso_step1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [5] = new Destroyable { Name = "Armor Stand", Path = "objects/object_armor", Thumbnail = "animatedsprites/sor4/destroyables/sprarmor/armor_normal_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [6] = new Destroyable { Name = "Armor Stand (Morning Star)", Path = "objects/object_armor_flail", Thumbnail = "animatedsprites/sor4/destroyables/sprarmor/armor_fleau_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [7] = new Destroyable { Name = "Armor Stand (sword)", Path = "objects/object_armor_sword", Thumbnail = "animatedsprites/sor4/destroyables/sprarmor/armor_sword_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [8] = new Destroyable { Name = "Bar Chair", Path = "objects/object_bar_chair", Thumbnail = "animatedsprites/sor4/destroyables/sprchaisebiker/chaise_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [9] = new Destroyable { Name = "Bar Chair (Right)", Path = "objects/object_bar_chair_right", Thumbnail = "animatedsprites/sor4/destroyables/sprchaisebiker/chaise_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [10] = new Destroyable { Name = "Bar Table", Path = "objects/object_bar_table", Thumbnail = "animatedsprites/sor4/destroyables/sprtablebiker/table_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [11] = new Destroyable { Name = "Barrel", Path = "objects/object_barrel_blue", Thumbnail = "animatedsprites/sor4/destroyables/sprbarrel_blue/bidon_bleu_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [12] = new Destroyable { Name = "Big Crate", Path = "objects/object_big_crate", Thumbnail = "animatedsprites/sor4/destroyables/sprbigcrate/caisse_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [13] = new Destroyable { Name = "Bike (Barbon)", Path = "objects/object_moto_barbon", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_barbon/ol_moto_barbon", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [14] = new Destroyable { Name = "Bike 1", Path = "objects/object_moto_1", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_1/moto_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [15] = new Destroyable { Name = "Bike 2", Path = "objects/object_moto_2", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_2/moto_2", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [16] = new Destroyable { Name = "Bike 3", Path = "objects/object_moto_3", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_3/moto_3", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [17] = new Destroyable { Name = "Bike 4", Path = "objects/object_moto_4", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_4/moto_4", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [18] = new Destroyable { Name = "Bike 5", Path = "objects/object_moto_5", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_5/moto_5", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [19] = new Destroyable { Name = "Bike 6", Path = "objects/object_moto_6", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_6/moto_6", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [20] = new Destroyable { Name = "Bike 7", Path = "objects/object_moto_7", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_7/moto_7", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [21] = new Destroyable { Name = "Bike 8", Path = "objects/object_moto_8", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_8/moto_8", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [22] = new Destroyable { Name = "Bike 9", Path = "objects/object_moto_9", Thumbnail = "animatedsprites/sor4/destroyables/sprmotos/moto_9/moto_9", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [23] = new Destroyable { Name = "Chair", Path = "objects/object_chair", Thumbnail = "animatedsprites/sor4/destroyables/sprchair/chaise_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [24] = new Destroyable { Name = "Chandelier", Path = "objects/object_chandelier", Thumbnail = "animatedsprites/sor4/destroyables/sprstg12_chandelier/chandelier", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [25] = new Destroyable { Name = "Command Chair (Nora)", Path = "objects/object_command_chair", Thumbnail = "animatedsprites/sor4/destroyables/sprcommandchair/siege_capitaine_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [26] = new Destroyable { Name = "Commissioner Desk", Path = "objects/object_bureau", Thumbnail = "animatedsprites/sor4/destroyables/sprbureau/bureau_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [27] = new Destroyable { Name = "Commissioner Office Door", Path = "objects/object_door_police_station", Thumbnail = "animatedsprites/sor4/destroyables/sprdoorpolicestation/posing_porte_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [28] = new Destroyable { Name = "Crashed Car", Path = "objects/object_crashing_car", Thumbnail = "animatedsprites/sor4/destroyables/sprcar/posing_1/car_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [29] = new Destroyable { Name = "Elevator Glass (left)", Path = "objects/object_elevator_side2", Thumbnail = "animatedsprites/sor4/destroyables/sprelevatorside/vitre_left/step1", IsBreakable = false, IsDestructive = false, IsUnbreakable = true, IsExcluded = true },
            [30] = new Destroyable { Name = "Elevator Glass (right)", Path = "objects/object_elevator_side", Thumbnail = "animatedsprites/sor4/destroyables/sprelevatorside/vitre_right/step1", IsBreakable = false, IsDestructive = false, IsUnbreakable = true, IsExcluded = true },
            [31] = new Destroyable { Name = "Garbage Bin", Path = "objects/object_garbage_standart", Thumbnail = "animatedsprites/sor4/destroyables/sprclassictrash/classic_trash_destroy", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [32] = new Destroyable { Name = "Garbage Can", Path = "objects/object_garbage_can", Thumbnail = "animatedsprites/sor4/destroyables/sprtrash/trash", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [33] = new Destroyable { Name = "Gladiator Punch Ball", Path = "objects/survival/object_gladiator_punch_ball", Thumbnail = "animatedsprites/sor4/destroyables/gladiator_punchball/gladiator_punchball01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [34] = new Destroyable { Name = "Golden Chicken Stand", Path = "objects/object_chicken_gold", Thumbnail = "animatedsprites/sor4/destroyables/sprgoldenchicken/poulet_or_object", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [35] = new Destroyable { Name = "Invisible Box", Path = "objects/object_invisible", Thumbnail = "", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [36] = new Destroyable { Name = "Jungle Vase", Path = "objects/survival/object_jungle_vase", Thumbnail = "animatedsprites/sor4/destroyables/jungle_vase/jungle_vase01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [37] = new Destroyable { Name = "Jungle Vine", Path = "objects/survival/object_jungle_lianne", Thumbnail = "animatedsprites/sor4/destroyables/jungle_rock/sprstg12_lianne00018", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [38] = new Destroyable { Name = "Metro Door", Path = "objects/object_door_metro", Thumbnail = "animatedsprites/sor4/destroyables/sprdoormetro/porte_metro_diagonal_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [39] = new Destroyable { Name = "Military Crate", Path = "objects/survival/object_military_case", Thumbnail = "animatedsprites/sor4/destroyables/military_case/military_case_01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [40] = new Destroyable { Name = "Mop Bucket", Path = "objects/object_bucket", Thumbnail = "animatedsprites/sor4/destroyables/sprbucket/bucket_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [41] = new Destroyable { Name = "Museum Chair", Path = "objects/object_museum_chair", Thumbnail = "animatedsprites/sor4/destroyables/sprgallerychair/chaise_gallerie_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [42] = new Destroyable { Name = "Museum Chair (right)", Path = "objects/object_museum_chair_right", Thumbnail = "animatedsprites/sor4/destroyables/sprgallerychair/chaise_gallerie_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [43] = new Destroyable { Name = "Phone Booth", Path = "objects/object_phone_booth", Thumbnail = "animatedsprites/sor4/destroyables/sprtelephone/telephone", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [44] = new Destroyable { Name = "Pillory", Path = "objects/object_torture", Thumbnail = "animatedsprites/sor4/destroyables/sprtorture/torture_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [45] = new Destroyable { Name = "Plane Seat 1", Path = "objects/object_siege_avion1", Thumbnail = "animatedsprites/sor4/destroyables/sprsiegeavion/avion_siege_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [46] = new Destroyable { Name = "Plane Seat 2", Path = "objects/object_siege_avion2", Thumbnail = "animatedsprites/sor4/destroyables/sprsiegeavion/siege_avion_back_posing_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [47] = new Destroyable { Name = "Plane Seat 3", Path = "objects/object_siege_avion3", Thumbnail = "animatedsprites/sor4/destroyables/sprsiegeavion/siege_avion_back_posing_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [48] = new Destroyable { Name = "Plane Seat 4", Path = "objects/object_siege_avion4", Thumbnail = "animatedsprites/sor4/destroyables/sprsiegeavion/siege_avion_back_posing_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [49] = new Destroyable { Name = "Pool Table", Path = "objects/object_pool_table", Thumbnail = "animatedsprites/sor4/destroyables/sprbillard/billard_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [50] = new Destroyable { Name = "Prison Door (breakable)", Path = "objects/object_door_prison_breakable", Thumbnail = "animatedsprites/sor4/destroyables/sprdoorprison/porte_breakable_cellule_1/porte_cellule_1_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [51] = new Destroyable { Name = "Red Barrel", Path = "objects/object_barrel_red", Thumbnail = "animatedsprites/sor4/destroyables/sprbarrel_red/bidon_rouge_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [52] = new Destroyable { Name = "Road Sign", Path = "objects/object_roadsing", Thumbnail = "animatedsprites/sor4/weapons/road_sign/road_sign_2", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [53] = new Destroyable { Name = "Ship Crate", Path = "objects/object_big_crate_bateau", Thumbnail = "animatedsprites/sor4/destroyables/sprbigcrate_bateau/caisse_bateau_profil_step1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [54] = new Destroyable { Name = "Sink", Path = "objects/object_sink", Thumbnail = "animatedsprites/sor4/destroyables/sprsink/fontaine_pos1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [55] = new Destroyable { Name = "Standing Chandelier", Path = "objects/object_chandelier_ground", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_1/png/chandelier_ul1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [56] = new Destroyable { Name = "Street Food Cart", Path = "objects/object_tuctuc", Thumbnail = "animatedsprites/sor4/destroyables/sprtuctuc/tuctuc_pos1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [57] = new Destroyable { Name = "Table", Path = "objects/object_table", Thumbnail = "animatedsprites/sor4/destroyables/sprtable/table_champagne_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [58] = new Destroyable { Name = "Tactical Box", Path = "objects/object_tactical_box", Thumbnail = "animatedsprites/sor4/destroyables/sprtacticalbox/tactic_box_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [59] = new Destroyable { Name = "Train Door (Diva)", Path = "objects/object_door_diva", Thumbnail = "animatedsprites/sor4/destroyables/sprdoordiva/porte_wagon_0", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [60] = new Destroyable { Name = "Vase", Path = "objects/object_vase", Thumbnail = "animatedsprites/sor4/destroyables/sprvase/vase_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [61] = new Destroyable { Name = "Vending Machine", Path = "objects/object_distributeur", Thumbnail = "animatedsprites/sor4/destroyables/sprdistributeur/distributeur_posing1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [62] = new Destroyable { Name = "Volcanic Chest", Path = "objects/survival/object_volcano_chest", Thumbnail = "animatedsprites/sor4/destroyables/volcano_chest/volcano_chest01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [63] = new Destroyable { Name = "Water Dispenser", Path = "objects/object_water_distrib", Thumbnail = "animatedsprites/sor4/destroyables/spwaterdistrib/water_distrib_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [64] = new Destroyable { Name = "Wet Floor Sign", Path = "objects/object_wet_floor", Thumbnail = "animatedsprites/sor4/destroyables/sprwetfloorsign/wetfloor_sign_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [65] = new Destroyable { Name = "Wooden Training Dummy", Path = "objects/object_poutre_temple", Thumbnail = "animatedsprites/sor4/destroyables/sprpoutre_temple/poutre_posing_1", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [66] = new Destroyable { Name = "--- RETRO ---", Path = "n/a", Thumbnail = "", IsBreakable = false, IsDestructive = false, IsUnbreakable = false, IsExcluded = true },
            [67] = new Destroyable { Name = "Alien Egg (Retro)", Path = "objects/object_sor2_alien_egg", Thumbnail = "animatedsprites/sor2/objects/sprsor2alienegg/sor2alienegg01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [68] = new Destroyable { Name = "Barrel (Retro)", Path = "objects/object_sor2_barrel", Thumbnail = "animatedsprites/sor2/objects/sprsor2barrel/sor2barrel01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [69] = new Destroyable { Name = "Barrier (Retro)", Path = "objects/object_sor2_barrier", Thumbnail = "animatedsprites/sor2/objects/sprsor2barrier/sor2barrier01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [70] = new Destroyable { Name = "Chair (Retro)", Path = "objects/object_sor2_chair", Thumbnail = "animatedsprites/sor2/objects/sprsor2chair/001", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [71] = new Destroyable { Name = "Crate (Retro)", Path = "objects/object_sor2_crate", Thumbnail = "animatedsprites/sor2/objects/sprsor2crate/sor2crate01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [72] = new Destroyable { Name = "Garbage Can (Retro)", Path = "objects/object_sor2_steel_trash", Thumbnail = "animatedsprites/sor2/objects/steeltrash01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [73] = new Destroyable { Name = "Menu Board (Retro)", Path = "objects/object_sor2_menus", Thumbnail = "animatedsprites/sor2/objects/sprsor2menus/001", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [74] = new Destroyable { Name = "Metal Crate 1 (Retro)", Path = "objects/object_sor2_metal_crate_01", Thumbnail = "animatedsprites/sor2/objects/sprsor2metalcrate01/sor2metalcrate01_01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [75] = new Destroyable { Name = "Metal Crate 2 (Retro)", Path = "objects/object_sor2_metal_crate_02", Thumbnail = "animatedsprites/sor2/objects/sprsor2metalcrate02/sor2metalcrate02_01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [76] = new Destroyable { Name = "Sandbags (Retro)", Path = "objects/object_sor2_bags", Thumbnail = "animatedsprites/sor2/objects/sprsor2bags/sor2bags01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [77] = new Destroyable { Name = "Table (Retro)", Path = "objects/object_sor2_table", Thumbnail = "animatedsprites/sor2/objects/sprsor2table/001", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [78] = new Destroyable { Name = "TV (Retro)", Path = "objects/object_bonus_tv", Thumbnail = "animatedsprites/sor4/destroyables/sprbonustv/bonustv", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [79] = new Destroyable { Name = "Vase (Retro)", Path = "objects/object_sor2_vase", Thumbnail = "animatedsprites/sor2/objects/sprsor2vase/sor2vase01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [80] = new Destroyable { Name = "Wooden Crate (Retro)", Path = "objects/object_sor2_metal_urn", Thumbnail = "animatedsprites/sor2/objects/sprsor2crate/sor2crate01", IsBreakable = true, IsDestructive = false, IsUnbreakable = false, IsExcluded = false },
            [81] = new Destroyable { Name = "--- DESTRUCTIVE ---", Path = "n/a", Thumbnail = "", IsBreakable = false, IsDestructive = false, IsUnbreakable = false, IsExcluded = true },
            [82] = new Destroyable { Name = "Electric Barrel", Path = "objects/object_barrel_electricity", Thumbnail = "animatedsprites/sor4/destroyables/sprbarrel_electricity/bidon_electric_1", IsBreakable = true, IsDestructive = true, IsUnbreakable = false, IsExcluded = false },
            [83] = new Destroyable { Name = "Explosive Barrel", Path = "objects/object_barrel_explosion", Thumbnail = "animatedsprites/sor4/destroyables/sprbarrel_fire/bidon_feux_step1", IsBreakable = true, IsDestructive = true, IsUnbreakable = false, IsExcluded = false },
            [84] = new Destroyable { Name = "Factory Bomb", Path = "objects/survival/object_factory_bomb", Thumbnail = "animatedsprites/sor4/destroyables/factory_bomb/factory_bomb01", IsBreakable = true, IsDestructive = true, IsUnbreakable = false, IsExcluded = false },
            [85] = new Destroyable { Name = "Toxic Barrel", Path = "objects/object_barrel_toxic", Thumbnail = "animatedsprites/sor4/destroyables/sprbarrel_toxic/bidon_toxic_step1", IsBreakable = true, IsDestructive = true, IsUnbreakable = false, IsExcluded = false },
        };
        public static Dictionary<int, Level> levelDictionary = new()
        {
            [0] = new Level { Name = "--- STORY ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [1] = new Level { Name = "Stage 1-1", Path = "levels/main_campaign/lvl_stage1_1", Thumbnail = "decors/main_campaign/stage_1/lvl_1/png/ul15_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [2] = new Level { Name = "Stage 1-2", Path = "levels/main_campaign/lvl_stage1_2", Thumbnail = "decors/main_campaign/stage_1/lvl_2/png_color/wagon_ul1_ol2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [3] = new Level { Name = "Stage 1-3", Path = "levels/main_campaign/lvl_stage1_3", Thumbnail = "decors/main_campaign/stage_1/lvl_3/png/ul12_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [4] = new Level { Name = "Stage 2-1", Path = "levels/main_campaign/lvl_stage2_1", Thumbnail = "decors/main_campaign/stage_2/lvl_1/png/ul1_v23_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [5] = new Level { Name = "Stage 2-2", Path = "levels/main_campaign/lvl_stage2_2", Thumbnail = "decors/main_campaign/stage_2/lvl_2/color/ul_1_sol_mur8_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [6] = new Level { Name = "Stage 2-3", Path = "levels/main_campaign/lvl_stage2_3", Thumbnail = "decors/main_campaign/stage_2/lvl_3/png/sol_mur_ul0_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [7] = new Level { Name = "Stage 3-1A", Path = "levels/main_campaign/lvl_stage3_1a", Thumbnail = "decors/main_campaign/stage_3/lvl_1/part_1/png_part_1/ul1_sol7_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [8] = new Level { Name = "Stage 3-1B", Path = "levels/main_campaign/lvl_stage3_1b", Thumbnail = "decors/main_campaign/stage_3/lvl_1/part_2/png_part_2/ul1_sol_mur1_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [9] = new Level { Name = "Stage 3-1C", Path = "levels/main_campaign/lvl_stage3_1c", Thumbnail = "decors/main_campaign/stage_3/lvl_1/part_3/png_part_3/ul2_mur2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [10] = new Level { Name = "Stage 3-2", Path = "levels/main_campaign/lvl_stage3_2", Thumbnail = "decors/main_campaign/stage_3/lvl_2/png/ul1_sol_mur2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [11] = new Level { Name = "Stage 4-1", Path = "levels/main_campaign/lvl_stage4_1", Thumbnail = "decors/main_campaign/stage_4/lvl_1/png/ul1_pier_trou/pier_ul1_trou_v14_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [12] = new Level { Name = "Stage 4-2", Path = "levels/main_campaign/lvl_stage4_2", Thumbnail = "decors/main_campaign/stage_4/lvl_2/png/ul1/ul1_sol6_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [13] = new Level { Name = "Stage 5-1", Path = "levels/main_campaign/lvl_stage5_1", Thumbnail = "decors/main_campaign/stage_5/lvl_1/png/ul1_sol_mur_g5_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [14] = new Level { Name = "Stage 5-2", Path = "levels/main_campaign/lvl_stage5_2", Thumbnail = "decors/main_campaign/stage_5/lvl_2/png/ul1_sol_mur_bar_v23_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [15] = new Level { Name = "Stage 5-3", Path = "levels/main_campaign/lvl_stage5_3", Thumbnail = "decors/main_campaign/stage_5/lvl_3/png/ul1_mur_sol_porte0_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [16] = new Level { Name = "Stage 6-1", Path = "levels/main_campaign/lvl_stage6_1", Thumbnail = "decors/main_campaign/stage_6/lvl_1/ul_temple/ul1_v312_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [17] = new Level { Name = "Stage 6-2A", Path = "levels/main_campaign/lvl_stage6_2a", Thumbnail = "decors/main_campaign/stage_6/lvl_2/png/test/ul_1/ul1_black_temple2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [18] = new Level { Name = "Stage 6-2B", Path = "levels/main_campaign/lvl_stage6_2b", Thumbnail = "decors/main_campaign/stage_6/lvl_2/png/test/ul_1/ul1_red_temple2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [19] = new Level { Name = "Stage 6-2C", Path = "levels/main_campaign/lvl_stage6_2c", Thumbnail = "decors/main_campaign/stage_6/lvl_2/png/test/arene/arene_ul10_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [20] = new Level { Name = "Stage 6-3", Path = "levels/main_campaign/lvl_stage6_3", Thumbnail = "decors/main_campaign/stage_6/lvl_3/png/ul1_temple_23_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [21] = new Level { Name = "Stage 7-1", Path = "levels/main_campaign/lvl_stage7_1", Thumbnail = "decors/main_campaign/stage_7/lvl_1/png/wagon0_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [22] = new Level { Name = "Stage 8-1", Path = "levels/main_campaign/lvl_stage8_1", Thumbnail = "decors/main_campaign/stage_8/lvl_1/png/break/break_love", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [23] = new Level { Name = "Stage 8-2", Path = "levels/main_campaign/lvl_stage8_2", Thumbnail = "decors/main_campaign/stage_8/lvl_2/png/ul1_mur2_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [24] = new Level { Name = "Stage 9-1", Path = "levels/main_campaign/lvl_stage9_1", Thumbnail = "decors/main_campaign/stage_9/lvl_1/png/part_a/ul1_part_a0_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [25] = new Level { Name = "Stage 9-2", Path = "levels/main_campaign/lvl_stage9_2", Thumbnail = "decors/main_campaign/stage_9/lvl_2/ascensseur/cache_sol_ascensseur1_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [26] = new Level { Name = "Stage 9-3", Path = "levels/main_campaign/lvl_stage9_3", Thumbnail = "decors/main_campaign/stage_9/lvl_3/png/ul1_arena1_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [27] = new Level { Name = "Stage 10-1A", Path = "levels/main_campaign/lvl_stage10_1a", Thumbnail = "decors/main_campaign/stage_10/lvl_1/a_png/ul13_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [28] = new Level { Name = "Stage 10-1B", Path = "levels/main_campaign/lvl_stage10_1b", Thumbnail = "decors/main_campaign/stage_10/lvl_1/b_png/ul14_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [29] = new Level { Name = "Stage 10-1C", Path = "levels/main_campaign/lvl_stage10_1c", Thumbnail = "decors/main_campaign/stage_10/lvl_1/c_png/ul10_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [30] = new Level { Name = "Stage 10-3", Path = "levels/main_campaign/lvl_stage10_3", Thumbnail = "decors/main_campaign/stage_10/lvl_3/png/test/ul1_scene2_1", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [31] = new Level { Name = "Stage 11-1", Path = "levels/main_campaign/lvl_stage11_1", Thumbnail = "decors/main_campaign/stage_11/lvl_1/png/ascensseur_v21_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [32] = new Level { Name = "Stage 11-2A", Path = "levels/main_campaign/lvl_stage11_2a", Thumbnail = "decors/main_campaign/stage_11/lvl_2/png_a/ul1_piste/ul2_avion2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [33] = new Level { Name = "Stage 11-2B", Path = "levels/main_campaign/lvl_stage11_2b", Thumbnail = "decors/main_campaign/stage_11/lvl_2/png_b/png_def/ul1_mur_sol2_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [34] = new Level { Name = "Stage 11-3", Path = "levels/main_campaign/lvl_stage11_3", Thumbnail = "decors/main_campaign/stage_11/lvl_3/png/ul11_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [35] = new Level { Name = "Stage 12-1", Path = "levels/main_campaign/lvl_stage12_1", Thumbnail = "decors/main_campaign/stage_12/lvl_1/png/cache_avion1_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [36] = new Level { Name = "Stage 12-2A", Path = "levels/main_campaign/lvl_stage12_2a", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_1/png/ul1_mur_sol4_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [37] = new Level { Name = "Stage 12-2B", Path = "levels/main_campaign/lvl_stage12_2b", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_2/png/ul1_v10_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [38] = new Level { Name = "Stage 12-2C", Path = "levels/main_campaign/lvl_stage12_2c", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_3/png/ul1_sol1_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [39] = new Level { Name = "Stage 12-3", Path = "levels/main_campaign/lvl_stage12_3", Thumbnail = "decors/main_campaign/stage_12/lvl_3/png/ul1_sol3_0", IsStory = true, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [40] = new Level { Name = "--- CHALLENGE ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [41] = new Level { Name = "Bonus Stage 1", Path = "levels/main_campaign/lvl_bonus1", Thumbnail = "decors/main_campaign/bonus_1/png/sor2jackstreet_ul1", IsStory = false, IsChallenge = true, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [42] = new Level { Name = "Bonus Stage 2", Path = "levels/main_campaign/lvl_bonus2", Thumbnail = "decors/challenges/sor2_alien/sor2alien_ul1", IsStory = false, IsChallenge = true, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [43] = new Level { Name = "Bonus Stage 3", Path = "levels/main_campaign/lvl_bonus3", Thumbnail = "decors/challenges/sor2_arena/sor2arena_ul1", IsStory = false, IsChallenge = true, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [44] = new Level { Name = "Bonus Stage 4", Path = "levels/main_campaign/lvl_bonus4", Thumbnail = "decors/challenges/sor2_throne/sor2throne_ul1", IsStory = false, IsChallenge = true, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [45] = new Level { Name = "--- BOSS RUSH ETC ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [46] = new Level { Name = "Boss Rush", Path = "levels/challenges/lvl_challenge_01_bossrun_v3", Thumbnail = "decors/main_campaign/stage_12/lvl_3/png/ul1_sol2_1", IsStory = false, IsChallenge = false, IsBossRush = true, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = false },
            [47] = new Level { Name = "Test Flo Showroom 1", Path = "levels/tests/lvl_test_flo_showroom_qa1", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [48] = new Level { Name = "Test Flo Showroom 2", Path = "levels/tests/lvl_test_flo_showroom_qa2", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [49] = new Level { Name = "Weapon Showroom", Path = "levels/showrooms/lvl_showroom_weapons", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [50] = new Level { Name = "--- BATTLE ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [51] = new Level { Name = "Battle - Streets", Path = "levels/versus/lvl_versus_streets", Thumbnail = "decors/main_campaign/stage_1/lvl_1/png/ul115_2", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [52] = new Level { Name = "Battle - Chinatown", Path = "levels/versus/lvl_versus_chinatown", Thumbnail = "decors/main_campaign/stage_6/lvl_1/ul_temple/ul1_v34_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [53] = new Level { Name = "Battle - Castle", Path = "levels/versus/lvl_versus_castle", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_2/png/ul1_v10_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [54] = new Level { Name = "Battle - Engine Room", Path = "levels/versus/lvl_versus_engine_room", Thumbnail = "decors/main_campaign/stage_12/lvl_2/part_1/png/ul1_mur_sol6_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [55] = new Level { Name = "Battle - Prison", Path = "levels/versus/lvl_versus_prison", Thumbnail = "decors/main_campaign/stage_2/lvl_1/png/ul1_v26_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [56] = new Level { Name = "Battle - Elevator", Path = "levels/versus/lvl_versus_elevator", Thumbnail = "decors/main_campaign/stage_9/lvl_2/ascensseur/cache_sol_ascensseur1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [57] = new Level { Name = "Battle - Construction Site", Path = "levels/versus/lvl_versus_construction_site", Thumbnail = "decors/main_campaign/stage_10/lvl_1/c_png/ul12_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [58] = new Level { Name = "Battle - Train", Path = "levels/versus/lvl_versus_train", Thumbnail = "decors/main_campaign/stage_7/lvl_1/png/wagon0_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = true, IsTraining = false, IsSurvival = false, IsExcluded = true },
            [59] = new Level { Name = "--- TRAINING ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [60] = new Level { Name = "Free Training", Path = "levels/training/lvl_free_training", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [61] = new Level { Name = "Lesson 01 - Basic Moves", Path = "levels/training/lvl_training_01", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [62] = new Level { Name = "Lesson 02 - Grab Moves", Path = "levels/training/lvl_training_02", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [63] = new Level { Name = "Lesson 03 - Special Moves", Path = "levels/training/lvl_training_03", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [64] = new Level { Name = "Lesson 04 - Weapons & Pickups", Path = "levels/training/lvl_training_04", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [65] = new Level { Name = "Lesson 05 - Offensive Tricks 1", Path = "levels/training/lvl_training_05", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [66] = new Level { Name = "Lesson 06 - Offensive Tricks 2", Path = "levels/training/lvl_training_06", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [67] = new Level { Name = "Lesson 07 - Defensive Tricks 1", Path = "levels/training/lvl_training_07", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [68] = new Level { Name = "Lesson 08 - Defensive Tricks 2", Path = "levels/training/lvl_training_08", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [69] = new Level { Name = "Lesson 09 - Defensive Tricks 3", Path = "levels/training/lvl_training_09", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [70] = new Level { Name = "Lesson 10 - Axel's Tricks", Path = "levels/training/lvl_training_10", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [71] = new Level { Name = "Lesson 11 - Blaze's Tricks", Path = "levels/training/lvl_training_11", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [72] = new Level { Name = "Lesson 12 - Cherry's Tricks", Path = "levels/training/lvl_training_12", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [73] = new Level { Name = "Lesson 13 - Floyd's Tricks", Path = "levels/training/lvl_training_13", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [74] = new Level { Name = "Lesson 14 - Adam's Tricks", Path = "levels/training/lvl_training_14", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [75] = new Level { Name = "Lesson 15 - Max's Tricks", Path = "levels/training/lvl_training_15", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [76] = new Level { Name = "Lesson 16 - Shiva's Tricks", Path = "levels/training/lvl_training_16", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [77] = new Level { Name = "Lesson 17 - Estel's Tricks", Path = "levels/training/lvl_training_17", Thumbnail = "decors/free_training/png/cache_reflect1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [78] = new Level { Name = "--- SURVIVAL ---", Path = "n/a", Thumbnail = "", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = true, IsSurvival = false, IsExcluded = true },
            [79] = new Level { Name = "Survival - Warm Up", Path = "levels/survival/lvl_biome_start", Thumbnail = "decors/free_training/png/ul1_sol0_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [80] = new Level { Name = "Survival - Aircraft Carrier", Path = "levels/survival/lvl_biome_4_a", Thumbnail = "decors/survival/biome_4/png/ul1_plateform1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [81] = new Level { Name = "Survival - Factory", Path = "levels/survival/lvl_biome_1_a", Thumbnail = "decors/survival/biome_1/png/platefrome1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [82] = new Level { Name = "Survival - Gladiator (blue)", Path = "levels/survival/lvl_biome_3_a", Thumbnail = "decors/survival/biome_3/png/a/ul1_plateform_a1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [83] = new Level { Name = "Survival - Gladiator (green)", Path = "levels/survival/lvl_biome_3_b", Thumbnail = "decors/survival/biome_3/png/a/b/ul1_irish0_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [84] = new Level { Name = "Survival - Gladiator (red)", Path = "levels/survival/lvl_biome_3_c", Thumbnail = "decors/survival/biome_3/png/a/c/ul1_tiger1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [85] = new Level { Name = "Survival - Temple", Path = "levels/survival/lvl_biome_5_a", Thumbnail = "decors/survival/biome_5/png/png/ul6_fontaine", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [86] = new Level { Name = "Survival - Volcano", Path = "levels/survival/lvl_biome_2_a", Thumbnail = "decors/survival/biome_2/png/ul1_sol1_0", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [87] = new Level { Name = "Survival - SOR2 Alien", Path = "levels/survival/lvl_biome_retro_h", Thumbnail = "decors/challenges/sor2_alien/sor2alien_ul1", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [88] = new Level { Name = "Survival - SOR2 Bar", Path = "levels/survival/lvl_biome_retro_g", Thumbnail = "decors/challenges/sor2_bar/sor2bar_ul1", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [89] = new Level { Name = "Survival - SOR2 Barbon St.", Path = "levels/survival/lvl_biome_retro_a", Thumbnail = "decors/challenges/sor2_barbonstreet/sor2barbon_ul1", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [90] = new Level { Name = "Survival - SOR2 Boat", Path = "levels/survival/lvl_biome_retro_f", Thumbnail = "decors/challenges/sor2_boat/boat_ul1", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [91] = new Level { Name = "Survival - SOR3 Bar", Path = "levels/survival/lvl_biome_retro_sor3bar", Thumbnail = "decors/survival/retro/sor3/bar/sor3bar_bg1", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [92] = new Level { Name = "Survival - SOR3 Lab", Path = "levels/survival/lvl_biome_retro_sor3lab", Thumbnail = "decors/survival/retro/sor3/lab/sor3lab_bg01", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [93] = new Level { Name = "Survival - SOR3 Roof", Path = "levels/survival/lvl_biome_retro_sor3roof", Thumbnail = "decors/survival/retro/sor3/roof/sor3roof_bg02", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
            [94] = new Level { Name = "Survival - SOR3 Temple", Path = "levels/survival/lvl_biome_retro_sor3temple", Thumbnail = "decors/survival/retro/sor3/temple/sor3temple_bg02", IsStory = false, IsChallenge = false, IsBossRush = false, IsBattle = false, IsTraining = false, IsSurvival = true, IsExcluded = false },
        };

        public Dictionary<string, int> characterPathToIndex = new();
        public Dictionary<string, int> itemPathToIndex = new();
        public Dictionary<string, int> destroyablePathToIndex = new();
        public Dictionary<string, int> levelPathToIndex = new();

        public CharacterClass characterClassCopy;
        public Dictionary<string, CharacterClass> characterCollection = new();
        public Dictionary<string, Dictionary<string, string>> nameReference = new();
        public Dictionary<string, string> originalNameReference = new();

        // internal variables
        public Dictionary<int, int> changeList = new();
        public Dictionary<int, bool> changeTo = new();
        public Dictionary<int, int> itemChangeList = new();
        public Dictionary<int, bool> itemChangeTo = new();
        public Dictionary<int, int> destroyableChangeList = new();
        public Dictionary<int, bool> destroyableChangeTo = new();
        public Dictionary<int, int> levelChangeList = new();
        public Dictionary<int, bool> levelChangeTo = new();

        public Dictionary<int, CharacterClass> characterCustomizationInMemory = new();
        public Dictionary<int, CharacterClass> characterCustomizationQueue = new();
        public Dictionary<string, string> customCharacterNames = new();
        public GameplayConfigDataClass originalGCD = new();

        // images
        public readonly Dictionary<string, FileStream> DataFiles = new();


        public int gameVer = 713648;
        public string backupLogicState = "none";
        public string gameDir;
        public string bigfilePath;
        public string backup_filename;
        public string gameVerString;

        public DataTable swapTable = new();
        public DataTable itemSwapTable = new();
        public DataTable destroyableSwapTable = new();
        public DataTable levelSwapTable = new();
        public DataTable customTable = new();

        public string CreateBackup()
        {
            string filename = "";
            string path = "";
            string originalBigfilePath = "";
            // if loaded v5 bigfile exists (no reason it shouldn't except if user deletes the file while app is running)
            if (File.Exists(bigfilePath))
            {
                if (CheckBigfile(bigfilePath))
                {
                    originalBigfilePath = bigfilePath;
                    // create backup of original bigfile if it doesn't exist
                    if (!CheckBigfile(Path.Combine(gameDir, backup_filename))) filename = backup_filename;
                    // above function changes bigfilePath to backup path for some reason, change it back to main bigfile's path
                    bigfilePath = originalBigfilePath;
                }

            }


            if (filename != "")
            {
                path = Path.Combine(gameDir, filename);
                File.Copy(originalBigfilePath, path, true);
            }

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
                FileStream file = new(thispath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new();
                for (int i = 0; i < retVal.Length; i++) sb.Append(retVal[i].ToString("x2"));
                string bigfileHash = sb.ToString();

                switch (bigfileHash)
                {
                    case "624173c8c4865011fbf95abd8c5a1e15":
                        // v7-s r13648
                        gameVer = 713648;
                        gameVerString = "7-s r13648";
                        backup_filename = "bigfile_rep7_13648_backup";
                        return true;
                    case "ed5e0d281ad5bf730879733550f62c0a":
                        // v7
                        gameVer = 7;
                        gameVerString = "7";
                        backup_filename = "bigfile_rep7_backup";
                        return true;
                    case "5e09e0fbb6c351009aae725696afa7fc":
                        // v5
                        gameVer = 5;
                        gameVerString = "5";
                        backup_filename = "bigfile_rep_backup";
                        return true;
                    default:
                        // should be the currently supported version by the Swapper
                        gameVer = 713648;
                        gameVerString = "7-s r13648";
                        backup_filename = "bigfile_rep7_13648_backup";
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
            string backup_filename;
            switch (gameVer)
            {
                case 5:
                    backup_filename = "bigfile_rep_backup";
                    break;
                case 7:
                    backup_filename = "bigfile_rep7_backup";
                    break;
                case 713648:
                    backup_filename = "bigfile_rep7_13648_backup";
                    break;
                default:
                    backup_filename = "bigfile_rep7_13648_backup";
                    break;
            }
            string backupPath = Path.Combine(gameDir, backup_filename);
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

        public void AddToList(MainWindow mainwindow, string assetClass, int orig, int replace, bool fromLoad = false)
        {
            // if (mode == "alldata") graphics+data, else graphics only
            if (orig != replace)
            {
                Bitmap origThumb = mainwindow.thumbnailslib.getThumbnail(assetClass, orig);
                Bitmap newThumb = mainwindow.thumbnailslib.getThumbnail(assetClass, replace);
                DataTable thistable = new();
                string origName = "";
                string newName = "";
                DataRow row;
                bool goAhead = false;
                dynamic panel = mainwindow.swaplistpanel;
                dynamic swapperscreen = mainwindow.swapper;
                dynamic randomizerscreen = mainwindow.randomizer;
                int changedCount = 0;

                switch (assetClass)
                {
                    case "character":
                        thistable = swapTable;
                        origName = characterDictionary[orig].Name;
                        newName = characterDictionary[replace].Name;
                        changeList[orig] = replace;
                        changeTo[replace] = true;
                        changedCount = changeTo.Count;
                        customCharacterNames[characterDictionary[orig].CustomNameIndex] = bigfileClass.characterCollection[replace].Name;
                        if (characterCustomizationInMemory.ContainsKey(orig))
                        {
                            characterCustomizationInMemory.Remove(orig);
                        }
                        if (characterCustomizationQueue.ContainsKey(orig) && !fromLoad)
                        {
                            int[] customcount = RemoveFromTable(mainwindow, "customCharacter", orig);
                            mainwindow.charactercustomizerpanel.labelReplaceCount.Text = customcount[0].ToString();
                        }
                        if (mainwindow.charactercustomizerscreen.characterList.SelectedIndex == orig)
                        {
                            if (mainwindow.charactercustomizerscreen.characterList.SelectedIndex == 1)
                            {
                                mainwindow.charactercustomizerscreen.characterList.SelectedIndex = 2;
                            }
                            else
                            {
                                mainwindow.charactercustomizerscreen.characterList.SelectedIndex = 1;
                            }
                            mainwindow.charactercustomizerscreen.characterList.SelectedIndex = orig;
                        }
                        goAhead = true;
                        break;
                    case "item":
                        thistable = itemSwapTable;
                        origName = itemDictionary[orig].Name;
                        newName = itemDictionary[replace].Name;
                        itemChangeList[orig] = replace;
                        itemChangeTo[replace] = true;
                        changedCount = itemChangeTo.Count;

                        panel = mainwindow.swaplistitempanel;
                        swapperscreen = mainwindow.swapperitems;
                        randomizerscreen = mainwindow.randomizeritems;
                        goAhead = true;
                        break;
                    case "destroyable":
                        thistable = destroyableSwapTable;
                        origName = destroyableDictionary[orig].Name;
                        newName = destroyableDictionary[replace].Name;
                        destroyableChangeList[orig] = replace;
                        destroyableChangeTo[replace] = true;
                        changedCount = destroyableChangeTo.Count;

                        panel = mainwindow.swaplistdestroyablepanel;
                        swapperscreen = mainwindow.swapperdestroyables;
                        randomizerscreen = mainwindow.randomizerdestroyables;
                        goAhead = true;
                        break;
                    case "level":
                        thistable = levelSwapTable;
                        origName = levelDictionary[orig].Name;
                        newName = levelDictionary[replace].Name;
                        levelChangeList[orig] = replace;
                        levelChangeTo[replace] = true;
                        changedCount = levelChangeTo.Count;

                        panel = mainwindow.swaplistlevelpanel;
                        swapperscreen = mainwindow.swapperlevels;
                        randomizerscreen = mainwindow.randomizerlevels;
                        goAhead = true;
                        break;
                }

                if (goAhead)
                {
                    row = thistable.NewRow();
                    row["delete"] = "\u2716";
                    row["origThumb"] = origThumb;
                    row["origName"] = origName;
                    row["spacer"] = "\u2794";
                    row["replaceThumb"] = newThumb;
                    row["replaceName"] = newName;
                    row["origKey"] = orig;
                    row["replaceKey"] = replace;
                    row["rowIndex"] = thistable.Rows.Count;
                    thistable.Rows.Add(row);

                    mainwindow.hasNoPending = false;
                    mainwindow.container.labelPending.Visible = true;
                    panel.labelReplaceCount.Text = (thistable.Rows.Count).ToString();
                    panel.labelReplaceUniqueCount.Text = changedCount.ToString();
                    swapperscreen.btnShowList.Enabled = true;
                    randomizerscreen.btnShowList.Enabled = true;
                }
            }
        }

        public void AddCustom(MainWindow mainwindow, string assetClass, int assetKey, CharacterClass characterDetails)
        {
            Bitmap origThumb = mainwindow.thumbnailslib.getThumbnail(assetClass, assetKey);
            DataRow row;
            bool goAhead = false;

            // check for differences before proceeding

            // 2. iterate and compare every item in the class
            // if a difference is found, go ahead, else remove from queue
            int targetKey = assetKey;
            if (changeList.ContainsKey(assetKey)) targetKey = changeList[assetKey];
            var originalClass = bigfileClass.characterCollection[targetKey];
            if (originalClass.NameIndex != characterDetails.NameIndex) goAhead = true;
            if (originalClass.Health != characterDetails.Health) goAhead = true;
            if (originalClass.Speed.X != characterDetails.Speed.X) goAhead = true;
            if (originalClass.Speed.Y != characterDetails.Speed.Y) goAhead = true;
            if (originalClass.IsBoss != characterDetails.IsBoss) goAhead = true;
            if (originalClass.DespawnsAfterDeath != characterDetails.DespawnsAfterDeath) goAhead = true;
            if (originalClass.Shader != characterDetails.Shader) goAhead = true;
            if (originalClass.Team != characterDetails.Team) goAhead = true;

            // 1. check if character name is different from the original, if not then don't go ahead and remove from queue
            if (characterDetails.Name != characterDetails.NewName)
            {
                goAhead = true;

                // if character has CustomNameIndex and CustomName != CustomNameIndex
                // AND if NewName != nameReference[CustomNameIndex]
                // add set NewNameIndex to CustomNameIndex
                // AND set NewName to nameReference[CustomNameIndex]
                customCharacterNames[characterDictionary[assetKey].CustomNameIndex] = characterDetails.NewName;
           }
            else
            {
                customCharacterNames[characterDictionary[targetKey].CustomNameIndex] = characterDetails.NewName;
            }


            int movectr = 0;
            foreach (var move in originalClass.Moveset)
            {
                int hitctr = 0;
                foreach (var hit in move.Hits)
                {
                    var inputDetails = characterDetails.Moveset[movectr].Hits[hitctr];
                    if (inputDetails.Damage != hit.Damage) goAhead = true;
                    if (inputDetails.Hitstop != hit.Hitstop) goAhead = true;
                    if (inputDetails.Hitstun != hit.Hitstun) goAhead = true;
                    hitctr++;
                }
                movectr++;
            }
            // add or remove from the queue and table
            if (goAhead)
            {
                DataRow[] dataRows = customTable.Select("origKey = " + assetKey);
                if (dataRows.Count() == 0)
                {
                    row = customTable.NewRow();
                    row["delete"] = "\u2716";
                    row["origThumb"] = origThumb;
                    row["origName"] = characterDictionary[assetKey].Name;
                    if (changeList.ContainsKey(assetKey))
                    {
                        row["spacer"] = "\u2794";
                        row["replaceThumb"] = mainwindow.thumbnailslib.getThumbnail("character", changeList[assetKey]);
                        row["replaceName"] = characterDictionary[changeList[assetKey]].Name;
                    }
                    else
                    {
                        row["spacer"] = "";
                        row["replaceThumb"] = mainwindow.thumbnailslib.getThumbnail("placeholder", 0);
                        row["replaceName"] = "";
                    }
                    row["origKey"] = assetKey;
                    row["rowIndex"] = customTable.Rows.Count;

                    customTable.Rows.Add(row);
                }
                else
                {
                    // get rowIndex of origKey and maybe update it
                }

                characterCustomizationQueue[assetKey] = characterDetails;
                
                mainwindow.charactercustomizerpanel.labelReplaceCount.Text = (customTable.Rows.Count).ToString();

                mainwindow.hasNoPending = false;
                mainwindow.container.labelPending.Visible = true;
                mainwindow.charactercustomizerscreen.btnShowList.Enabled = true;
                mainwindow.BringToFront();
            }
            else
            {
                // find the index of the row where this custom is stored and remove that row
                foreach (System.Windows.Forms.DataGridViewRow customRow in mainwindow.charactercustomizerpanel.dataGridView1.Rows)
                {
                    try
                    {
                        if ((int)customRow.Cells[3].Value == assetKey)
                        {
                            RemoveFromTable(mainwindow, "customCharacter", assetKey);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        public void CreateSwapTable(MainWindow mainwindow)
        {
            swapTable.Columns.Add("delete", typeof(string));
            swapTable.Columns.Add("origThumb", typeof(Bitmap));
            swapTable.Columns.Add("origName", typeof(string));
            swapTable.Columns.Add("spacer", typeof(string));
            swapTable.Columns.Add("replaceThumb", typeof(Bitmap));
            swapTable.Columns.Add("replaceName", typeof(string));
            swapTable.Columns.Add("origKey", typeof(int));
            swapTable.Columns.Add("replaceKey", typeof(int));
            swapTable.Columns.Add("rowIndex", typeof(int));
            mainwindow.swaplistpanel.dataGridView1.DataSource = swapTable;

            itemSwapTable.Columns.Add("delete", typeof(string));
            itemSwapTable.Columns.Add("origThumb", typeof(Bitmap));
            itemSwapTable.Columns.Add("origName", typeof(string));
            itemSwapTable.Columns.Add("spacer", typeof(string));
            itemSwapTable.Columns.Add("replaceThumb", typeof(Bitmap));
            itemSwapTable.Columns.Add("replaceName", typeof(string));
            itemSwapTable.Columns.Add("origKey", typeof(int));
            itemSwapTable.Columns.Add("replaceKey", typeof(int));
            itemSwapTable.Columns.Add("rowIndex", typeof(int));
            mainwindow.swaplistitempanel.dataGridView2.DataSource = itemSwapTable;

            destroyableSwapTable.Columns.Add("delete", typeof(string));
            destroyableSwapTable.Columns.Add("origThumb", typeof(Bitmap));
            destroyableSwapTable.Columns.Add("origName", typeof(string));
            destroyableSwapTable.Columns.Add("spacer", typeof(string));
            destroyableSwapTable.Columns.Add("replaceThumb", typeof(Bitmap));
            destroyableSwapTable.Columns.Add("replaceName", typeof(string));
            destroyableSwapTable.Columns.Add("origKey", typeof(int));
            destroyableSwapTable.Columns.Add("replaceKey", typeof(int));
            destroyableSwapTable.Columns.Add("rowIndex", typeof(int));
            mainwindow.swaplistdestroyablepanel.dataGridView2.DataSource = destroyableSwapTable;

            levelSwapTable.Columns.Add("delete", typeof(string));
            levelSwapTable.Columns.Add("origThumb", typeof(Bitmap));
            levelSwapTable.Columns.Add("origName", typeof(string));
            levelSwapTable.Columns.Add("spacer", typeof(string));
            levelSwapTable.Columns.Add("replaceThumb", typeof(Bitmap));
            levelSwapTable.Columns.Add("replaceName", typeof(string));
            levelSwapTable.Columns.Add("origKey", typeof(int));
            levelSwapTable.Columns.Add("replaceKey", typeof(int));
            levelSwapTable.Columns.Add("rowIndex", typeof(int));
            mainwindow.swaplistlevelpanel.dataGridView2.DataSource = levelSwapTable;

            customTable.Columns.Add("delete", typeof(string));
            customTable.Columns.Add("origThumb", typeof(Bitmap));
            customTable.Columns.Add("origName", typeof(string));
            customTable.Columns.Add("spacer", typeof(string));
            customTable.Columns.Add("replaceThumb", typeof(Bitmap));
            customTable.Columns.Add("replaceName", typeof(string));
            customTable.Columns.Add("origKey", typeof(int));
            customTable.Columns.Add("rowIndex", typeof(int));   
            mainwindow.charactercustomizerpanel.dataGridView1.DataSource = customTable;
        }

        public void FilterSwapTable(string mode, string datatype, string lookup)
        {
            switch (mode)
            {
                case "character":
                    swapTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", datatype, lookup);
                    break;
                case "item":
                    itemSwapTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", datatype, lookup);
                    break;
                case "destroyable":
                    destroyableSwapTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", datatype, lookup);
                    break;
                case "level":
                    levelSwapTable.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", datatype, lookup);
                    break;
            }
        }

        public int[] RemoveFromTable(MainWindow mainwindow, string assetClass, int origKey)
        {
            int[] returnCount = new int[2];
            DataRow[] swapRows;
            switch (assetClass)
            {
                case "character":
                    changeList.Remove(origKey);

                    // fetch row index
                    swapRows = swapTable.Select("origKey = " + origKey);
                    if (swapRows.Count() > 0)
                    {
                        foreach (DataRow dataRow in swapRows)
                        {
                            int rowIndex = int.Parse(dataRow["rowIndex"].ToString());
                            swapTable.Rows.RemoveAt(rowIndex);

                            if (characterCustomizationQueue.ContainsKey(origKey))
                            {
                                int[] customcount = RemoveFromTable(mainwindow, "customCharacter", origKey);
                                mainwindow.charactercustomizerpanel.labelReplaceCount.Text = customcount[0].ToString();
                            }
                            if (mainwindow.charactercustomizerscreen.characterList.SelectedIndex == origKey)
                            {
                                if (mainwindow.charactercustomizerscreen.characterList.SelectedIndex == 1)
                                {
                                    mainwindow.charactercustomizerscreen.characterList.SelectedIndex = 2;
                                }
                                else
                                {
                                    mainwindow.charactercustomizerscreen.characterList.SelectedIndex = 1;
                                }
                                characterCustomizationInMemory.Remove(origKey);
                                mainwindow.charactercustomizerscreen.characterList.SelectedIndex = origKey;
                                characterCustomizationInMemory.Remove(origKey);
                            }
                        }
                    }

                    // re-index row numbers to allow removal
                    for (int i = 0; i < swapTable.Rows.Count; i++)
                    {
                        swapTable.Rows[i]["rowIndex"] = i;
                    }

                    // reset unique list
                    changeTo.Clear();
                    foreach (KeyValuePair<int, int> pair in changeList)
                    {
                        if (!changeTo.ContainsKey(pair.Value)) changeTo[pair.Value] = true;
                    }
                    returnCount = new int[2] { swapTable.Rows.Count, changeTo.Count() };
                    break;
                case "item":
                    itemChangeList.Remove(origKey);

                    // fetch row index
                    swapRows = itemSwapTable.Select("origKey = " + origKey);
                    if (swapRows.Count() > 0)
                    {
                        foreach (DataRow dataRow in swapRows)
                        {
                            int rowIndex = int.Parse(dataRow["rowIndex"].ToString());
                            itemSwapTable.Rows.RemoveAt(rowIndex);
                        }
                    }

                    // re-index row numbers to allow removal
                    for (int i = 0; i < itemSwapTable.Rows.Count; i++)
                    {
                        itemSwapTable.Rows[i]["rowIndex"] = i;
                    }

                    // reset unique list
                    itemChangeTo.Clear();
                    foreach (KeyValuePair<int, int> pair in itemChangeList)
                    {
                        if (!itemChangeTo.ContainsKey(pair.Value)) itemChangeTo[pair.Value] = true;
                    }
                    returnCount = new int[2] { itemSwapTable.Rows.Count, itemChangeTo.Count() };
                    break;
                case "destroyable":
                    destroyableChangeList.Remove(origKey);

                    // fetch row index
                    swapRows = destroyableSwapTable.Select("origKey = " + origKey);
                    if (swapRows.Count() > 0)
                    {
                        foreach (DataRow dataRow in swapRows)
                        {
                            int rowIndex = int.Parse(dataRow["rowIndex"].ToString());
                            destroyableSwapTable.Rows.RemoveAt(rowIndex);
                        }
                    }

                    // re-index row numbers to allow removal
                    for (int i = 0; i < destroyableSwapTable.Rows.Count; i++)
                    {
                        destroyableSwapTable.Rows[i]["rowIndex"] = i;
                    }

                    // reset unique list
                    destroyableChangeTo.Clear();
                    foreach (KeyValuePair<int, int> pair in destroyableChangeList)
                    {
                        if (!destroyableChangeTo.ContainsKey(pair.Value)) destroyableChangeTo[pair.Value] = true;
                    }
                    returnCount = new int[2] { destroyableSwapTable.Rows.Count, destroyableChangeTo.Count() };
                    break;
                case "level":
                    levelChangeList.Remove(origKey);

                    // fetch row index
                    swapRows = levelSwapTable.Select("origKey = " + origKey);
                    if (swapRows.Count() > 0)
                    {
                        foreach (DataRow dataRow in swapRows)
                        {
                            int rowIndex = int.Parse(dataRow["rowIndex"].ToString());
                            levelSwapTable.Rows.RemoveAt(rowIndex);
                        }
                    }

                    // re-index row numbers to allow removal
                    for (int i = 0; i < levelSwapTable.Rows.Count; i++)
                    {
                        levelSwapTable.Rows[i]["rowIndex"] = i;
                    }

                    // reset unique list
                    levelChangeTo.Clear();
                    foreach (KeyValuePair<int, int> pair in levelChangeList)
                    {
                        if (!levelChangeTo.ContainsKey(pair.Value)) levelChangeTo[pair.Value] = true;
                    }
                    returnCount = new int[2] { levelSwapTable.Rows.Count, levelChangeTo.Count() };
                    break;
                case "customCharacter":
                    characterCustomizationQueue.Remove(origKey);
                    characterCustomizationInMemory.Remove(origKey);

                    // reset name
                    string customNameIndex = characterDictionary[origKey].CustomNameIndex;
                    int targetKey = origKey;
                    if (changeList.ContainsKey(origKey)) targetKey = changeList[origKey];
                    CharacterClass origData = bigfileClass.characterCollection[targetKey];
                    customCharacterNames[customNameIndex] = bigfileClass.customCharacterNames[origData.NameIndex];

                    // fetch row index
                    swapRows = customTable.Select("origKey = " + origKey);
                    if (swapRows.Count() > 0)
                    {
                        foreach (DataRow dataRow in swapRows)
                        {
                            int rowIndex = int.Parse(dataRow["rowIndex"].ToString());
                            customTable.Rows.RemoveAt(rowIndex);
                        }
                    }

                    // re-index row numbers to allow removal
                    for (int i = 0; i < customTable.Rows.Count; i++)
                    {
                        customTable.Rows[i]["rowIndex"] = i;
                    }
                    returnCount = new int[2] { customTable.Rows.Count, 0 };
                    break;
            }
            return returnCount;
        }

        public void ClearTable(string assetClass, dynamic panel = null)
        {
            switch (assetClass)
            {
                case "character":
                    swapTable.Clear();
                    changeList.Clear();
                    changeTo.Clear();
                    if (panel != null)
                    {
                        panel.labelReplaceCount.Text = "0";
                        panel.labelReplaceUniqueCount.Text = "0";
                    }
                    break;
                case "item":
                    itemSwapTable.Clear();
                    itemChangeList.Clear();
                    itemChangeTo.Clear();
                    if (panel != null)
                    {
                        panel.labelReplaceCount.Text = "0";
                        panel.labelReplaceUniqueCount.Text = "0";
                    }
                    break;
                case "destroyable":
                    destroyableSwapTable.Clear();
                    destroyableChangeList.Clear();
                    destroyableChangeTo.Clear();
                    if (panel != null)
                    {
                        panel.labelReplaceCount.Text = "0";
                        panel.labelReplaceUniqueCount.Text = "0";
                    }
                    break;
                case "level":
                    levelSwapTable.Clear();
                    levelChangeList.Clear();
                    levelChangeTo.Clear();
                    if (panel != null)
                    {
                        panel.labelReplaceCount.Text = "0";
                        panel.labelReplaceUniqueCount.Text = "0";
                    }
                    break;
                case "customCharacter":
                    customTable.Clear();
                    characterCustomizationInMemory.Clear();
                    customCharacterNames.Clear();
                    // character names
                    foreach (KeyValuePair<int, CharacterClass> charClass in bigfileClass.characterCollection)
                    {
                        string nameFromOriginalIndex;
                        if (bigfileClass.customCharacterNames.ContainsKey(charClass.Value.NameIndex))
                        {
                            nameFromOriginalIndex = bigfileClass.customCharacterNames[charClass.Value.NameIndex];
                            charClass.Value.Name = nameFromOriginalIndex;
                            charClass.Value.NewName = nameFromOriginalIndex;
                            charClass.Value.SwapNameIndex = characterDictionary[charClass.Key].CustomNameIndex;
                        }
                        else
                        {
                            nameFromOriginalIndex = charClass.Value.NameIndex;
                        }
                        customCharacterNames[charClass.Value.NameIndex] = nameFromOriginalIndex;
                    }
                    if (panel != null)
                    {
                        panel.labelReplaceCount.Text = "0";
                    }
                    break;
            }
        }
    }
}
