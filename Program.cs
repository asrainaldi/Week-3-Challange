using System;

namespace TdpWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            var challange = new Challange();

            while (true)
            {
                string number = Console.ReadLine();
                int result;
                if (!int.TryParse(number, out result))
                {
                    Console.WriteLine("Not a valid number, try again");
                    continue;
                }

                if (result >= 20000)
                    Console.WriteLine("Number too big, must be between 0 - 19000");
                else
                    Console.WriteLine(challange.NumberConverter(result));

            }
        }
    }
}
