using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    internal class IPv4_Validation
    {
        public static bool IsValidIP(string IP)
        {
            string[] arr = IP.Split('.');
            if (arr.Length != 4) { return false; }
            if (arr.Any(c => {
                if (c.IndexOf('0') == 0) { return true; }
                if (c.IndexOf(' ') > -1) { return true; }
                int num;
                if (Int32.TryParse(c, out num))
                {
                    if (num > 255 || num < 0) { return true; }
                }
                else { return true; }
                
                return false;
            })) { return false; }
            return true;
        }
    }
}
