using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
   public class Fib
    {
        public long Fibb(int position)
        {
            if (position == 1 || position == 2)
            {
                return 1;
            }

            int fib1 = 1;
            int fib2 = 1;
            int result = -1;

            for (int i = 3; i <= position; i++)
            {
                result = fib1 + fib2;
                fib1 = fib2;
                fib2 = result;
            }

            return result;
        }
    }
}
