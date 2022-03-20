using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an array of strings strs, group the anagrams together. 
/// You can return the answer in any order.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
/// typically using all the original letters exactly once.
/// </summary>

namespace LeetCodeCSharp
{
    public class GroupAnagramsSolution
    {
		public IList<IList<string>> GroupAnagram(string[] strs)
		{
			Dictionary<string, List<string>> containingNames = new Dictionary<string, List<string>>();

			if (strs.Length == 0)
				return containingNames.Values.ToArray();

			for (int i = 0; i < strs.Length; i++)
			{
				char[] chArr = strs[i].ToCharArray();
				Array.Sort(chArr);
				string sortedStr = new string(chArr);

				if (!containingNames.ContainsKey(sortedStr))
					containingNames.Add(sortedStr, new List<string>() { strs[i] });
				else
					containingNames[sortedStr].Add(strs[i]);
			}
			return containingNames.Values.ToArray();
		}
	}
}
