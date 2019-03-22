using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Player
    {
        public string name;
        public Backpack backpack;
        public double money;
        public double maxWeight;

        public Player(string name, double money, double maxWeight)
        {
            this.name = name;
            this.money = money;
            this.maxWeight = maxWeight;
            backpack = new Backpack(maxWeight);
        }

        public void buyWeapon(Weapon w)
        {
            backpack.addWeapon(w);
        }
        public void withdraw(double amt)
        {
            money -= amt;
        }

        public bool inventoryFull()
        {
            return backpack.presentWeight == maxWeight;
        }


        public void printCharacter()
        {
            Console.WriteLine("----- DISPLAYING PLAYER INFO -----");
            Console.WriteLine("\nPlayer Name: {0}\nMoney: {1}\nMax Weight: {2}\n", name, money, maxWeight);
            printBackpack();
        }

        public void printBackpack()
        {
            Console.WriteLine(name + ", your backpack weighs " + backpack.presentWeight + "\nWeapons:");
            backpack.listWeapons();
        }
    }
}
