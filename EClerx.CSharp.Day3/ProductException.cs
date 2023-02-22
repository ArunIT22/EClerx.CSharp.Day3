using System;

namespace EClerx.CSharp.Day3
{
    public class ProductException : ApplicationException
    {
        public ProductException():base()
        {

        }

        public ProductException(string message) : base(message) { }
    }
}
