﻿using System;
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
        public string Credits { get; set; }
        public string Experience { get; set; }

    }

    public static class Options
    {
        public static string[] Genders = new string[] { "Male", "Female", "NonBinary" };
        public static string[] Races = new string[] { "Lizarian", "Cepholarian", "Fuzzarian" };
        public static string[] Jobs = new string[] { "Navigator", "Gunslinger", "Timebender" };
    }
}