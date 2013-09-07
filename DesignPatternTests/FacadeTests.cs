using System;
using DesignPatterns.Structural.FacadePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatternTests
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockSubSystemA = new Mock<SubSystemA>();
            var mockSubSystemB = new Mock<SubSystemB>();
            var mockSubSystemC = new Mock<SubSystemC>();

            mockSubSystemA.Setup(m => m.MethodA());
            mockSubSystemB.Setup(m => m.MethodB());
            mockSubSystemC.Setup(m => m.MethodC());

            var facade = new Facade(mockSubSystemA.Object, mockSubSystemB.Object, mockSubSystemC.Object);

            facade.MethodOne();
            facade.MethodTwo();

            mockSubSystemA.Verify(r => r.MethodA(), Times.Exactly(1));
            mockSubSystemB.Verify(r => r.MethodB(), Times.Exactly(1));
            mockSubSystemC.Verify(r => r.MethodC(), Times.Exactly(2));

        }
    }
}
