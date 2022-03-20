using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array, 
/// and return false if every element is distinct.
/// </summary>
/// 
namespace LeetCodeCSharp
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (set.Contains(num)) return true;
                
                set.Add(num);
            }

            return false;
        }
    }
}
