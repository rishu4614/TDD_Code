using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizz
    {
        public static string Ask(int Number)
        {
            if (Number % 3 == 0 && Number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (Number % 3 == 0)
            {
                return "Fizz";
            }
            else if (Number % 5 == 0)
            {
                return "Buzz";
            }
            return "";
        }
    }
}
