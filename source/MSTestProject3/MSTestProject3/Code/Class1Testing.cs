using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ClassLibrary1;
using ClassLibrary1.Tests;


namespace MSTestProject3
{
    [TestClass]
    public class Class1Testing : Class1Tests
    {
        public Class1Testing()
            : base(new Class1 { Value = Class1.ProvideValue() })
        {
        }
    }
}
