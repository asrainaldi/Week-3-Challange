using System;
using System.Collections.Generic;
using System.Text;

namespace TdpWeek3
{
    public class Challange
    {
        public string NumberConverter(int number)
        {
            string result = "";
            bool tensOnly = false;

            if (number == 0)
                return zeroToNineten[0];

            if (number >= 1000 && number < 20000)
            {
                result = zeroToNineten[(number / 1000)] + " " + thousand[0] + " ";
                number = number % 1000;
            }
            if (number >= 100)
            {
                result += zeroToNineten[(number / 100)] + " " + hundred[0] + " ";
                number = number % 100;
            }
            if (number >= 20)
            {
                if (result != "")
                    result += "and " + twentyToNinety[(number / 10 - 2)] + " ";
                else
                    result = twentyToNinety[(number / 10 - 2)] + " ";
                tensOnly = true;

                number = number % 10;
            }
            if (number < 20 & number > 0)
            {
                if (result != "" && tensOnly == false)
                    result += "and " + zeroToNineten[number];
                else
                    result += zeroToNineten[number];
            }

            return result;
        }

        public static string[] zeroToNineten =
      {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelfth",
                "thirteen",
                "fourteen",
                "fithteen",
                "sixteen",
                "seventeen",
                "eightteen",
                "nineteen"
            };

        public static string[] twentyToNinety =
        {
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };

        public static string[] hundred = { "hundred" };

        public static string[] thousand = { "thousand" };
    }
}
