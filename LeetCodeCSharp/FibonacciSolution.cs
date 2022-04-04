using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class FibonacciSolution
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public long fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            if(memo.ContainsKey(n)) return memo[n];

            memo[n] = fib(n - 1) + fib(n - 2);

            return memo[n];
        }
    }
}
