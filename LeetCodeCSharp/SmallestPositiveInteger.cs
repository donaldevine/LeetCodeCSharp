using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
/// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
/// Given A = [1, 2, 3], the function should return 4.
/// Given A = [−1, −3], the function should return 1.
/// Write an efficient algorithm for the following assumptions:
/// N is an integer within the range [1..100,000] ;
/// each element of array A is an integer within the range [−1,000,000..1,000,000].
/// </summary>


namespace LeetCodeCSharp
{
    public class SmallestPositiveInteger
    {
        public int solution(int[] A)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var a in A)
            {
                hashSet.Add(a);
            }

            var arrayLength = A.Length;

            for (var i = 1; i <= arrayLength + 1; i++)
            {
                if (!hashSet.Contains(i))
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
