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
            MinDeletionsSolution solution = new MinDeletionsSolution();

            
            var result = solution.MinDeletions("axxaxa");

            
            
            Console.WriteLine(result);
            
            

            Console.ReadLine();
        }
    }
}
