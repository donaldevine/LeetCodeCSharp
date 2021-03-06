using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
/// and removing all non-alphanumeric characters, 
/// it reads the same forward and backward. Alphanumeric characters include letters and numbers.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// </summary>
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

        public bool IsPalindrome2(string s) {
            var n = s.Length;
            var left = 0;
            var right = n - 1;

            while (left < right) {
                if (!char.IsLetterOrDigit(s[left])) {
                    left++;
                } else if (!char.IsLetterOrDigit(s[right])) {
                    right--;
                } else {
                    if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                        return false;
                    }
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
