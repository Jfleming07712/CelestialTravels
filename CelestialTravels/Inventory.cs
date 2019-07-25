using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Inventory
    {




        public List<Weapon> WeaponList = new List<Weapon>();

        public void WeaponEnumerator()
        {
            foreach (Weapon weapon in WeaponList)
            {
                Console.WriteLine((WeaponList.IndexOf(weapon) + ")  " + (weapon.Type) + " " + (weapon.Name) + " Atk =" + (weapon.Attack) + "  Durability =" + (weapon.Durability)));
            }
        }

       
    }
}
