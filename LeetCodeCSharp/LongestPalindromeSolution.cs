using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class LongestPalindromeSolution
    {
        public string LongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) return "";

            var longest = s.Substring(0, 1);

            for (int i = 0; i < s.Length; i++)
            {
                var temp = expand(s, i, i);
                if (temp.Length > longest.Length) longest = temp;

                temp = expand(s, i, i + 1);

                if (temp.Length > longest.Length) longest = temp;
            }

            return longest;
        }


        private string expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return s.Substring(left + 1, right - (left + 1));
        }
    }
}
