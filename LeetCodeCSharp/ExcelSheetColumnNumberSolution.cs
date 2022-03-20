using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given a string columnTitle that represents the column title as appear in an Excel sheet, 
/// return its corresponding column number.
/// A -> 1
/// B-> 2
/// C-> 3...
/// Z-> 26
/// AA-> 27
/// AB-> 28...
/// </summary>

namespace LeetCodeCSharp
{
    public class ExcelSheetColumnNumberSolution
    {
        public int TitleToNumber(string columnTitle)
        {
            int number = 0;

            columnTitle = columnTitle.ToUpper();

            var pow = 1;

            for (var i = columnTitle.Length - 1; i >= 0; i--)
            {
                number += (columnTitle[i] - 'A' + 1) * pow;
                pow *= 26;
            }

            return number;
        }
    }
}
