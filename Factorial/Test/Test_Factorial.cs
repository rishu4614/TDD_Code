using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorial;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test_Factorial
    {
        
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(120, 5)]
        public void Fact(int output, int number)
        {
            var f = new Fact();
            var result = f.GetFactorial(number);
            Assert.AreEqual(output, result);

        }

        
    }
}
