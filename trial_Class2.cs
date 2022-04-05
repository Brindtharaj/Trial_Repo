using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_with_selenium
{
    [TestFixture]
    class Class2
    {
        [Test]
        public void initialize()
        {
            Class1 cls = new Class1();
            cls.launchurl("https://www.amazon.in");
        }
        
    }
}
