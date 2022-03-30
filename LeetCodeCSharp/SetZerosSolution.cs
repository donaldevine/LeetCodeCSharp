using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
/// You must do it in place.
/// </summary>

namespace LeetCodeCSharp
{
    public class SetZerosSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            int rowLength = matrix.Length;
            int colLength = matrix[0].Length;

            HashSet<int> rowSet = new HashSet<int>();
            HashSet<int> colSet = new HashSet<int>();

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if(!rowSet.Contains(i))rowSet.Add(i);
                        if(!colSet.Contains(j))colSet.Add(j);                        
                    }
                }
            }


            foreach (var row in rowSet)
            {
                for (var j = 0; j < colLength; j++)
                {
                    matrix[row][j] = 0;
                }
            }

            foreach (var col in colSet)
            {
                for (var i = 0; i < rowLength; i++)
                {
                    if (matrix[i][col] != 0) matrix[i][col] = 0;
                }
            }
        }
    }
}
