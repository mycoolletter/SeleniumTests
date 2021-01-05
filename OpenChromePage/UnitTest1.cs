using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenChromePage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int firstValue = 3;
            int secondValue = 2;
            Assert.IsTrue(5 == firstValue + secondValue);
           
        }
    }
}
