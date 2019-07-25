using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerMap
    {
        public List<Map> PlayerMaps { get; set; } = new List<Map>();

        public void EnumerateJumpGates()
        {
            foreach (Map map in PlayerMaps)
            {
                Console.WriteLine((PlayerMaps.IndexOf(map) + ")  " + (map.Name)));
            }
        }
    }

    
}
