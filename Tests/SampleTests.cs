using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;

            Assert.AreEqual(a, b);
        }
    }
}
