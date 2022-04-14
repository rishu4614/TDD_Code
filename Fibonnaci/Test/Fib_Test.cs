using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonnaci;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Fib_Test
    {
        [TestCase(6,3)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(10, 4)]
       
        public void FibTest(int output, int pos)
        {
            //Arrange
            var f = new Fib();
            //Act
            var result = f.Fibb(pos);
            //Assert
            Assert.Equals(output, result);
        }
    }
}
