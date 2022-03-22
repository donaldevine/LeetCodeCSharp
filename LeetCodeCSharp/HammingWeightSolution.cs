using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a function that takes an unsigned integer 
/// and returns the number of '1' bits it has (also known as the Hamming weight).
/// </summary>

namespace LeetCodeCSharp
{
    public class HammingWeightSolution
    {
        public int HammingWeight(uint n)
        {
            int bits = 0;
            int mask = 1;

            for (int i = 0; i < 32; i++)
            {
                if ((n & mask) != 0)
                {
                    bits++;
                }
            }
          
            return bits;
        }


        public int HammingWeight2(uint n)
        {

            int bits = 0;
            
            while (n > 0)
            {
                if (n % 2 == 1) bits++;

                n /= 2;
            }

            return bits;
        }
    }
}
