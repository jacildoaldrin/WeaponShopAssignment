using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class MyBST
    {
        BSTNode root;

        public MyBST()
        {
            root = null;
        }

        public void addWeapon(string name, int range, int damage, double weight, double cost)
        {
            Weapon newWeapon = new Weapon(name, range, damage, weight, cost);
            root = insertWorker(root, newWeapon);
        }

        private BSTNode insertWorker(BSTNode curr, Weapon newWeapon)
        {
            if (curr == null) return new BSTNode(newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) < 0) curr.weaponLeft = insertWorker(curr.weaponLeft, newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) > 0) curr.weaponRight = insertWorker(curr.weaponRight, newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) == 0) curr.quantity++;
            return curr;
        }

        
        public void displayWeapons()
        {
            inOrderTrav(root);
            Console.WriteLine();
        }

        private void inOrderTrav(BSTNode curr)
        {
            if (curr == null) return;
            inOrderTrav(curr.weaponLeft);
            Console.Write("Weapon Name: {0} \tPrice:{1} \tQuantity:{2}\n", curr.weapon.name, curr.weapon.cost, curr.quantity);
            inOrderTrav(curr.weaponRight);
        }

        
        public BSTNode search(string name)
        {
            return searchWorker(root, name);
        }

        private BSTNode searchWorker(BSTNode curr, string name)
        {
            if (curr == null) return null;
            if (curr.weapon.name == name) return curr;
            if (string.Compare(name, curr.weapon.name) < 0) curr.weaponLeft = searchWorker(curr.weaponLeft, name);
            return searchWorker(curr.weaponRight, name);
        }

        
    }
}
