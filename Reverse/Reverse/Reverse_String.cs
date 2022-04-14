using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Reverse_String
    {
        public char[] Reverse_Me(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return arr;
        }

    }
}
