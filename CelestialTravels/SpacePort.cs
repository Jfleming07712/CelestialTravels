using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class SpacePort : Place
    {
        public Instance Instance01 { get; set; }
        public Instance Instance02 { get; set; }
        public Instance Instance03 { get; set; }


        public void SpacePortOptions(PlayerCharacter player, Planet planet, Travel travel, SolarSystem solarSystem, SpacePort spacePort)
        {
            string playerSelection;

            Console.WriteLine("You are in " + spacePort.Name);
            Console.WriteLine("0) Save Game (Not yet implimented)");
            Console.WriteLine("1) Load Game (Not yet implimented)");
            Console.WriteLine("2) Quit Game (Not yet impliment)");
            Console.WriteLine("3) Buy Consumable (Not yet implimented)");
            Console.WriteLine("4) Repair (Not yet implimented)");
            Console.WriteLine("5) Go to instance01 (Not yet implimented)");
            Console.WriteLine("6) Go to instance02 (Not yet implimented)");
            Console.WriteLine("7) Go to instance03 (Not yet implimented)");
            Console.WriteLine("8) Travel to JumpGate in solar system (Not yet implimented)");

            playerSelection = Console.ReadLine();

            switch(playerSelection)
            {
                case "0":
                    // save game method here
                    Console.WriteLine("Game Saved (not really)");
                    break;
                case "1":
                    // load game method here
                    Console.WriteLine("Game Loaded (not really)");
                    break;
                case "2":
                    // quit game method here
                    Console.WriteLine("Game Quit (not really)");
                    break;
                case "3":
                    // open store method here
                    Console.WriteLine("Store Loaded (not really)");
                    break;
                case "4":
                    // repair method here
                    Console.WriteLine("Stuff Repaired (not really)");
                    break;
                case "5":
                    // TravelToInstance method here
                    Console.WriteLine("Instance01 Loaded (not really)");
                    break;
                case "6":
                    // TravelToInstance method here
                    Console.WriteLine("Instance02 Loaded (not really)");
                    break;
                case "7":
                    // TravelToInstance method here
                    Console.WriteLine("Instance03 Loaded (not really)");
                    break;
                case "8":
                    // TravelToJumpGate method here
                    travel.TravelToJumpGate(player, solarSystem);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    
                    break;


            }

        }
    }
}
