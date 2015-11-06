﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPF.Inventory.Base;

namespace RPF.Inventory.Weapons
{
    public class BattleAxe : Item
    {
        public BattleAxe()
        {
            Name = "A giant steel battleaxe";
            Description = "For the glory of Krong!";
            Weight = 10;
            Value = 250;
            Type = ItemType.Weapon;
        }
    }
}
