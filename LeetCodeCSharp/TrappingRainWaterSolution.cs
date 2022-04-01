using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given n non-negative integers representing an elevation map where the width of each bar is 1, 
/// compute how much water it can trap after raining.
/// </summary>

namespace LeetCodeCSharp
{
    public class TrappingRainWaterSolution
    {
        public int Trap(int[] height)
        {

            int n = height.Length;

            if (n == 0) return 0;

            int ans = 0;

            int left = 0;
            int right = n - 1;

            int maxLeft = 0;
            int maxRight = 0;

            //pointers
            while (left < right)
            {
                //store the maximum height from left
                if (height[left] > maxLeft) maxLeft = height[left];
                //store the maximum height from right
                if (height[right] > maxRight) maxRight = height[right];

                if (maxLeft < maxRight)
                {
                    //if the height of the current item is less than max left, the difference is the ans
                    if (height[left] < maxLeft) ans += maxLeft - height[left];
                    left++; //move on
                }
                else
                {
                    if (height[right] < maxRight) ans += maxRight - height[right];
                    right--;
                }
            }

            return ans;
        }
    }
}
