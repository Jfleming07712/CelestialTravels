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
            var fight = new Fight();
            var playerAttackCalculator = new PlayerAttackCalculator();
            var roller = new Roller();

            var player = new PlayerCharacter();
            player.Name = "Player01";
            player.CurrentHitPoints = 100;
            player.TotalHitPoints = 100;
            player.WeaponSkill = 1;

            var stats = new PlayerStats();
            var playerCreater = new PlayerCreator();
            var story = new Story();
            var monsterMaker = new MonsterMaker();
            var weaponMaker = new WeaponMaker();
            var playerInventory = new Inventory();
            var diamondDrive = new DiamondDrive();
            var travel = new Travel();

            var brettopia = new Planet();
            brettopia.Name = "Brettopia";
            brettopia.Location = "Alpha";

            var alpha = new SolarSystem();
            alpha.Name = "Alpha";
            alpha.Location = "Universe";

            var jumpGateAlpha = new JumpGate();
            jumpGateAlpha.Name = "Jump Gate Alpha";
            jumpGateAlpha.Location = "Alpha";

            var spacePortBrettopia = new SpacePort();
            spacePortBrettopia.Name = "Space Port Brettopia";
            spacePortBrettopia.Location = "Brettopia";

            var whiteMonster01 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster02 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster03 = monsterMaker.CreateWhiteMonster(player);
            var greenMonster01 = monsterMaker.CreateGreenMonster(player);
            var greenMonster02 = monsterMaker.CreateGreenMonster(player);
            var greenMonster03 = monsterMaker.CreateGreenMonster(player);
            var redMonster01 = monsterMaker.CreateRedMonster(player);
            var redMonster02 = monsterMaker.CreateRedMonster(player);
            var redMonster03 = monsterMaker.CreateRedMonster(player);




            player.WeaponSkill = 1;
            player.Name = "Player01";
            player.CurrentHitPoints = 100;
            player.TotalHitPoints = 100;
            whiteMonster01.Attack = 10;


            // This is the Quality Assurance section for temporary testing

            //Console.WriteLine("monster health" + whiteMonster01.CurrentHitPoints);
            //Console.WriteLine("monster attack" + whiteMonster01.Attack);
            //Console.ReadLine();
            //stats.PrintPlayerStats(player);
            //Console.WriteLine(roller.GetRandomNumber(1, 100));
            //Console.WriteLine(whiteMonster01.CurrentHitPoints);
            //fight.DoFight(player, whiteMonster01, stats);
            //weaponMaker.CreateWeaponBlaster(playerInventory);
            //weaponMaker.CreateWeaponDoubleBlaster(playerInventory);
            //weaponMaker.CreateWeaponPhotonSword(playerInventory);
            //fight.DoFight(player, whiteMonster01, stats, playerInventory);
            //playerInventory.WeaponEnumerator();
            spacePortBrettopia.SpacePortOptions(player, brettopia, travel, alpha, spacePortBrettopia);






            //Player creation part.
            playerCreater.CreatePlayer(player, stats);



            // The story begins
            story.TheBegining01(player, playerInventory, weaponMaker);


            Console.WriteLine("Time for your first battle! \n");
            fight.DoFight(player, whiteMonster01, stats, playerInventory);

        }
    }
}




//    Method calls for parts of the program that are built

//fight.DoFight(player, whiteMonster01, stats);
//playerCreater.CreatePlayer(player, stats);
//story.TheBegining01(player);
//stats.PrintPlayerStats(player);