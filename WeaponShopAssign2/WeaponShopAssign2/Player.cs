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

        public void buy(Weapon w)
        {
            Console.WriteLine(w.weaponName+" bought...");
            backpack.addWeapon(w);
            Console.Write(backpack.presentWeight);
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
            Console.WriteLine(" Name:"+name+"\n Money:"+money);
            printBackpack();
        }

        public void printBackpack()
        {
            Console.WriteLine(name + ", your backpack weighs " + backpack.presentWeight + " Weapons:");
            backpack.listWeapons();
        }
    }
}
