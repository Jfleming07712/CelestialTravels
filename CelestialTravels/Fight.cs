using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Fight
    {
        public void DoFight(PlayerCharacter player, Monster whiteMonster, PlayerStats stats)
        {
            var roller = new Roller();
            var monster = whiteMonster;
            var fightOver = false;
            Character winner = player;
            Character looser = player;


            PlayerAttackCalculator.CalculatePlayerAttack(player);


            

            PreBattleRoll(roller, player, monster, out Character attacker, out Character defender);




            while (fightOver == false)
            {
                // Rolling
                attacker.Roll = roller.GetRandomNumber(1, 12);

                // Calculate Damage
                var damage = (attacker.Roll / 10) * attacker.Attack;

                // Apply damage to defender
                defender.CurrentHitPoints = defender.CurrentHitPoints - damage;


                // End fight and declare winner or switch roles 
                if (defender.CurrentHitPoints <= 0)
                {
                    // End the fight
                    fightOver = true;
                    winner = attacker;
                    looser = defender;
                }
                else
                {
                    // Switch roles
                    var temporaryCharacter = attacker;
                    attacker = defender;
                    defender = temporaryCharacter;
                }

            }

            // Post battle stuff.
            if (winner.Name == player.Name)
            {
                player = (PlayerCharacter)winner;
                player.Experience += looser.TotalHitPoints;
                player.CurrentHitPoints = player.TotalHitPoints;


                Console.WriteLine("YOU ARE A WINNER");
                Console.WriteLine("You received " + looser.TotalHitPoints + " Experience Points.");
                stats.PrintPlayerStats(player);
            }
            else
            {
                player = (PlayerCharacter)looser;



                Console.WriteLine("YOU ARE A LOOSER!");
            }

        }












        private static void PreBattleRoll(Roller roller, PlayerCharacter player, Monster monster, out Character attacker, out Character defender)
        {
            player.Roll = roller.GetRandomNumber(1, 100);
            monster.Roll = roller.GetRandomNumber(1, 100);

            if (player.Roll > monster.Roll)
            {
                attacker = player;
                defender = monster;
                Console.WriteLine("Player wins the toss");
                Console.WriteLine("player health   " + player.CurrentHitPoints);
                Console.WriteLine("monster health   " + defender.CurrentHitPoints);

            }
            else
            {
                attacker = monster;
                defender = player;
                Console.WriteLine("Monster wins the toss");
                Console.WriteLine("player health   " + player.CurrentHitPoints);
                Console.WriteLine("Monster health as attacker health   " + attacker.CurrentHitPoints);

            }
        }
    }
}
