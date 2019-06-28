using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ClassLibrary1.Tests
{
    [TestClass]
    public abstract class Class1Tests
    {
        private IClass1 Class1 { get; }


        public Class1Tests(IClass1 class1)
        {
            this.Class1 = class1;
        }


        /// <summary>
        /// Test that the provided value is correct.
        /// </summary>
        [TestMethod]
        public void ProvidedValueIsCorrect()
        {
            var value = this.Class1.Value;

            var expected = "The Value";

            Assert.AreEqual(expected, value);
        }
    }
}
