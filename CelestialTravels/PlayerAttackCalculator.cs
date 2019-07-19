using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class PlayerAttackCalculator
    {
        public static void CalculatePlayerAttack(PlayerCharacter player)
        {
            player.Attack = (player.CurrentWeaponDamage) * (player.WeaponSkill);
        }
    }
}
