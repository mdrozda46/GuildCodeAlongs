using System;
using System.Collections.Generic;
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
    public class ReagentPouchTests
    {
        [Test]
        public void CanNotHoldInPouch()
        {
            ReagentPouch bag = new ReagentPouch();
            Mushroom shroom = new Mushroom();
            BattleAxe axe = new BattleAxe();

            bag.AddItem(shroom);
            bag.AddItem(axe);

            Assert.AreEqual(1, bag.ItemCount);

            bag.DisplayContents();
        }
    }
}
