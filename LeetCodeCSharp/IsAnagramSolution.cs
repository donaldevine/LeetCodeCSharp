using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
/// typically using all the original letters exactly once.
/// </summary>

namespace LeetCodeCSharp
{
    public class IsAnagramSolution
    {

        public bool IsAnagram(String s, string t)
        {
            if (s.Length != t.Length) return false;

            char[] str1 = s.ToCharArray();
            char[] str2 = t.ToCharArray();
                
            Array.Sort(str1);
            Array.Sort(str2);

            return Array.Equals(str1, str2);            
        }

        public bool IsAnagramUsingFrequency(String s, String t)
        {
            if (s.Length != t.Length) return false;
            
            int[] counter = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }

            foreach(int count in counter)
            {
                if (count != 0) return false;
            }

            return true;
        }
    }
}
