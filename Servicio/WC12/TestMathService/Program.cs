using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMathService
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathService myMathService = new localhost.MathService();
            Console.WriteLine("2+4={0}", myMathService.Add(2, 4));
        }
    }
}
