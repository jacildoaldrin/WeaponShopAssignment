using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Shop
    {
        ShopWeapon root;

        public Shop()
        {
            root = null;
        }

        public void insert(string name, int range, int damage, double weight, double cost, int quantity)
        {
            Weapon newWeapon = new Weapon(name, range, damage, weight, cost);
            root = insertWorker(root, newWeapon);
        }

        private ShopWeapon insertWorker(ShopWeapon curr, Weapon newWeapon)
        {
            if (curr == null) return new ShopWeapon(newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) < 0) curr.weaponLeft = insertWorker(curr.weaponLeft, newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) > 0) curr.weaponRight = insertWorker(curr.weaponRight, newWeapon);
            if (string.Compare(newWeapon.name, curr.weapon.name) == 0) curr.quantity++;
            return curr;
        }

        
        public void inOrder()
        {
            inOrderTrav(root);
            Console.WriteLine();
        }

        private void inOrderTrav(ShopWeapon curr)
        {
            if (curr == null) return;
            inOrderTrav(curr.weaponLeft);
            Console.Write("Weapon Name: {0} \tPrice:{1} \tQuantity:{2}\n", curr.weapon.name, curr.weapon.cost, curr.quantity);
            inOrderTrav(curr.weaponRight);
        }
        /*
        public int search(int n)
        {
            return searchWorker(root, n);
        }

        public int searchWorker(BSTNode curr, int n)
        {
            if (curr == null) return -1;
            if (curr.data == n) return curr.data;
            if (n < curr.data) return searchWorker(curr.left, n);
            return searchWorker(curr.right, n);
        }

        */
    }
}
