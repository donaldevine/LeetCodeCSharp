using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an m x n matrix, return all elements of the matrix in spiral order.
/// </summary>

namespace LeetCodeCSharp
{
    public class SpiralOrderSolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {

            List<int> ans = new List<int>();

            int n = matrix.Length;
            int m = matrix[0].Length;

            int up = 0;
            int down = n - 1;
            int left = 0;
            int right = m - 1;
            int total = n * m;

    
            while (ans.Count() < total)
            {
                for (int col = left; col <= right; col++)
                {
                    ans.Add(matrix[up][col]);
                }

                for (int row = up + 1; row <= down; row++)
                {
                    ans.Add(matrix[row][right]);
                }

                if (up != down)
                {
                    for (int col = right - 1; col >= left; col--)
                    {
                        ans.Add(matrix[down][col]);
                    }
                }


                if (left != right)
                {
                    for (int row = down - 1; row > up; row--)
                    {
                        ans.Add(matrix[row][left]);
                    }
                }

                up++;
                down--;
                left++;
                right--;
            }

            return ans;
        }
    }
}
