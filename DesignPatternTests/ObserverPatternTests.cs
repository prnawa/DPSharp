using System;
using DesignPatterns.Behavioral.ObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class ObserverPatternTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver(subject);
            var observer2 = new ConcreteObserver(subject);

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.State = "NEW";

            subject.Notify();

            Assert.AreEqual(subject.State, observer1.State);
            Assert.AreEqual(subject.State, observer2.State);
        }
    }
}
