using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPF.Inventory.Containers;
using RPF.Inventory.Reagents;
using RPF.Inventory.Weapons;

namespace RPG.Inventory.Tests
{

    [TestFixture]
    public class BackpackTests
    {
        [Test]
        public void PutItemsInBackPackTest()
        {
            Backpack bag = new Backpack();
            Mushroom shroom = new Mushroom();
            Cloth cloth = new Cloth();
            BattleAxe axe = new BattleAxe();

            bag.AddItem(shroom);
            bag.AddItem(cloth);
            bag.AddItem(axe);

            Assert.AreEqual(3, bag.ItemCount);

            bag.DisplayContents();
        }
    }
}
