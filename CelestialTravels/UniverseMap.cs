using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class UniverseMap
    {
        public List<Map> UniverseMaps { get; set; } = new List<Map>();

        public void EnumerateMaps() {

        }

        public void EnumerateJumpGates()
        {
            foreach (Map map in UniverseMaps)
            {
                Console.WriteLine((UniverseMaps.IndexOf(map) + ")  " + (map.Name)));
            }
        }
        public void EnumerateAlphaMapSpacePorts()
        {
            

            ////var alphMapSpacePorts = this.UniverseMaps.Single(map => map.Name == "Alpha").SpacePorts

            ////foreach(SpacePort spacePort in UniverseMaps.alphaMap.SpacePorts)
        }
    }
}
