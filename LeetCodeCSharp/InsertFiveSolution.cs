using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a function named 'solution' that, given an integer 'N'
/// returns the maximum posisible value obtained by inserting
/// one '5' digit inside the decimal representation of integer 'N'
/// 
/// Given N = 268, the function should return 5268.
/// Given N = 670, the function should return 6750.
/// Given N = 0, the function should return 50.
/// </summary>
namespace LeetCodeCSharp
{
    public class InsertFiveSolution
    {
        public int Solution(int N)
        {
            if (N == 0) return 50;

            string nString = N.ToString();

            for (var i = 1; i < nString.Length; i++)
            {
                var inta = (int)nString[i];

                if (inta < 5)
                {
                    return int.Parse(nString.Insert(i, "5")); ;
                }
            }

            return int.Parse(nString + "5");
        }
    }
}
