using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class MonsterMaker
    {
        public Monster CreateWhiteMonster(PlayerCharacter player)
        {
            Monster whiteMonster = new Monster();

            
            {
                whiteMonster.Name = "White Monster";
                whiteMonster.Level = player.Level;
                whiteMonster.Attack = (player.Attack - (player.Attack / 2));
                whiteMonster.CurrentHitPoints = (player.TotalHitPoints - (player.TotalHitPoints / 2));
                whiteMonster.TotalHitPoints = (player.TotalHitPoints - (player.TotalHitPoints / 2));
            }
            return whiteMonster;
        }

        public Monster CreateGreenMonster(PlayerCharacter player)
        {
            Monster greenMonster = new Monster();
            {
                greenMonster.Name = "Green Monster";
                greenMonster.Level = player.Level;
                greenMonster.Attack = (player.Attack - (player.Attack / 2));
                greenMonster.CurrentHitPoints = (player.TotalHitPoints);
                greenMonster.TotalHitPoints = (player.TotalHitPoints);
            }
            return greenMonster;
        }

        public Monster CreateRedMonster(PlayerCharacter player)
        {
            Monster redMonster = new Monster();
            {
                redMonster.Name = "Red Monster";
                redMonster.Level = player.Level;
                redMonster.Attack = (player.Attack - (player.Attack / 2));
                redMonster.CurrentHitPoints = (player.TotalHitPoints + (player.TotalHitPoints / 2));
                redMonster.TotalHitPoints = (player.TotalHitPoints + (player.TotalHitPoints / 2));
            }
            return redMonster;
        }
    }
}
