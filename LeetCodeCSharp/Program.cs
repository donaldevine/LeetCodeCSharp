using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSumSolution twoSumSolution = new TwoSumSolution();

            int[] nums = { 2, 7, 11, 15 };

            var twoSumResult = twoSumSolution.TwoSum(nums, 9);

            Console.WriteLine("[{0}]", string.Join(", ", twoSumResult));


            Console.ReadLine();
        }
    }
}
