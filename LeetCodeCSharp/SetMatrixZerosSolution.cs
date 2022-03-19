using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class SetMatrixZerosSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix[0] == null)
                return;

            int m = matrix.Length;
            int n = matrix[0].Length;
            bool setFirstRow = false;
            bool setFirstCol = false;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (i != 0)
                            matrix[i][0] = 0;
                        else
                            setFirstRow = true;
                        if (j != 0)
                            matrix[0][j] = 0;
                        else
                            setFirstCol = true;
                    }
                }
            }

            for (int i = 1; i < m; i++)
            {
                if (matrix[i][0] == 0)
                    SetRowZero(matrix, i);
            }

            for (int j = 1; j < n; j++)
            {
                if (matrix[0][j] == 0)
                    SetColumnZero(matrix, j);
            }

            if (setFirstRow)
            {
                matrix[0][0] = 0;
                SetRowZero(matrix, 0);
            }
            if (setFirstCol)
            {
                matrix[0][0] = 0;
                SetColumnZero(matrix, 0);
            }
        }

        private void SetColumnZero(int[][] matrix, int col)
        {
            for (int i = 1; i < matrix.Length; i++)
                matrix[i][col] = 0;
        }

        private void SetRowZero(int[][] matrix, int row)
        {
            for (int j = 1; j < matrix[0].Length; j++)
                matrix[row][j] = 0;
        }
    }
}
