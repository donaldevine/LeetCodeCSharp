using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n)).  
/// 
/// Input: nums1 = [1,3], nums2 = [2]
/// 
/// Output: 2.00000
/// 
/// Explanation: merged array = [1, 2, 3] and median is 2.
/// 
/// </summary>
namespace LeetCodeCSharp
{
    
    public class FindMedianSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int[] combined = nums1.Concat(nums2).OrderBy(x => x).ToArray();

            int combinedLength = combined.Length;

            int mid = combinedLength / 2;

            if (combinedLength % 2 == 0)
            {
                return ((double)(combined[mid - 1] + combined[mid])) / 2;
            }
            else
            {
                return combined[mid];
            }
        }

        public double FindMedianSortedArraysWithoutLinq(int[] nums1, int[] nums2)
        {
                        
            int combinedLength = nums1.Length + nums2.Length;

            int[] combined = new int[combinedLength];

            nums1.CopyTo(combined, 0);
            nums2.CopyTo(combined, nums1.Length);

            Array.Sort(combined);

            int mid = combinedLength / 2;

            if (combinedLength % 2 == 0)
            {
                return ((double)(combined[mid - 1] + combined[mid])) / 2;
            }
            else
            {
                return combined[mid];
            }
        }
    }
}
