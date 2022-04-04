using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
/// Open brackets must be closed by the same type of brackets.
/// Open brackets must be closed in the correct order.
/// </summary>

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
                    case '<':
                        endings.Push('>');
                        break;
                    case ')':
                    case ']':
                    case '}':
                    case '>':
                        if (endings.Count == 0 || endings.Pop() != c) return false;
                        break;
                }
            }
            return (endings.Count == 0);
        }
    }
}
