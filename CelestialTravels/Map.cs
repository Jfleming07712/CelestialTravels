using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Map
    {
        public string Name { get; set; }
        public List<SolarSystem> SolarSystem { get; set; }
        public List<JumpGate> JumpGates { get; set; }
        public List<Planet> Planets { get; set; }
        public List<SpacePort> SpacePorts { get; set; }
        public List<Instance> Instances { get; set; }

    }
}
