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
            Builder builder = null;

            builder = new Builder1();
            director.Construct(builder);
            var result1 = builder.GetResult();

            builder = new Builder2();
            director.Construct(builder);
            var result2 = builder.GetResult();

            Assert.AreEqual("Part A", result1.PartOne);
            Assert.AreEqual("Part B", result1.PartTwo);

            Assert.AreEqual("Part X", result2.PartOne);
            Assert.AreEqual("Part Y", result2.PartTwo);
        }
    }
}
