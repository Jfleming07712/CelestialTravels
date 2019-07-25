using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Story
    {
        public void TheBegining01(PlayerCharacter player, Inventory playerInventory, WeaponMaker weaponMaker)
        {


            // need to fix the formating of all this text 
            Console.WriteLine("After a childhood of loving protection, and peace, an evil race of Space Sharks have/n shown up at your home planet of" +
                "Fae.  In their invasion they have decapitated your parents, disembowled your siblings, and stolen everything you ever had.  You are" +
                "left to torment, and starvation in a blood bath.");

            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine("After the carnage, a pilot shows up to find you.  He shepards you onto his spaceship " +
                "and flies you to the Capital, Brettopia, where you are presented to the Space King of Knowledge.");

            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine($"SPACE KING BRETT: Young { player.Name} I have heard the tale of your strife at the hand of " +
                "the Space Sharks.  I weep for your misfortune.  I would avenge your family for you, but our vast " +
                "library, The Great Database, does not have the knowledge needed to combat the cruel and ruthless " +
                "Space Sharks.  I task you to become a noble Space Knight of Knowledge, and seek the data we need " +
                "to combat this oppressive enemy.  To help you on your travels, I shall grant you 3 things...First " +
                "I will give you a DiamondDrive in which you will collect as much Data as you can find.  Second I will give " +
                "you a space map of our SolarSytem so you may navigate on your quest for Data.  And finally I shall send " +
                "with you my most trusted advisor... Mr. Piddles.  Go forth, collect the data, and find a way to defeat " +
                "the cruel Space Sharks!\n");

            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine("You gratefully accept your quest, thank the king, and begin to leave with Mr. Piddles.  " +
                "when you are almost to the door the pilot who found you stops you.\n");

            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine($"PILOT:  {player.Name} you will need 2 more things on your journey.  Here take my Blaster to " +
                $"protect yourself and smite your enemies.  You will also need some Credits if you are going to venture " +
                $"across the stars\n");

            Console.WriteLine(@"Hey thanks for the Cash and Guns man!");


            weaponMaker.CreateWeaponBlaster(playerInventory);

            if (player.Credits < 100)
            {
                player.Credits += 100;
            }
            
            Console.WriteLine($"{player.Name} has {player.Credits} Credits\n");
            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine($"{player.Name.ToUpper()}: Come on Mr. Piddles, Let's go Shark hunting!");
            Console.WriteLine("Return to continue...");
            Console.ReadLine();

            Console.WriteLine("MR. PIDDLES: Meow meow meow, meow meow meow meow!\n");
            Console.WriteLine("Return to continue...");
            Console.ReadLine();
        }
    }
}
