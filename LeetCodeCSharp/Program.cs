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
            FibonacciSolution fibonacciSolution = new FibonacciSolution();

            
            var fibResult = fibonacciSolution.fib(50);

            Console.WriteLine($"fib: {fibResult}");

            Console.ReadLine();
        }
    }
}
