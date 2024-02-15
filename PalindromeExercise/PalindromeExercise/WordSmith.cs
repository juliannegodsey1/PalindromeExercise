using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if(word == null || word.Length == 0)
            {
                return false;
            }

            string wordLowered = word.ToLower();
            string reversedString = "";

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversedString += wordLowered[i];
            }

            if (wordLowered == reversedString)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
