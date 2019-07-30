using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Travel
    {
        public void TravelToJumpGate(PlayerCharacter player, SolarSystem solarSystem, JumpGate jumpGate, Planet planet, Travel travel, SpacePort spaceport)
        {
            player.Location = solarSystem;
            Console.WriteLine("you are now in " + player.Location.Name);
            jumpGate.JumpGateOptions(player, planet, travel, solarSystem, spaceport, jumpGate);
            
        }

        public void TravelToSpacePort(PlayerCharacter player, SpacePort spacePort, Travel travel, SolarSystem solarSystem, Planet planet, JumpGate jumpGate, OptionSelector optionSelector)
        {
            // I think this is where I need to use the interface for options.
            //optionSelector.GetOption<SpacePort>();
            player.Location = spacePort;
            spacePort.SpacePortOptions(player, planet, travel, solarSystem, spacePort, jumpGate);
            Console.WriteLine("You are now in " + player.Location.Name);
        }

        public void TravelToInstancce(PlayerCharacter player, Instance instance)
        {

        }
    }
}
