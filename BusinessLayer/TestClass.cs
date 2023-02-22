using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public sealed class TestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestClass2
    {
        public void Method()
        {
            TestClass obj = new TestClass();
        }
    }
}
