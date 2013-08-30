using System;
using DesignPatterns.Creational.FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var creator1 = new CreatorA();
            var creator2 = new CreatorB();

            Product product1 = creator1.FatoryMethod();
            Product product2 = creator2.FatoryMethod();

            Assert.AreEqual(typeof(ProductA), product1.GetType());
            Assert.AreEqual(typeof(ProductB), product2.GetType());
        }
    }
}
