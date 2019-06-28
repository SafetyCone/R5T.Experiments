using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public const string ValueValue = "The Value";


        #region Static

        public static string ProvideValue()
        {
            return Class1.ValueValue;
        }

        #endregion


        public string Value { get; set; }


        public Class1()
        {
        }

        public Class1(string value)
        {
            this.Value = value;
        }
    }
}
