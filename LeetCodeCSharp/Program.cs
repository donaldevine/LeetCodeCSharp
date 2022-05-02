using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LetterCombinationsofAPhoneNumberSolution solution = new LetterCombinationsofAPhoneNumberSolution();

            
            var result = solution.LetterCombinations("23");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
    }
}
