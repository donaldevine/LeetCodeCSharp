using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Given a non-empty array of integers nums, every element appears twice except for one. 
/// Find that single one. 
/// 
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// 
/// </summary>

namespace LeetCodeCSharp
{
    public class SingleNumberSolution
    {

        /// <summary>
        /// 
        /// Explanation:If we take XOR of two same bits, it will return 0.
        /// So we can XOR all bits together to find the unique number.
        /// 
        /// Time complexity : O(n). We only iterate through nums, 
        /// 
        /// so the time complexity is the number of elements in nums.
        ///         
        /// 
        /// Space complexity : O(1) .
        /// 
        /// </summary>
        /// <param name="nums">int array</param>
        /// <returns>int</returns>
        public int SingleNumber(int[] nums)
        {
            int a = 0;

            foreach (var i in nums)
            {
                a ^= i;
            }

            return a;
        }
    }
}


