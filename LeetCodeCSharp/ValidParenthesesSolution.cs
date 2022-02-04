using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            Stack<char> endings = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        endings.Push(')');
                        break;
                    case '[':
                        endings.Push(']');
                        break;
                    case '{':
                        endings.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (endings.Count == 0 || (endings.Pop() != c)) return false;
                        break;
                }
            }
            return (endings.Count == 0);
        }
    }
}
