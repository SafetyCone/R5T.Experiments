using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestTestsLibrary
{
    [TestClass]
    public class IntegerTests
    {
        /// <summary>
        /// Tests integer instances for equality.
        /// </summary>
        [TestMethod]
        public void IntegerInstanceEquality()
        {
            Assert.AreEqual(3, 3);
        }
    }
}