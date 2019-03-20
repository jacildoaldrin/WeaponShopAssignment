using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    class Backpack
    {
        public Weapon weapon;
        public double maxWeight;
        public double presentWeight;

        public Backpack(double maxWeight)
        {
            weapon = null;
            this.maxWeight = maxWeight;
            presentWeight = 0;
        }
        
        public void addWeapon(Weapon newWeapon)
        {
            if(presentWeight + newWeapon.weight <= maxWeight)
            {
                if (weapon == null)
                {
                    weapon = newWeapon;
                }
                else
                {
                    Weapon curr = weapon;
                    while (curr.nextWeapon != null)
                    {
                        curr = curr.nextWeapon;
                    }
                    curr = weapon;
                }
                presentWeight += newWeapon.weight;
                return;
            }
            else
            {
                Console.WriteLine("\nYou're going to exceed the weight limit, please discard an item before you add this one!\n");
                return;
            }
        }

        public void listWeapons()
        {
            Weapon curr = weapon;
            while(curr.nextWeapon != null)
            {
                Console.WriteLine(curr.weaponName);
                curr = curr.nextWeapon;
            }
            Console.WriteLine();
        }
    }
}
