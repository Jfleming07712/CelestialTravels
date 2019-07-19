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
            Character attacker;
            Character defender;

            Console.WriteLine("player hp  " + player. CurrentHitPoints);
            Console.ReadLine();


            PlayerAttackCalculator.CalculatePlayerAttack(player);


            PreBattleRoll(roller, player, monster, out attacker, out defender);






            Console.WriteLine("monster HP  " + monster.CurrentHitPoints);
            stats.PrintPlayerStats(player);
            Console.ReadLine();


            attacker.Roll = roller.GetRandomNumber(1, 12);

            Console.WriteLine("attackers roll  " + attacker.Roll);
            Console.ReadLine();

            var damage = (attacker.Roll / 10) * attacker.Attack;


            Console.WriteLine("damage delt  " + damage);
            Console.ReadLine();

            defender.CurrentHitPoints -= damage;

            Console.WriteLine("damage  " + damage);
            Console.WriteLine("HP    " + defender.CurrentHitPoints);
            Console.ReadLine();





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
                Console.WriteLine("Player health as defender health   " + defender.CurrentHitPoints);

            }
        }
    }
}
