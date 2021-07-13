using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Es nulo");

            Console.WriteLine("QUESTION 163\n");
            Console.WriteLine("You are developing an application that uses several objects. \n The application includes the following code segment.\n");
            Console.WriteLine("private bool IsNull(object obj) \n{  \n \t return false; \n} \n\n");

            Console.WriteLine("You need to evaluate whether an object is null. \n Which code segment should you insert at line 03 ? \n\n");

            Console.WriteLine("A. \t if (null = obj) \n \t { \n \t\t return true; \n \t } \n \n");
            Console.WriteLine("B. \t if (null == obj) \n \t { \n \t\t return true; \n  \t } \n \n");
            Console.WriteLine("C. \t if (null) \n \t { \n \t\t return true; \n \t } \n \n");
            Console.WriteLine("D. \t if (!obj) \n \t { \n \t\t return true; \n \t } \n \n");

            Console.Write("Correct Answer: B \n \n");
            Console.WriteLine("Para la prueba hacemos:\n");
            Console.Write("1- una llamada pasándole un nulo \n  if (new Program().IsNull(null))  y el resulatdo es: ");

            if (new Program().IsNull(null))
                Console.WriteLine("Es nulo");
            else
                Console.WriteLine("No es nulo");


            Console.Write("\n2- una llamada pasándole un objeto integer \n   int o = new int();\n if (new Program().IsNull(o))  y el resulatdo es: ");
            int o = new int();
            if (new Program().IsNull(o))
                Console.WriteLine("Es nulo");
            else
                Console.WriteLine("No es nulo");
        }

        private bool IsNull(object obj)
        {

            //A  error de compilacion
           /* if (null = obj)
            {
                return true;
            }*/

            //B
            if (null == obj)
            {
                return true;
            }
            
            //C error de comilacion
            /*if (null)
            {
                return true;
            }*/

            //D error de compilación
            /*if (!obj)
            {
                return true;
            }*/

            return false;
        }
    }
}
