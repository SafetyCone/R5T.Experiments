using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test of double instance equality.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2.0, 2.0);
        }
    }
}
