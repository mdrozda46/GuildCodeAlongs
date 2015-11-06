using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPF.Inventory.Base;

namespace RPF.Inventory.Containers
{
    public class Satchel : Container
    {
        public Satchel() : base(4)
        {
            Name = "A small cloth satchel";
            Description = string.Format("This is can carry your knick knacks");
            Weight = 1;
            Value = 50;
        }

        public override void AddItem(Item itemToAdd)
        {
            if (itemToAdd.Weight > 1)
            {
                Console.WriteLine("That is way too big for the satchel!");
            }
            else
            {
                base.AddItem(itemToAdd);
            }
        }
    }
}
