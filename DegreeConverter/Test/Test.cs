using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DegreeConverter;
using NUnit.Framework;


namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ToFehrenheite_ZeroCelcius_Return32()
        {
            Degree_Converter convert = new Degree_Converter();
            double result = convert.ToFehrenhite(0);
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void ToCelcius_1Fahrenhite_Return0()
        {
            Degree_Converter convert = new Degree_Converter();
            double result = convert.ToFehrenhite(1);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
