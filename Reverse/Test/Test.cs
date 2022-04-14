using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reverse;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [TestCase("FEDCBA", "ABCDEF")]
        [TestCase("WERT", "RISHABH")]
        public void Test_reverse(string output, string input)
        {
            var rev = new Reverse_String();
            var result = rev.Reverse_Me(input);
            Assert.AreEqual(output, result);
        }
    }
}
