using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Convert a non-negative integer num to its English words representation.
/// </summary>

namespace LeetCodeCSharp
{
    public class IntegerToEnglishWordsSolution
    {
        public string NumberToWords(int num)
        {
            string words = "";

            if (num == 0) return "Zero";

            if ((num / 1000000000) > 0)
            {
                words += NumberToWords(num / 1000000000) + " Billion ";
                num %= 1000000000;
            }


            if ((num / 1000000) > 0)
            {
                words += NumberToWords(num / 1000000) + " Million ";
                num %= 1000000;
            }


            if ((num / 1000) > 0)
            {
                words += NumberToWords(num / 1000) + " Thousand ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                words += NumberToWords(num / 100) + " Hundred ";
                num %= 100;
            }


            if (num < 20)
            {
                string[] unitsMap = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                words += unitsMap[num];
            }

            if (num > 19 && num < 100)
            {
                string[] tensMap = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                words += tensMap[num / 10];
                num %= 10;

                if (num > 0)
                {
                    words += " " + NumberToWords(num);
                }

            }


            return words.Trim();

        }
    }
}
