using System;
using DesignPatterns.Structural.ProxyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class ProxyPatternTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Subject proxy = new Proxy();
            proxy.Request();
        }
    }
}
