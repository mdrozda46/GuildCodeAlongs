using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPF.Inventory.Containers;
using RPF.Inventory.Weapons;

namespace RPG.Inventory.Tests
{
    [TestFixture]
    public class SatchelTests
    {
        [Test]
        public void CannotAddBigItem()
        {
            Satchel bag = new Satchel();
            BattleAxe axe = new BattleAxe();

            bag.AddItem(axe);

            Assert.AreEqual(0, bag.ItemCount);
        }
    }
}
