using System;

namespace cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            introClasesNet1();
            introClasesNet2();
        }

        static void introClasesNet1(){
            int firstValue = 700;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue,secondValue );
            Console.WriteLine(largerValue);
        }

        static void introClasesNet2(){
            string nombre = "Miguel";
            System.String apellido = "Rodriguez";
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
        }
    }
}

