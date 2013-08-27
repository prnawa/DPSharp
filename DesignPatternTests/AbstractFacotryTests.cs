using System;
using DesignPatterns.AbstractFactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class AbstractFacotryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client1 = new Client(new Factory1());
            client1.Run(); 
            
            var client2 = new Client(new Factory2());
            client2.Run();
        }
    }
}
