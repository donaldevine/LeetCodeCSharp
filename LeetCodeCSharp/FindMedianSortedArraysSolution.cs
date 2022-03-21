using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n)).    
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
    }
}
