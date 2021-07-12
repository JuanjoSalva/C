using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("QUESTION !4 \nYou are developing an application that will convert data into multiple output formats.\n The application includes the following code.\n\n");
            Console.WriteLine("public class TabDelimitedFormatter : IOutputFormatter<string>\n\t{\n\treadonly Func<int, char> suffix = col => col % 2 == 0 ? '\n' : '\t';\n\tpublic string GetOutput(IEnumerator<string> iterator, int recordSize)\n\t{\n\n\t} \n\t}\n\n");
            Console.WriteLine("You are developing a code segment that will produce tab-delimited output. All output routines implement the\nfollowing interface:\n\n");
            Console.WriteLine("public interface IOutputFormatter<T>\n{\n\t   string GetOutput(IEnumerator<T> iterator, int recordSize);\n}");
            Console.WriteLine("You need to minimize the completion time of the GetOutput() method.\nWhich code segment should you insert at line 06 ?\n\n");
            Console.WriteLine("A.\nstring output = null;\nfor (int i=1;iterator.MoveNext();i++)\n{\n\toutput = string.Concat(output, iterator.Current, suffix(i));\n}\nreturn output; \n");
            Console.WriteLine("B \nvar output = new StringBuilder();\nfor(int i = 1; iterator.MoveNext(); i++)\n{\n\toutput.Append(iterator.Current);\n\toutput.Append(suffix(i));\n}\nreturn output.ToString(); \n");
            Console.WriteLine("C\nstring output = null;\nfor(int i = 1; iterator.MoveNext(); i++)\n{\n\toutput = output + iterator.Current + suffix(i);\n}\nreturn output;\n");
            Console.WriteLine("D Sólo saca el último\nstring output = null;\nfor(int i = 1; iterator.MoveNext(); i++)\n{\n\toutput = iterator.Current + suffix(i);\n}\nreturn output;\n\n");
            Console.WriteLine("Correct Answerd B StringBuilder\n\n");

            Console.WriteLine("Para probarlo creamos una lista a la que metemos numeros de 0 a 9.\n Luego creamos objeto de la clase propuesta y llamamos al metodo GetOutput para pintarlos\n\n\n");


           List<string> myList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add("Item " + i.ToString());
            }
            IEnumerator<string> myEnum = myList.GetEnumerator();

            TabDelimitedFormatter objecto = new TabDelimitedFormatter();
            Console.WriteLine(objecto.GetOutput(myEnum, 6));

            Console.WriteLine("\n \n Usamos StringBuilder. Utilice la clase String si está concatenando un número fijo de objetos String. Utilice un StringBuilder objeto si está concatenando un número arbitrario de cadenas; por ejemplo, si está utilizando un bucle para concatenar un número aleatorio de cadenas de entrada del usuario.");
        }

        public class TabDelimitedFormatter: IOutputFormatter<string>
        {
            readonly Func<int, char> suffix = col => col % 2 == 0 ? '\n' : '\t';
            public string GetOutput(IEnumerator<string> iterator, int recordSize)
            {   //A.
                /*string output = null;
                for (int i=1;iterator.MoveNext();i++)
                {
                    output = string.Concat(output, iterator.Current, suffix(i));
                }
                return output;*/

            //B No funciona
            var output = new StringBuilder();
                for (int i = 1; iterator.MoveNext(); i++)
                {
                    output.Append(iterator.Current);
                    output.Append(suffix(i));
                }
                return output.ToString();

                //C
               /*string output = null;
                for (int i = 1; iterator.MoveNext(); i++)
                {
                    output = output + iterator.Current + suffix(i);
                }
                return output;*/

                //D Sólo saca el último
               /* string output = null;
                for (int i = 1; iterator.MoveNext(); i++)
                {
                    output = iterator.Current + suffix(i);
                }
                return output;*/

            }

        }

        public interface IOutputFormatter<T>
        {
            string GetOutput(IEnumerator<T> iterator, int recordSize);
        }


    }
}
