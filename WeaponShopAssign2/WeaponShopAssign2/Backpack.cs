using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    class Backpack
    {
        public BackpackNode head;
        public double maxWeight;
        public double presentWeight;

        public Backpack(double maxWeight)
        {
            head = null;
            this.maxWeight = maxWeight;
            presentWeight = 0;
        }
        
        public bool addWeapon(Weapon newWeapon)
        {
            if(presentWeight + newWeapon.weight <= maxWeight)
            {
                if (head == null)
                {
                    head = new BackpackNode(newWeapon);
                }
                else
                {
                    BackpackNode curr = head;
                    while (curr.next != null)
                    {
                        curr = curr.next;
                    }
                    curr.next = new BackpackNode(newWeapon);
                }
                presentWeight += newWeapon.weight;
                return true;
            }
            else
            {
                Console.WriteLine("\nYou're going to exceed the weight limit, please discard an item before you add this one!\n");
                return false;
            }
        }

        public void listWeapons()
        {
            BackpackNode curr = head;
            while(curr != null)
            {
                Console.WriteLine(curr.weapon.name);
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }
}
