using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given two strings s and t, determine if they are isomorphic.
/// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
/// All occurrences of a character must be replaced with another character while preserving the order of characters. 
/// No two characters may map to the same character, but a character may map to itself.
/// </summary>

namespace LeetCodeCSharp
{
    public class IsomorphicStringsSolution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            //uniquely store character from s and matching character from t
            Dictionary<char, char> dic = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i])) //repeating character
                {
                    //does the character at t[i] match the value for the key of the s character at the same location?
                    if (dic[s[i]] != t[i]) return false;
                }
                else
                {
                    //t[i] would only be a value if it was already added, if it is found return false;
                    if (dic.ContainsValue(t[i])) return false;
                    dic.Add(s[i], t[i]);
                }
            }

            return true;
        }

    }
}
