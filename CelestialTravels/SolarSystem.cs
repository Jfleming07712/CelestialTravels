using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class SolarSystem : Place
    {
        // default constructor
        public SolarSystem() : base()
        {
        }

        // not default constructor
        public SolarSystem(string name, string location) : this()
        {
            this.Name = name;
            this.Location = location;
        }

        public List<Planet> Planets { get; set; } = new List<Planet>();
    }
}
