using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Models
{
    public class Converter
    {
        private Dictionary<int, string> digits;

        public Converter()
        {
            digits = new Dictionary<int, string>()
            {
                { 100, "C" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }

        public string ConvertNumberToNumerals(int input)
        {
            var result = string.Empty;
            
            for (int i = 0; i < digits.Count; i++)
            {
                while (input >= digits.ElementAt(i).Key)
                {
                    result += digits.ElementAt(i).Value;
                    input -= digits.ElementAt(i).Key;
                }
            }

            return result;
        }
    }
}
