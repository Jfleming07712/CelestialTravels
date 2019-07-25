using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerCharacter : Character
    {
        public Inventory Inventory { get; set; } = new Inventory();
        public Place Location { get; set; }
    }

    public static class Options
    {
        public static string[] Genders = new string[] { "Male", "Female", "NonBinary" };
        public static string[] Races = new string[] { "Lizarian", "Cepholarian", "Fuzzarian" };
        public static string[] Jobs = new string[] { "Navigator", "Gunslinger", "Timebender" };
    }
}