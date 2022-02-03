using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class AtoiSolution
    {
        public int MyAtoi(string s)
        {
            long res = 0;
            var sign = 1;
            s = s.Trim();
            if (string.IsNullOrEmpty(s)) return 0;

            int index = 0;

            if (s[0] == '+' || s[0] == '-')
            {
                sign = s[0] == '+' ? 1 : -1;
                index++;
            }

            while (index < s.Length)
            {
                if (!char.IsNumber(s[index])) break;

                res = res * 10 + s[index] - '0';
                if (res * sign > int.MaxValue) return int.MaxValue;
                if (res * sign < int.MinValue) return int.MinValue;

                index++;
            }
            return (int)res * sign;
        }
    }
}
