using System;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio1();
            desafio2();

        }

        static void desafio1()
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }

        static void desafio2()
        {
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            decimal result1 = value1/value2;
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


            float result2 = (float)value2/value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3/(float)value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}
