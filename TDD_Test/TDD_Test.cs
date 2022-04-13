using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD_Code;

namespace TDD_Test
{
    [TestFixture]
    public class TDD_Test
    {
        [Test]
        public void ParsePort_COM1_Return1()
        {
            int result = SerialPortParser.ParsePort("COM567");        // result stores the port_number 
            Assert.That(result, Is.EqualTo(567));                      // comparing the value of result and port_number(567)
        }

        [Test]
        public void ParsePort_InvalidFormat_ThrowInvalidFormatException()
        {
            TestDelegate action = () => SerialPortParser.ParsePort("1");       //it throws the invalid format exception
            Assert.Throws<FormatException>(action);
        }

    }
}
