using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class Inventory
    {
        List<Weapon> WeaponList = new List<Weapon>();

        public void CreateWeaponBlaster()
        {
            var blaster = new Weapon();
            blaster.Name = "Blaster";
            blaster.Attack = 5;
            blaster.Equiped = false;
            WeaponList.Add(blaster);
        }

        public void CreateWeaponDoubleBlaster()
        {
            var doubleBlaster = new Weapon();
            doubleBlaster.Name = "Double Blaster";
            doubleBlaster.Attack = 10;
            doubleBlaster.Equiped = false;
            WeaponList.Add(doubleBlaster);
        }

        public void CreateWeaponPhotonSword()
        {
            var photonSword = new Weapon();
            photonSword.Name = "PhotonSword";
            photonSword.Attack = 15;
            photonSword.Equiped = false;
            WeaponList.Add(photonSword);
        }
    }
}
