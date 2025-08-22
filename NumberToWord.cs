using System;
using System.Text.RegularExpressions;

namespace NumberToWordsWebApp
{
    public static class NumberToWord
    {
        public static string ToWords(this decimal value)
        {
            
            string decimals = "";
            string input = Math.Round(value, 2).ToString();

            if (input.Contains("."))
            {
                decimals = input.Substring(input.IndexOf(".") + 1);
                input = input.Remove(input.IndexOf("."));
            }

            string strWords = GetWords(input) + " Dollars";

            if (decimals.Length > 0)
                strWords += " and " + GetWords(decimals) + " Cents";
           

            return Regex.Replace(strWords.ToUpper(), @"\s+", " ").Trim();
        }

        private static string GetWords(string input)
        {
            string[] separators = { "", " Thousand ", " Million ", " Billion " };
            int i = 0;
            string strWords = "";

            while (input.Length > 0)
            {
                string _3digits = input.Length < 3 ? input : input.Substring(input.Length - 3);
                input = input.Length < 3 ? "" : input.Remove(input.Length - 3);

                int no = int.Parse(_3digits);
                _3digits = GetWord(no);

                if (_3digits != "")
                    _3digits += separators[i];

                strWords = _3digits + strWords;
                i++;
            }

            return Regex.Replace(strWords, @"\s+", " ").Trim();
        }

        private static string GetWord(int no)
        {
            string[] Ones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                              "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
                              "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string[] Tens = { "Ten", "Twenty", "Thirty", "Forty", "Fifty",
                              "Sixty", "Seventy", "Eighty", "Ninety" };

            string word = "";

            if (no >= 100)
            {
                word += Ones[(no / 100) - 1] + " Hundred ";
                no %= 100;
            }

            if (no >= 20)
            {
                word += Tens[(no / 10) - 1] + " ";
                no %= 10;
            }

            if (no > 0)
                word += Ones[no - 1];

            return word;
        }
    }
}
