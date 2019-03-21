using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Weapon
    {
        public string name;
        public int range;
        public int damage;
        public double weight;
        public double cost;
        public Weapon nextWeapon;

        public Weapon(string name, int range, int damage, double weight, double cost)
        {
            this.name = name;
            this.damage = damage;
            this.range = range;
            this.weight = weight;
            this.cost = cost;
            nextWeapon = null;
        }
    }
}
