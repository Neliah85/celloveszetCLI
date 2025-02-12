using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;  

namespace CelloveszetCLI.Tests
{
    [TestClass]  
    public class ShootingResultTests
    {
        
        [TestMethod]
        public void TestGetMaxShot()
        {
            
            var shooter1 = new ShootingResult("John", "22", "29", "12", "23");
            var shooter2 = new ShootingResult("Alice", "16", "45", "87", "33");
            var shooter3 = new ShootingResult("Bob", "96", "49", "67", "45");
            var shooter4 = new ShootingResult("Eve", "44", "3", "12", "77");

            
            Assert.AreEqual(29, shooter1.GetMaxShot(), "A legnagyobb lövésnek 29-nek kell lennie");
            Assert.AreEqual(87, shooter2.GetMaxShot(), "A legnagyobb lövésnek 87-nek kell lennie");
            Assert.AreEqual(96, shooter3.GetMaxShot(), "A legnagyobb lövésnek 96-nak kell lennie");
            Assert.AreEqual(77, shooter4.GetMaxShot(), "A legnagyobb lövésnek 77-nek kell lennie");
        }

       
        [TestMethod]
        public void TestGetAverage()
        {
            
            var shooter1 = new ShootingResult("John", "22", "29", "12", "23");

           
            var average = shooter1.GetAverage();

            
            Assert.AreEqual(21.5, average, 0.1, "Az átlagos pontszámnak 21.5 körülinek kell lennie");
        }
    }
}
