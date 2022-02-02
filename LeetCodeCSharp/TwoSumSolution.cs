using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int arrayLength = nums.Length;

            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

            if (nums == null || arrayLength < 2)
            {
                return new int[] { };
            }


            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;

                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i };
                }

                resultDictionary[firstNumber] = i;
            }

            return new int[] { };
        }
    }
}
