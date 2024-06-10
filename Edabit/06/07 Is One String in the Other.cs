using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Edabit._06
{
    internal static class _07_Is_One_String_in_the_Other
    {
        public static bool Overlap(string str1, string str2)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            string inner = str1, outer = str2;
            if (str1.Length >= str2.Length) { 
                inner = str2; 
                outer = str1;  
            }
            outer = outer.Substring(outer.Length - inner.Length);
            for (int i = 0; i < outer.Length; i++) {
                if (outer[i] != inner[i] && outer[i] != '*' || inner[i] != '*') { 
                    return false; 
                }
            }
            
            return true;
        }
    }
}
