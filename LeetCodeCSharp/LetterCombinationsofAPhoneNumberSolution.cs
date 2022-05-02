using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given a string containing digits from 2-9 inclusive, 
/// return all possible letter combinations that the number could represent. 
/// Return the answer in any order.
/// A mapping of digit to letters (just like on the telephone buttons) is given below. 
/// 2 = abc
/// 3 = def
/// 4 = ghi
/// 5 = jkl
/// 6 = mno
/// 7 = pqrs
/// 8 = tuv
/// 9 = wxyz
/// Note that 1 does not map to any letters.
/// 
/// Time complexity: O(4^N . N), where N is the length of digits. 
/// 4 in this expression is the maximum value length in the hash map, not to the length of the input.
/// 
/// 
/// Space complexity: O(N) - where N is the length of digits.
/// </summary>

namespace LeetCodeCSharp
{
    public class LetterCombinationsofAPhoneNumberSolution
    {

        List<string> combinations = new List<string>();


        private Dictionary<char, string> _letters = new Dictionary<char, string> { 
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs"},
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        private string phoneDigits = "";

        public IList<string> LetterCombinations(string digits)
        {

            if (String.IsNullOrEmpty(digits)) return combinations;

            // Initiate backtracking with an empty path and starting index of 0
            phoneDigits = digits;
            backtrack(0, new StringBuilder());
            return combinations;
        }

        private void backtrack(int index, StringBuilder path)
        {
            // If the path is the same length as digits, we have a complete combination
            if (path.Length == phoneDigits.Length)
            {
                combinations.Add(path.ToString());
                return;
            }

            // Get the letters that the current digit maps to, and loop through them
            string possibleLetters = _letters[phoneDigits[index]];

            foreach (var c in possibleLetters)
            {
                // Add the letter to our current path
                path.Append(c);

                // Move on to the next digit
                backtrack(index + 1, path);

                // Backtrack by removing the letter before moving onto the next
                path.Remove(path.Length - 1, 1);
            }

        }
    }
}
