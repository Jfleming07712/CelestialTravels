using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Map
    {
        public string Name { get; set; }
        public List<SolarSystem> SolarSystem { get; set; } = new List<SolarSystem>(); // bf: good use of initialization as part of creating the class
        public List<JumpGate> JumpGates { get; set; } = new List<JumpGate>();
        public List<Planet> Planets { get; set; } = new List<Planet>();
        public List<SpacePort> SpacePorts { get; set; } = new List<SpacePort>();
        public List<Instance> Instances { get; set; } = new List<Instance>();

    }
}
