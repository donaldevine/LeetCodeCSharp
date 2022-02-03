using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {

            s = s.Trim().ToLower();

            var charArray = s.ToCharArray();

            var charArrayAlphaNumeric = Array.FindAll(charArray, Char.IsLetterOrDigit);

            var s2 = new String(charArrayAlphaNumeric);

            Array.Reverse(charArrayAlphaNumeric);

            var r2 = new String(charArrayAlphaNumeric);

            if (s2 == r2) return true;

            return false;

        }
    }
}
