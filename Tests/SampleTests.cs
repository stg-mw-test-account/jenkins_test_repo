using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void PositiveTest()
        {
            int a = 1;
            int b = 1;

            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void NegativeTest()
        {
            int a = 1;
            int b = 2;

            Assert.AreEqual(a, b);
        }
    }
}
