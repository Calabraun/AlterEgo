using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GameEngine.UnitTests
{
    [TestClass()]
    public class GameStateTests
    {
        [TestMethod()]
        public void AvailableItemsTest()
        {
            GameState testState = new GameState();
            ItemCollection itemsToTest = testState.AvailableItems;
            Assert.AreEqual(itemsToTest.AvailableItems[0].Name, "Alter Cross");
            Assert.AreEqual(itemsToTest.AvailableItems[0].DestroyOnUse, false);
            Assert.AreEqual(itemsToTest.AvailableItems[0].Power, "Change Realms");
            Assert.AreEqual(itemsToTest.AvailableItems[1].Name, "Health Potion");
            Assert.AreEqual(itemsToTest.AvailableItems[1].DestroyOnUse, true);
            Assert.AreEqual(itemsToTest.AvailableItems[1].Power, "Heal Player");
            Assert.AreEqual(itemsToTest.AvailableItems[2].Name, "Flash Light");
            Assert.AreEqual(itemsToTest.AvailableItems[2].DestroyOnUse, false);
            Assert.AreEqual(itemsToTest.AvailableItems[2].Power, "Illuminate Area");
        }
    }
}
