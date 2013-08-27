using DesignPatterns.BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests
{
    [TestClass]
    public class BuilderPatternTests
    {
        [TestMethod]
        public void Test()
        {
            var director = new Director();
            var builder1 = new Builder1();
            var builder2 = new Builder2();

            director.Construct(builder1);
            director.Construct(builder2);

            var result1 = builder1.GetResult();
            var result2 = builder2.GetResult();

            Assert.AreEqual("Part A", result1.PartOne);
            Assert.AreEqual("Part X", result2.PartOne);

            Assert.AreEqual("Part B", result1.PartTwo);
            Assert.AreEqual("Part Y", result2.PartTwo);
        }
    }
}
