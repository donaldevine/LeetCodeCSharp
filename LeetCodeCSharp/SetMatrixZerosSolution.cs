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
    public class SetMatrixZerosSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix[0] == null)
                return;

            int rowLength = matrix.Length;
            int columnLength = matrix[0].Length;

            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if(!rows.Contains(i)) rows.Add(i);
                        if(!cols.Contains(j)) cols.Add(j);
                    }
                }
            }

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

        }
    }
}
