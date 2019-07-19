using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Fight
    {
        public void DoBattle(PlayerCharacter player, Monster whiteMonster)
        {
            var roller = new Roller();
            var player1 = player;
            var monster = whiteMonster;
            Character attacker = player1;
            Character defender = monster;


            PlayerAttackCalculator.CalculatePlayerAttack(player);


            PreBattleRoll(roller, player1, monster, out attacker, out defender);


        }





        





            
            












    private static void PreBattleRoll(Roller roller, PlayerCharacter player1, Monster monster, out Character attacker, out Character defender)
        {
            player1.Roll = roller.GetRandomNumber(1, 100);
            monster.Roll = roller.GetRandomNumber(1, 100);

            if (player1.Roll > monster.Roll)
            {
                attacker = player1;
                defender = monster;
            }
            else
            {
                attacker = monster;
                defender = player1;
            }
        }
    }
}
