using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class ShopWeapon
    {
        public Weapon weapon;
        public ShopWeapon weaponLeft, weaponRight;
        public int quantity;

        public ShopWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            quantity = 1;
            weaponLeft = null;
            weaponRight = null;
        }
    }
}
