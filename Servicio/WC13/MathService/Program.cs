using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using MathService.localhost;
namespace MathService
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathService ms = new localhost.MathService();
            int result = ms.Add(4, 5);
            WriteLine(result);
            ReadKey();
        }
    }
}
