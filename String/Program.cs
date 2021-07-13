using System;

namespace cuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fahrenheit = 94;
            decimal celsius =0;


            celsius = (fahrenheit-32) * (5m/9);
            Console.WriteLine($"temperatura={fahrenheit}º in fahrenheit son {celsius}º grados celsius");



            fahrenheit = celsius * 9/5 +32;
            Console.WriteLine($"temperatura={celsius}º in celsius son {fahrenheit}º grados fahrenheit");


double base1 = 2;
double exp1 = 3;

            Console.WriteLine(Math.Pow(base1,exp1));
            Console.WriteLine($"con cambio de tipo : {Math.Pow(base1,exp1)}");



int value = 0;
value = value + 5;
value += 5;
int edad = 0;
edad = edad + 1;
Console.WriteLine($"Valor de edad despues del ++: {edad++}");
//Valor de edad despues del ++: 1 Muestra y despues suma ??? SI//edad = edad + 1;
Console.WriteLine($"Valor de value antes del ++: {++edad}");
//Valor de edad despues del ++: 3 Suma y despues muestra ??? SI


int fondo = 4;
Console.WriteLine(--fondo);
Console.WriteLine(fondo--);

        }
    }
}
