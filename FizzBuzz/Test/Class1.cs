using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 6)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("", 7)]
        public void Test(string output, int number)
        {
            Assert.AreEqual(output, Fizz.Ask(number));
        }
    }
}
