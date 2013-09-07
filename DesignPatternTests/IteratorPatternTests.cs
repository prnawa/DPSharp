using System;
using DesignPatterns.Behavioral.IteratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class IteratorPatternTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var aggregate = new ConcreteAggregate();
            const string itm1 = "item 1";
            const string itm2 = "item 2";
            const string itm3 = "item 3";
            const string itm4 = "item 4";

            aggregate[0] = itm1;
            aggregate[1] = itm2;
            aggregate[2] = itm3;
            aggregate[3] = itm4;

            Iterator iterator = aggregate.CreateIterator();

            object item1 = iterator.First();
            object item2 = iterator.Next();
            object item3 = iterator.Next();
            object item4 = iterator.Next();
            object currentItem = iterator.CurrentItem();
            bool isDone1 = iterator.IsDone();

            Assert.AreEqual(itm1, item1);
            Assert.AreEqual(itm2, item2);
            Assert.AreEqual(itm3, item3);
            Assert.AreEqual(itm4, item4);
            Assert.AreEqual(currentItem, item4);
            Assert.IsTrue(isDone1);
        }
    }
}
