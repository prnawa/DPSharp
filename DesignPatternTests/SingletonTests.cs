using System;
using DesignPatterns.Creational.SingletonPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Double_CheckLocking = DesignPatterns.Creational.SingletonPattern.Double_CheckLocking;
using StaticInitilization = DesignPatterns.Creational.SingletonPattern.StaticInitialization;

namespace DesignPatternTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void NonThreadSafe()
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            Assert.IsNotNull(instance1);
            Assert.IsNotNull(instance2);
            Assert.AreEqual(instance1, instance2);
        }

        [TestMethod]
        public void ThreadSafeDoubleCheckLocking()
        {
            Double_CheckLocking.Singleton instance1 = Double_CheckLocking.Singleton.Instance();
            Double_CheckLocking.Singleton instance2 = Double_CheckLocking.Singleton.Instance();

            Assert.IsNotNull(instance1);
            Assert.IsNotNull(instance2);
            Assert.AreEqual(instance1, instance2);
        }

        [TestMethod]
        public void ThreadSafeStaticInitilization()
        {
            StaticInitilization.Singleton instance1 = StaticInitilization.Singleton.Instance();
            StaticInitilization.Singleton instance2 = StaticInitilization.Singleton.Instance();

            Assert.IsNotNull(instance1);
            Assert.IsNotNull(instance2);
            Assert.AreEqual(instance1, instance2);
        }
    }
}
