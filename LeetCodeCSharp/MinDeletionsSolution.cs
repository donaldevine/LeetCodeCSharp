using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class MinDeletionsSolution
    {

        public int MinDeletions(string s)
        {
            if (String.IsNullOrEmpty(s)) return 0;
                        
            int result = 0;
            
            int[] freqArray = new int[26];

            foreach (var c in s) freqArray[c - 'a']++;

            for (int i = 0; i < freqArray.Length; i++)
            {
                if(freqArray[i] % 2 != 0) 
                {                    
                    result++;
                }                
            }

            return result;
        }
    }
}
