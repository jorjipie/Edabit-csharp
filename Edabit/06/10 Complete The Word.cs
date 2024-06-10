using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://edabit.com/challenge/MadJvJMQhr5JYrTCt

namespace Edabit._06
{
    internal class _10_Complete_The_Word
    {
        public static bool CanComplete(string initial, string word)
        {
            int charIndex = -1;
            for (int i = 0; i < initial.Length; i++)
            {
                charIndex = word.IndexOf(initial[i]); 
                if (charIndex == -1) { return false; }
                word = word.Substring(charIndex + 1);
            }
            return true;
        }
    }
}
