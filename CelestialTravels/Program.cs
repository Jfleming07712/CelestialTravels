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
            // Fighting things Creation

            var fight = new Fight();
            var playerAttackCalculator = new PlayerAttackCalculator();
            var roller = new Roller();

            // Player Creation

            var player = new PlayerCharacter();
            player.Name = "Player01";
            player.CurrentHitPoints = 100;
            player.TotalHitPoints = 100;
            player.WeaponSkill = 1;

            var stats = new PlayerStats();
            var playerCreater = new PlayerCreator();
            var playerInventory = new Inventory();
            var diamondDrive = new DiamondDrive();


            // Story Creation

            var story = new Story();
            
            


            // Factory Creation

            var monsterMaker = new MonsterMaker();
            var weaponMaker = new WeaponMaker();



            // Solar System Creation

            var alpha = new SolarSystem("Alpha", "Universe");
            ////alpha.Name = "Alpha";
            ////alpha.Location = "Universe";

            // not a constructor but initialization syntax
            var beta = new SolarSystem
            {
                Name = "Beta",
                Location = "Universe",
            };
            ////alpha.Name = "Beta";
            ////alpha.Location = "Universe";

            var gamma = new SolarSystem();
            alpha.Name = "Gamma";
            alpha.Location = "Universe";



            // JumpGate Creation

            var jumpGateAlpha = new JumpGate();
            jumpGateAlpha.Name = "Jump Gate Alpha";
            jumpGateAlpha.Location = "Alpha";

            var jumpGateBeta = new JumpGate();
            jumpGateAlpha.Name = "Jump Gate Beta";
            jumpGateAlpha.Location = "Beta";

            var jumpGateGamma = new JumpGate();
            jumpGateAlpha.Name = "Jump Gate Gamma";
            jumpGateAlpha.Location = "Gamma";



            // Planet Creation

            var brettopia = new Planet();
            brettopia.Name = "Brettopia";
            brettopia.Location = "Alpha";

            var kathaven = new Planet();
            brettopia.Name = "Kathaven";
            brettopia.Location = "Alpha";

            var libraria = new Planet();
            brettopia.Name = "Libraria";
            brettopia.Location = "Alpha";


            // SpacePort creation

            var spacePortBrettopia = new SpacePort();
            spacePortBrettopia.Name = "Space Port Brettopia";
            spacePortBrettopia.Location = "Brettopia";

            var spacePortKathaven = new SpacePort();
            spacePortBrettopia.Name = "Space Port Kathaven";
            spacePortBrettopia.Location = "Brettopia";

            var spacePortLibraria = new SpacePort();
            spacePortBrettopia.Name = "Space Port Libraria";
            spacePortBrettopia.Location = "Brettopia";



            // Instance Creation




            // Travel/Map Creation

            var travel = new Travel();
            var universeMap = new UniverseMap();
            var playerMap = new PlayerMap();

                    // Alpha Maps
            var alphaMap = new Map();
            alphaMap.Name = "Alpha";  // this is the null exception right here
            alphaMap.SolarSystem.Add(alpha); // this probably, name should be fine.  Did you new up a list before adding a solarsystem?
            alphaMap.JumpGates.Add(jumpGateAlpha);  // shit that is probably it.  Forgot I had to new up those damn lists
            alphaMap.Planets.Add(brettopia); // as a matter of practice I generally just new up a list whenever I make the property.  There is very rarely ever a good reason to have a null list.  A collection is generally empty or not.  I wish they built it into the language actually.
            alphaMap.Planets.Add(kathaven);
            alphaMap.Planets.Add(libraria);
            alphaMap.SpacePorts.Add(spacePortBrettopia);
            alphaMap.SpacePorts.Add(spacePortKathaven);
            alphaMap.SpacePorts.Add(spacePortLibraria);

                    // Beta Maps
            var betaMap = new Map();
            betaMap.Name = "Beta";
            betaMap.SolarSystem.Add(beta);
            betaMap.JumpGates.Add(jumpGateBeta);

                    // Gamma Maps
            var gammaMap = new Map();
            gammaMap.Name = "Gamma";
            gammaMap.SolarSystem.Add(gamma);
            gammaMap.JumpGates.Add(jumpGateGamma);

            // Universe Map filled out
            universeMap.UniverseMaps.Add(alphaMap);
            universeMap.UniverseMaps.Add(betaMap);
            universeMap.UniverseMaps.Add(gammaMap);






            // Monster Creation

            var whiteMonster01 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster02 = monsterMaker.CreateWhiteMonster(player);
            var whiteMonster03 = monsterMaker.CreateWhiteMonster(player);
            var greenMonster01 = monsterMaker.CreateGreenMonster(player);
            var greenMonster02 = monsterMaker.CreateGreenMonster(player);
            var greenMonster03 = monsterMaker.CreateGreenMonster(player);
            var redMonster01 = monsterMaker.CreateRedMonster(player);
            var redMonster02 = monsterMaker.CreateRedMonster(player);
            var redMonster03 = monsterMaker.CreateRedMonster(player);

            
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

            //universeMap.EnumerateJumpGates();
            //spacePortBrettopia.SpacePortOptions(player, brettopia, travel, alpha, spacePortBrettopia);






            //Player creation part.
            playerCreater.CreatePlayer(player, stats);



            // The story begins
            story.TheBegining01(player, playerInventory, weaponMaker, playerMap, alphaMap, travel, spacePortBrettopia, alpha, brettopia, jumpGateAlpha);


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