using System;
using DesignPatterns.Behavioral.CommandPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatternTests
{
    [TestClass]
    public class CommandPatternTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var receiverMoq = new Mock<Receiver>();
            var command = new ConcreteCommand(receiverMoq.Object);
            var invorker = new Invoker();
            invorker.SetCommand(command);

            invorker.ExecuteCommand();

            receiverMoq.Verify(r => r.Action(), Times.Exactly(1));
        }
    }
}
