using System;

namespace ConsoleAppTdpChallangeWeek3
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
                string units = "";

                string tens = Challange.twentyToNinety[((number / 10) - 2)];

                if ((number % 10) > 0)
                    units = Challange.zeroToNineten[(number % 10)];
                string result = tens + " " + units;
                return result;
            }
        }

        public class Challange
        {
            string result = "";
            string tens = "";
            string hundreds = "";
            public string NumberConverter(int number)
            {

                if (number < 20)
                {
                    result = zeroToNineten[number];
                }
                else if (number >= 20 && number <= 99)
                {
                    result = FindTens.Tens(number);
                }
                else if (number >= 100 && number <= 999)
                {
                    int numberTens = NumberOfTens(number, 100);

                    if (numberTens < 20)
                        tens = zeroToNineten[numberTens];
                    else
                    {
                        tens = FindTens.Tens(numberTens);
                    }

                    if (numberTens == 0)
                        result = zeroToNineten[(number / 100)] + " " + hundred[0];
                    else
                        result = zeroToNineten[(number / 100)] + " " + hundred[0] + " and " + tens;
                }
                else if (number >= 1000 && number <= 9999)
                {
                    hundreds = "";
                    int numberoftens = NumberOfTens(number, 100);
                    int numberofhundred = NumberOfTens(number, 1000) - numberoftens;

                    if (numberoftens < 20)
                        tens = zeroToNineten[numberoftens];
                    else
                    {
                        tens = FindTens.Tens(numberoftens);
                    }

                    if (numberofhundred >= 100)
                        hundreds = zeroToNineten[(numberofhundred / 100)];
                    //else
                    //{
                    //    hundreds = FindTens.Tens((numberofhundred / 10));
                    //}

                    if (numberoftens < 20)
                        tens = zeroToNineten[numberoftens];
                    else
                    {
                        tens = FindTens.Tens(numberoftens);
                    }


                    result = zeroToNineten[(number / 1000)] + " " + thousand[0];

                    if(hundreds != "")
                        result = result + " " + hundreds + " " + hundred[0];

                    if (numberoftens != 0)
                        result = result +" " + "and " + tens;

                }

                return result;
            }

            private int NumberOfTens(int number, int size)
            {
                return (number - ((number / size) * size));
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
