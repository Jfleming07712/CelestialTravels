using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialTravels
{

    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CelestialTravels...What is your name?");
            

            var player = new PlayerCharacter();
            var stats = new PlayerStats();
            player.Name = Console.ReadLine();
            Console.WriteLine($"Hello { player.Name} \n");
            stats.PrintPlayerStats(player);

            var genderValid = false;
            var raceValid = false;
            var jobValid = false;


            do
            {
                foreach (string gender in Options.Genders)
                {
                    Console.WriteLine(gender);
                }


                Console.WriteLine($"\nWhat is your gender? ");

                var enteredGender = Console.ReadLine();

                if (enteredGender == "Male")
                {
                    player.Gender = "Male";
                    Console.WriteLine($"\n{ player.Name} is {player.Gender}\n");
                    genderValid = true;
                }

                else if (enteredGender == "Female")
                {
                    player.Gender = "Female";
                    Console.WriteLine($"\n{ player.Name} is {player.Gender}\n");
                    genderValid = true;
                }

                else if (enteredGender == "NonBinary")
                {
                    player.Gender = "NonBinary";
                    Console.WriteLine($"\n{ player.Name} is {player.Gender}\n");
                    genderValid = true;
                }
            }
            while (genderValid == false);


            do
            {
                foreach (string race in Options.Races)
                {
                    Console.WriteLine(race);
                }

                Console.WriteLine("\nWhat is your race?");

                var enteredRace = Console.ReadLine();

                if (enteredRace == "Lizarian")
                {
                    player.Race = "Lizarian";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race}\n");
                    raceValid = true;
                }

                else if (enteredRace == "Cepholarian")
                {
                    player.Race = "Cepholarian";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race}\n");
                    raceValid = true;
                }

                else if (enteredRace == "Fuzzarian")
                {
                    player.Race = "Fuzzarian";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race}\n");
                    raceValid = true;
                }
            }
            while (raceValid == false);



            do
            {

                foreach (string job in Options.Jobs)
                {
                    Console.WriteLine(job);
                }

                Console.WriteLine("\nWhat is your job?");

                var enteredJob = Console.ReadLine();

                if (enteredJob == "Navigator")
                {
                    player.Job = "Navigator";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race} {player.Job}\n");
                    player.NavigationSkill += 5;
                    if (player.Race == "Lizarian")
                    {
                        Console.WriteLine($"{player.Name} the Navi >*^,^,^~~~");
                    }
                    Console.WriteLine("NavigationSkill +5\n");
                    stats.PrintPlayerStats(player);
                    Console.WriteLine("Return any key to continue...");
                    Console.ReadLine();
                    jobValid = true;
                }

                else if (enteredJob == "Gunslinger")
                {
                    player.Job = "Gunslinger";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race} {player.Job}\n");
                    player.WeaponSkill += 5;
                    Console.WriteLine("WeaponSkill +5\n");
                    stats.PrintPlayerStats(player);
                    Console.WriteLine("Return any key to continue...");
                    Console.ReadLine();
                    jobValid = true;

                }

                else if (enteredJob == "Timebender")
                {
                    player.Job = "Timebender";
                    Console.WriteLine($"\n{ player.Name} is a {player.Gender} {player.Race} {player.Job}\n");
                    player.TimeSkill += 5;
                    Console.WriteLine("TimeSkill +5\n");
                    stats.PrintPlayerStats(player);
                    Console.WriteLine("Return any key to continue...");
                    Console.ReadLine();
                    jobValid = true;
                }
            }
            while (jobValid == false);

            Console.WriteLine("After a childhood of loving protection, and peace, an evil race of Space Sharks have shown up " +
                "at your home planet of Fae.  In their invasion they have decapitated your parents, disembowled your " +
                "siblings, and stolen everything you ever had.  You are left to torment, and starvation in a blood bath.\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine("After the carnage, a pilot shows up to find you.  He shepards you onto his spaceship " +
                "and flies you to the Capital, Brettopia, where you are presented to the Space King of Knowledge.\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine($"SPACE KING BRETT: Young { player.Name} I have heard the tale of your strife at the hand of " +
                "the Space Sharks.  I weep for your misfortune.  I would avenge your family for you, but our vast " +
                "library, The Great Database, does not have the knowledge needed to combate the cruel and ruthless " +
                "Space Sharks.  I task you to become a noble Space Knight of Knowledge, and seek the data we need " +
                "to combat this oppressive enemy.  To help you on your travels, I shall grant you 3 things...First " +
                "I will give you a DiamondDrive in which you will collect as much Data as you can find.  Second I will give " +
                "you a space map of our SolarSytem so you may navigate on your quest for Data.  And finally I shall send " +
                "with you my most trusted advisor... Mr. Piddles.  Go forth, collect the data, and find a way to defeat " +
                "the cruel Space Sharks!\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine("You gratefully accept your quest, thank the king, and begin to leave with Mr. Piddles.  " +
                "when you are almost to the door the pilot who found you stops you.\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine($"PILOT:  {player.Name} you will need 2 more things on your journey.  Here take my Blaster to " +
                $"protect yourself and smite your enemies.  You will also need some Credits if you are going to venture " +
                $"across the stars\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            player.Credits = player.Credits + 100;
            Console.WriteLine($"{player.Name} has {player.Credits} Credits\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine($"{player.Name.ToUpper()}: Come on Mr. Piddles, Let's go Shark hunting!");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();

            Console.WriteLine("MR. PIDDLES: Meow meow meow, meow meow meow meow!\n");
            Console.WriteLine("Return any key to continue...");
            Console.ReadLine();



        }

        
    }
}
