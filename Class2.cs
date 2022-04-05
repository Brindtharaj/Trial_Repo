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
            var v1 = new Class1();
            v1.launchurl("https://www.irctc.co.in/nget/train-search");
        }
        [Test]
        public void alrt()
        {
            var v2 = new Class1();
            v2.clickalert();
        }
    }
}
