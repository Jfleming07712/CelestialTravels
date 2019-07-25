using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Travel
    {
        public void TravelToSolarSystem(PlayerCharacter player, SolarSystem solarSystem)
        {
            player.Location = solarSystem;
            Console.WriteLine("you are now in " + player.Location);
        }

        public void TravelToPlanet(PlayerCharacter player, Planet planet)
        {
        }

        public void TravelToSpacePort(PlayerCharacter player, SpacePort spacePort, Travel travel, SolarSystem solarSystem, Planet planet)
        {
            player.Location = spacePort;
            spacePort.SpacePortOptions(player, planet, travel, solarSystem, spacePort);
            Console.WriteLine("You are now in " + player.Location.Name);
        }

        public void TravelToInstancce(PlayerCharacter player, Instance instance)
        {

        }
    }
}
