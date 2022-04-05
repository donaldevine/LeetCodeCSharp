using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class LongestIncreasingSubsequenceSolution
    {
        public int lengthOfLIS(int[] nums)
        {
            //DP Solution

            //Initialize DP array with size nums.Length and set all the fields to 1
            //Fill the array with 1 as each indipendent nums element is itself a longest increasing subsequence
            
            int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();

            //Iterate through entire array and determine for each element if it's a part of longest increasing subsequence
            //DP[i] represents longest increasing subsequence ending to element nums[i]
            //Start iterating from index 1 leaving length of first element dp[0] to 1
            for (int i = 1; i < nums.Length; i++)
            {
                //Iterate through all the elements prior to current element to check if current element is in an increasing sequence
                //For current element to be in an increasing sequence, all the prior elements from nums[0] t0 nums[i-1] should be less than nums[i]
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            //Find longest increasing subsequence from DP
            int longest = 0;
            foreach (int elementLength in dp)
            {
                longest = Math.Max(elementLength, longest);
            }
            return longest;
        }
                        
    }
}
