using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerCreator
    {
        public void CreatePlayer(PlayerCharacter player, PlayerStats stats)
        {
            var genderValid = false;
            var raceValid = false;
            var jobValid = false;

            Console.WriteLine("Welcome to CelestialTravels...What is your name?");

            player.Name = Console.ReadLine();

            Console.WriteLine($"Hello { player.Name} \n");

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
        }

    }
}
