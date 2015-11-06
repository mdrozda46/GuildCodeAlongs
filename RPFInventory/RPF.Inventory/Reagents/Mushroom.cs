﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPF.Inventory.Base;

namespace RPF.Inventory.Reagents
{
    public class Mushroom : Item 
    {
        public Mushroom()
        {
            Name = "A red mushroom with white spots";
            Description = "Makes you grow larger";
            Weight = 0;
            Value = 1;
            Type = ItemType.Reagent;
        }
    }
}
