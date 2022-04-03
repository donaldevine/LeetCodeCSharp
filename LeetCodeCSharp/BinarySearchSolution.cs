using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an array of integers nums which is sorted in ascending order,
/// and an integer target, write a function to search target in nums.
/// If target exists, then return its index. Otherwise, return -1.
/// You must write an algorithm with O(log n) runtime complexity.
/// 
/// Input: nums = [-1,0,3,5,9,12], target = 9
/// 
/// Output: 4
/// 
/// Explanation: 9 exists in nums and its index is 4
/// 
/// </summary>


namespace LeetCodeCSharp
{
    public class BinarySearchSolution
    {

        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;

            var l = 0; //low index

            var h = nums.Length - 1; //high index

            while (l <= h)
            {
                //get mid/pivot point between lower and higher indexes
                var m = (l + h) / 2;

                if (nums[m] == target) return m;

                // if the target is higher than mid point, move lower up past mid point
                if (nums[m] < target) l = m + 1;

                // if the target is lower move higher down.
                if (nums[m] > target) h = m - 1;
            }

            return -1;
        }
    }
}
