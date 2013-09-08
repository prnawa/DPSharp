using System;
using DesignPatterns.Structural.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class DecoratorPatternTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var component = new ConcreteComponent();
            var decoratorA = new ConcreateDecoratorA();
            var decoratorB = new ConcreateDecoratorB();
            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();
        }
    }
}
