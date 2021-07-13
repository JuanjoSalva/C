using System;

namespace mas
{
    class Program
    {
        static void Main(string[] args)
        {
            //prueba1();
            prueba2();
        }

        static void prueba1()
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine("Inside of code block: " + value);

            }
            Console.WriteLine("Outside of code block: " + value);

            int a = default;
            Console.Write(a);
        }


        //9. Escriba un programa C # Sharp que tome cuatro números como entrada para calcular e imprimir el promedio.
        /*Datos de Prueba:
        Enter the First number: 10
        Enter the Second number: 15
        Enter the third number: 20
        Enter the four number: 30
       Salida Esperada:
        The average of 10 , 15 , 20 , 30 is: 18
        Respuesta:*/
                static void prueba2()
        {



        public int Main9()
        {
            #region Exer9
            Console.WriteLine("(9)=====");
            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            number1, number2, number3, number4, result);
            Console.WriteLine("\n========");
            #endregion
            return 0;
        }

        }





    }
}
