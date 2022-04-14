using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class Roman
    {
        private static readonly Dictionary<char, int> Link = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V',5},
            {'X',10 },
            {'L',50 },
            {'C',1000 },
            {'D',5000 },
            {'M',1000 },
        };
        public static int Parse(string roman)
        {
            int result = 0;
            for(int i =0; i<roman.Length; ++i)
            {
                if(i+1 < roman.Length && IsSubtractive(roman[i], roman[i+1]))
                {
                    result -= Link[roman[i]];
                }
                else
                {
                    result += Link[roman[i]];
                }
                
            }
            return result;
        }

        private static bool IsSubtractive(char c1, char c2)
        {
            return Link[c1] < Link[c2];
        }
    }
}
