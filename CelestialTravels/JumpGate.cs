using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class JumpGate : Place
    {
        public void JumpGateOptions(PlayerCharacter player, Planet planet, Travel travel, SolarSystem solarSystem, SpacePort spacePort, JumpGate jumpGate)
        {
            string playerSelection;

            Console.WriteLine("You are in " + jumpGate.Name);
            Console.WriteLine("0) Travel to JumpGate in another SolarSystem (Not yet implimented)");
            Console.WriteLine("1) Travel to Planet in this SolarSystem (Not yet implimented)");

            playerSelection = Console.ReadLine();

            switch (playerSelection)
            {
                case "0":
                    // TravelToSolarSystem method here
                    travel.TravelToSolarSystem(player, solarSystem);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;

                case "1":
                    // TravelToSpacePort method here
                    travel.TravelToSpacePort(player, spacePort, travel, solarSystem, planet);
                    Console.WriteLine("Game Loaded (not really)");
                    break;

                case "2":
                    // quit game method here
                    Console.WriteLine("Game Quit (not really)");
                    break;


            }
        }
    }
}
