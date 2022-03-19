using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class BinarySearchSolution
    {

        public int Search(int[] nums, int target)
        {
            if(nums.Length < 1) return - 1;

            int left = 0;

            int right = nums.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target) left = mid + 1;
                if (nums[mid] > target) right = mid - 1;
            }

            return -1;
        }
    }
}
