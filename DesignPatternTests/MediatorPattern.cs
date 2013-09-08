using System;
using DesignPatterns.Behavioral.MediatorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class MediatorPattern
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague(mediator);
            var colleague2 = new ConcreteColleague(mediator);

            mediator.AddColleague(colleague1);
            mediator.AddColleague(colleague2);

            colleague1.Send("form C1");
            colleague2.Send("from C2");

        }
    }
}
