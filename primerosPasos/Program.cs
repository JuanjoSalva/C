using System;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //System.Console("Hello World!");
            /*Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code!");*/

            Console.WriteLine("This is the first line.");
            Console.WriteLine("This is the second line.");

            //string firsVariable;
            string firsVariable = "Estoy pintando el contenido de una variable string que es éste que estas leyendo";
            Console.WriteLine(firsVariable);
            int numero = 9;
            Console.WriteLine(numero);
            char caracter = 'b';
            Console.WriteLine(caracter);
            decimal numDecimal1 = 12.3m;
            decimal numDecimal2 = 12.5M;
            Console.WriteLine(numDecimal1 + "   " + numDecimal2);
            bool bandera = false;
            Console.WriteLine("bandera = " + bandera);

            var message="hola";
            Console.WriteLine(message);

            string registrationComplete = "hola";
            string yes = "Juan";
            Console.WriteLine(registrationComplete + " " + yes);




        }
    }
}
