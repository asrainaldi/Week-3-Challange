using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var challange = new Challange();
            //var number = Console.ReadLine();


            while (true)
            {
                var number = Console.ReadLine();
                Console.WriteLine(challange.NumberConverter(int.Parse(number)));
            }

        }

        public class FindTens
        {
            public static string Tens(int number)
            {
                string result = "";
                string units = "";
                string tens = "";

                tens = Challange.twentyToNinety[((number / 10) - 2)];

                if ((number % 10) > 0)
                    units = Challange.zeroToNineten[(number % 10)];
                result = tens + " " + units;
                return result;
            }
        }

        public class Challange
        {
            public string NumberConverter(int number)
            {
                string result = "";
                string units = "";
                string tens = "";

                if (number < 20)
                    result = zeroToNineten[number];
                else if (number >= 20 && number <= 99)
                {
                    result = FindTens.Tens(number);
                }
                else if (number >= 100 && number <= 999)
                {
                    int numberHunreds = number / 100;
                    int numberTens = number - ((number / 100) * 100) ;
                    string results = FindTens.Tens(numberTens);
                    result = zeroToNineten[numberHunreds];
                    result = result + " " + hundred[0] + " and " + results;

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
                "threeten",
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

            public static string[] hundred =
            {
                "hundred"
            };

            public static string[] thousand =
            {
                "thousand"
            };
        }
    }
}
