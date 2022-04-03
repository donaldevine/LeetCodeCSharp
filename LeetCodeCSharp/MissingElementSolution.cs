using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an integer array nums which is sorted in ascending order 
/// and all of its elements are unique and given also an integer k, 
/// return the kth missing number starting from the leftmost number of the array.
/// 
/// Input: nums = [4,7,9,10], k = 1
/// 
/// Output: 5
/// 
/// Explanation: The first missing number is 5.
/// 
/// </summary>

namespace LeetCodeCSharp
{
    public class MissingElementSolution
    {
        public int MissingElement(int[] nums, int k)
        {

            int n = nums.Length;

            if (n == 0) return 0;

            for (int i = 1; i < n; i++)
            {
                //get the difference between current and previous items
                int diff = nums[i] - nums[i - 1] - 1;

                //if the difference is greater than or equal to k return k + value of previous item
                if (diff >= k) return nums[i - 1] + k;

                //reduce k by diffences found
                k -= diff;
            }

            //missing number at the end, so get last item and add k
            return nums[n - 1] + k;
        }
    }
}
