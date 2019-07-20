using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Job { get; set; }
        public int Credits { get; set; }
        public int Experience { get; set; }
        public int CurrentHitPoints { get; set; } = 100;
        public int TotalHitPoints { get; set; } = 100;
        public int WeaponSkill { get; set; }
        public int ArmorSkill { get; set; }
        public int NavigationSkill { get; set; }
        public int TimeSkill { get; set; }
        public int CurrentWeaponDamage { get; set; }
        public int Roll { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }

    }
}
