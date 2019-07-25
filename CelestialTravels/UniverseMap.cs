using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class UniverseMap
    {
        public List<Map> UniverseMaps { get; set; } = new List<Map>();

        public void EnumerateJumpGates()
        {
            foreach (Map map in UniverseMaps)
            {
                Console.WriteLine((UniverseMaps.IndexOf(map) + ")  " + (map.Name)));
            }
        }
    }
}
