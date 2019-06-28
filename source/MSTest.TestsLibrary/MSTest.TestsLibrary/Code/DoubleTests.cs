using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTest.TestsLibrary
{
    [TestClass]
    public class DoubleTests
    {
        /// <summary>
        /// Tests the equality of two double instances.
        /// </summary>
        [TestMethod]
        public void InstanceEquality()
        {
            Assert.AreEqual(2.0, 2.0);
        }
    }
}
