using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeConverter
{
    public class Degree_Converter
    {
        public double ToFehrenhite(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public double ToCelsius(double fahrenhite)
        {
            return (32 * fahrenhite - 32) * 5 / 9;
        }
    }
}
