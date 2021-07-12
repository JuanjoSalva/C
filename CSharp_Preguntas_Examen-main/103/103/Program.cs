using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You are developing an application.\n");
            Console.WriteLine("You need to declare a delegate for a method that accepts an integer as a parameter, and then returns aninteger.\n");
            Console.WriteLine("Which type of delegate should you use?\n\n");
            Console.WriteLine("A. Action<int>\nB. Action<int,int>\nC. Func<int,int>\nD. Func<int>\n\n");
            Console.WriteLine("Correct Answer: C\n");

            Console.WriteLine("Para Probarlo he hecho el siguiente  ejemplo: \n");
            Console.WriteLine("\nFunc<int, int, int> mi_add = Sum;\n\nint result = mi_add(12, 10);\n\nConsole.WriteLine(result);\n\nstatic int Sum(int x, int y)\n{\n\treturn x + y;\n}");

            Func<int, int, int> mi_add = Sum;

            int result = mi_add(12, 10);

            Console.WriteLine($" La suma llamada por delegado es:  {result}");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
