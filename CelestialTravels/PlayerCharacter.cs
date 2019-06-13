using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Job { get; set; }
        public int Credits { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TotalHitPoints { get; set; }
        public int WeaponSkill { get; set; }
        public int ArmorSkill { get; set; }
        public int NavigationSkill { get; set; }
        public int TimeSkill { get; set; }
        public string CurrentWeapon { get; set; }

        public Inventory Inventory { get; set; } = new Inventory();
    }

    public static class Options
    {
        public static string[] Genders = new string[] { "Male", "Female", "NonBinary" };
        public static string[] Races = new string[] { "Lizarian", "Cepholarian", "Fuzzarian" };
        public static string[] Jobs = new string[] { "Navigator", "Gunslinger", "Timebender" };
    }
}