using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerStats
    {
        public void PrintPlayerStats(PlayerCharacter player)
        {
            Console.WriteLine($"NAME:{player.Name}");
            Console.WriteLine($"GENDER:{player.Gender}");
            Console.WriteLine($"RACE:{player.Race}");
            Console.WriteLine($"JOB:{player.Job}");
            Console.WriteLine($"CREDITS:{player.Credits}");
            Console.WriteLine($"EXPERIENCE:{player.Experience}");
            Console.WriteLine($"LEVEL:{player.Level}");
            Console.WriteLine($"WEAPON SKILL:{player.WeaponSkill}");
            Console.WriteLine($"ARMOR SKILL:{player.ArmorSkill}");
            Console.WriteLine($"NAVIGATION SKILL:{player.NavigationSkill}");
            Console.WriteLine($"TIME SKILL:......{player.TimeSkill}");
        }

    }
}
