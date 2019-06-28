using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestProject1.Lib
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Test of empty string instance equality.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(String.Empty, String.Empty);
        }
    }
}
