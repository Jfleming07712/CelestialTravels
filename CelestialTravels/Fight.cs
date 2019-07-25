using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Fight
    {

        public void DoFight(PlayerCharacter player, Monster whiteMonster, PlayerStats stats, Inventory playerInventory)
        {
            var roller = new Roller();
            var monster = whiteMonster;
            var fightOver = false;
            Character winner = player;
            Character looser = player;


            

            PreBattleRoll(roller, player, monster, out Character attacker, out Character defender);


            while (fightOver == false)
            {
                // Select Weapon
                ChooseWeaponToAttackWith(attacker, player, playerInventory);


                // Rolling
                attacker.Roll = roller.GetRandomNumber(1, 12);
                Console.WriteLine("attacker's roll " + attacker.Roll + "\n");

                // Calculate Damage
                var damage = (attacker.Roll / 10) * attacker.Attack;
                Console.WriteLine("Damage " + (damage) + "\n");

                // Apply damage to defender
                defender.CurrentHitPoints = defender.CurrentHitPoints - damage;
                Console.WriteLine("Defender's HP  " + defender.CurrentHitPoints + "\n");
                Console.ReadLine();

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

                    Console.WriteLine("the Attacker is now " + attacker.Name + "\n");
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






        public static void PreBattleRoll(Roller roller, PlayerCharacter player, Monster monster, out Character attacker, out Character defender)
        {
            player.Roll = roller.GetRandomNumber(1, 100);
            monster.Roll = roller.GetRandomNumber(1, 100);

            if (player.Roll > monster.Roll)
            {
                attacker = player;
                defender = monster;
                Console.WriteLine("Player wins the toss and is the Attacker");
                Console.WriteLine("player health   " + player.CurrentHitPoints);
                Console.WriteLine("monster health   " + defender.CurrentHitPoints);

            }
            else
            {
                attacker = monster;
                defender = player;
                Console.WriteLine("Monster wins the toss and is the Attacker");
                Console.WriteLine("player health   " + player.CurrentHitPoints);
                Console.WriteLine("Monster health   " + attacker.CurrentHitPoints);
                Console.WriteLine("");

            }
        }

        public void ChooseWeaponToAttackWith(Character attacker, Character player, Inventory playerInventory)
        {
            if (attacker == player)
            {
                Console.WriteLine("Choose which weapon to attack with (enter the number) ");
                playerInventory.EunumerateWeapons();
                var TempChosenWeaponToAttackWith = Console.ReadLine();

                // Need to check if the input is an int or else it throws exeption when I type wrong.


                int ChosenWeaponToAttackWith = Convert.ToInt32(TempChosenWeaponToAttackWith);

                player.CurrentWeaponDamage = playerInventory.WeaponList[ChosenWeaponToAttackWith].Attack;
                
                PlayerAttackCalculator.CalculatePlayerAttack((PlayerCharacter) player);

                playerInventory.WeaponList[ChosenWeaponToAttackWith].Durability -= 1;
            }
            
        }
    }
}
