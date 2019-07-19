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
            var playerAttackCalculator = new PlayerAttackCalculator();
            var roller = new Roller();
            var player = new PlayerCharacter();
            var stats = new PlayerStats();
            var playerCreater = new PlayerCreator();
            var story = new Story();
            var monsterMaker = new MonsterMaker();
            var whiteMonster01 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster02 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster03 = monsterMaker.CreateWhiteMonster(player);
            var greenMonster01 = monsterMaker.CreateGreenMonster(player);
            var greenMonster02 = monsterMaker.CreateGreenMonster(player);
            var greenMonster03 = monsterMaker.CreateGreenMonster(player);
            var redMonster01 = monsterMaker.CreateRedMonster(player);
            var redMonster02 = monsterMaker.CreateRedMonster(player);
            var redMonster03 = monsterMaker.CreateRedMonster(player);




            player.CurrentWeaponDamage = 10;
            player.WeaponSkill = 2;


            // This is the Quality Assurance section for temporary testing


            stats.PrintPlayerStats(player);
            //Console.WriteLine(roller.GetRandomNumber(1, 100));
            //Console.WriteLine(whiteMonster01.CurrentHitPoints);










            //Player creation part.
            playerCreater.CreatePlayer(player, stats);


            // The story begins
            story.TheBegining01(player);
            
        }
    }
}
