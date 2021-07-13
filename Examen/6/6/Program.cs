using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Pregunta06();


        }

        public void Pregunta06()
        {     
            Console.WriteLine("QUESTION 6\nDRAG DROP\nYou are developing an application by using C#. The application includes an array of decimal\nvalues named loanAmounts. You are developing a LINQ query to return the values from the array.\nThe query must return decimal values that are evenly divisible by two. The values must be\n sorted from the lowest value to the highest value.\nYou need to ensure that the query correctly returns the decimal values.\nHow should you complete the relevant code? (To answer, drag the appropriate code segments to\nthe correct locations in the answer area. Each code segment may be used once, more than once,\n or not at all. You may need to drag the split bar between panes or scroll to view content.)\n");
            Console.WriteLine("Answer: \n");
            Console.WriteLine("loanQuery=  \n from amount in loanAmounts \n where amount % 2 == 0 \n  orderby amount ascending    \n   select amount; \n \n");
            //write all element of loanAmounts
            Console.WriteLine("Para probar creo un array de valores decimales\ndecimal[] loanAmounts = { 303m, 1000m, 85579m, 501.51m, 603m, 1200m, 400m, 22m };\n y lo recupero con LINQ con la condicion de que sean divisibles entre 2 \n\n");

            // Create a new array and add some loan amount.
            decimal[] loanAmounts = { 303m, 1000m, 85579m, 501.51m, 603m, 1200m, 400m, 22m };
            Console.WriteLine("Todos los valores del array");
            foreach (decimal amount in loanAmounts)
            {
                Console.WriteLine($" valor: {amount}");
            }


            // Select the loanamount that are evenly divisible by two.
            IEnumerable<decimal> loanQuery=
             from amount in loanAmounts
             where amount % 2 == 0
             orderby amount ascending
             select amount;

               // Display the results.
                Console.WriteLine("Los valores del loanQuery, que son los divisibles entre 2.");
                foreach (decimal amount in loanQuery)
                {
                    Console.WriteLine($" valor: {amount}");
                }
        }
    }
}
