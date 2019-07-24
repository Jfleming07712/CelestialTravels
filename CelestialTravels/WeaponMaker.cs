using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels
{
    public class WeaponMaker
    {
        string temporaryWeaponNameVariable;

        public void CreateWeaponBlaster(Inventory playerInventory)
        {
            var blaster = new Weapon();
            blaster.Type = "Blaster";
            blaster.Name = NameWeapon();
            blaster.Attack = 10;
            blaster.Durability = 100;
            blaster.Equiped = false;

           playerInventory.WeaponList.Add(blaster);
        }

        public void CreateWeaponDoubleBlaster(Inventory playerInventory)
        {
            var doubleBlaster = new Weapon();
            doubleBlaster.Type = "Double Blaster";
            doubleBlaster.Name = NameWeapon();
            doubleBlaster.Attack = 20;
            doubleBlaster.Durability = 75;
            doubleBlaster.Equiped = false;

            playerInventory.WeaponList.Add(doubleBlaster);
        }

        public void CreateWeaponPhotonSword(Inventory playerInventory)
        {
            var photonSword = new Weapon();
            photonSword.Type = "PhotonSword";
            photonSword.Name = NameWeapon();
            photonSword.Attack = 30;
            photonSword.Durability = 50;
            photonSword.Equiped = false;

            playerInventory.WeaponList.Add(photonSword);
        }

        public string NameWeapon()
        {

            Console.WriteLine("Please name your new weapon");
            temporaryWeaponNameVariable = Console.ReadLine();
            Console.WriteLine("\n");
            return temporaryWeaponNameVariable;
        }
    }
}
