using System;

namespace bloques
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ConsoleKeyInfo opcion = default;
            double[] numeros = new double[10];
            double result = default;
            do
            {
                Console.WriteLine("Enter the number: ");
                numeros[i++] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Desea salir(Y/N): ");
                opcion = Console.ReadKey();
            } while ((i < 10) && (opcion.Key == ConsoleKey.N));


            Console.Write($"The average of:");
            for (int a = 0; a < i; a++)
            {
                result += numeros[a];
                Console.Write($"{numeros[a]}, ");
            }

            result = result / i;
            Console.WriteLine($" : {result}");
        }
    }
}
