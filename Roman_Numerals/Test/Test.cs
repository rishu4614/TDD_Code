using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman_Numerals;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        public void Parse(int output, string roman)
        {
            Assert.AreEqual(output, Roman.Parse(roman));
        }
    }
}
