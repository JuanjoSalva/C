using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You are developing an application that includes the following code segment. ");
            Console.WriteLine("using System\nclass MainClass\n{\n\tpublic static void Main(string)[] args)\n\t{\n\t\tbool bValidaInteger = false;\n\t\tint value = 0;\n\t\tdo\n\t\t{\n\t\t\tConsole.WriteLIne('Enter an integer');\n\t\tbValidInteger = GetValidInteger(ref value);\n\t\t}while (!bValidInteger)\n\t\tConsole.WriteLine('You entered a valid integer, ' + value);\n}public static bool GetValidInteger(ref int val)\n{\n\tstring sLine = Console.ReadLine();\n\tint number;\n\n\t{\n\t\treturn false;\n\t}\n\telse\n\t{\n\t\tval = number;\n\t\treturn true;\n\t}\n}\n}");



            Console.WriteLine("You need to ensure that the application accepts only integer input and prompts the user each time non-integer input is entered.\n");
            Console.WriteLine("Which code segment should you add at line 19?");
            


            Console.WriteLine("A.if (!int.TryParse(sLine, out number))\n\nB. if ((number = Int32.Parse(sLine)) == Single.NaN)\n\nC. if ((number = int.Parse(sLine)) > Int32.MaxValue)\n\nD.  if (Int32.TryParse(sLine, out number))\n\n");

            Console.WriteLine("Correct Answer: A\n\n");
            Console.WriteLine("Para probarlo replico el código. Se pedirá número Integer hasta que sea correcto");

            bool bvalidaInteger = false;
            int value = 0;
            do
            {
                Console.WriteLine("Enter an integer: ");
                bvalidaInteger = GetValidInteger(ref value);
            } while (!bvalidaInteger);
            Console.WriteLine("You entered a valid integer");
        }

        public static bool GetValidInteger(ref int val)
        {
            string sLine = Console.ReadLine();
            int number;

            //A
            if (!int.TryParse(sLine, out number))
            
            //B Error en compilacion
            //if ((number = Int32.Parse(sLine)) == Single.NaN)
            
            //C se valida que sea numero pero saca error si no lo es
            //if ((number = int.Parse(sLine)) > Int32.MaxValue)
                    
            //D  No, te valida si no lo es, o hace al revés
            //if (Int32.TryParse(sLine, out number))
                    
                return false;
           
            else
            { 
                val = number;
                return true;
            }
        }

    }
}
