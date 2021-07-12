using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _276
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nYou are developing a custom collection named LoanCollection for a class named Loan class.\nYou need to ensure that you can process each Loan object in the LoanCollection collection by using a\nforeach loop.\nYou have the following code:");
            Console.WriteLine("\n\npublic class LoanCollection Target1\n{\n\tprivate readonly Loan[] _LoanCollection;\n\tpublic LoanCollection(LOan[] loanArray)\n\t{\n\t\t_loanCollection = new Loan[loanArray.Length];\n\t\tfor(int i=0; i<loanArray.Length; i++)\n\t{\n\t_loanCollection[i] = loanArray[i];\n}\n}\nTarget2\n{\nTarget3\n}\n}");
            Console.WriteLine("\n\nWhich code segments should you include in Target 1, Target 2, and Target 3 to complete the code? To\nanswer, drag the appropriate code segments to the correct targets. Each code segment may be used once,\nmore than once, or not at all. You may need to drag the split bar between panes or scroll to view content.\nNOTE: Each correct selection is worth one point.");
            Console.WriteLine("\n\npublic class LoanCollection IEnumerable;\n{\n\tprivate readonly Loan[] _LoanCollection;\n\tpublic LoanCollection(LOan[] loanArray)\n\t\t{\n\t\t\t_loanCollection = new Loan[loanArray.Length];\n\t\t\tfor(int i=0; i<loanArray.Length; i++)\n\t\t\t{\n\t\t\t\t_loanCollection[i] = loanArray[i];\n\t\t\t}\n\t\t}\n\t\tpublic IEnumerator GetEnumerator();\n\t\t{\n\t\t\treturn _loanCollection.GetEnumerator();\n\t\t}\n}");

            Console.WriteLine("Para probarlo implementamos la clase como se indica en la solucion del ejercicio. Luego instanciamos la clase que\n crea una lista y la recorremos con foreach ya que la implementacion de IEnumerable que da la posibiliadad de recorrerla");
            Console.WriteLine("\n LoanCollection miLista = new LoanCollection();");
            Console.WriteLine("\nforeach (var elemento in miLista)\n{\n\tConsole.WriteLine($' elemento: { elemento}');\n}");


            Loan[] loanArray = new Loan[6]
            {
                new Loan("John", "1"), new Loan("Peter", "2"), new Loan("Billy","3"), new Loan("Jule", "4"),  new Loan("Albert", "5") , new Loan("Peter", "6")
            };

            LoanCollection miLista = new LoanCollection(loanArray);           
            foreach (var elemento in miLista)
            {
                Console.WriteLine($"ID:{elemento.Id}, Assigned:{elemento.Assigned}");
            }
        }
        
        public class LoanCollection : IEnumerable
        {
            private readonly Loan[] _LoanCollection;

            public LoanCollection(Loan[] loanArray)
            {
                _LoanCollection = new Loan[loanArray.Length];
                for (int i = 0; i < loanArray.Length; i++)
                {
                    _LoanCollection[i] = loanArray[i];
                }
            }

          
            /*public IEnumerator GetEnumerator()
            {
                return _LoanCollection.GetEnumerator();
            }*/

           IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public iterador GetEnumerator()
            {
                return new iterador(_LoanCollection);
            }
        }

        public class Loan
        {
            public string Id;
            public string Assigned;
            public Loan(string iD, string assigned)
            {
                this.Id = iD;
                this.Assigned = assigned;
            }

        }

        // When you implement IEnumerable, you must also implement IEnumerator
        public class iterador : IEnumerator
        {
            public Loan[] _loan;
            // Enumerators are positioned before the first element until the first MoveNext() call.
            int position = -1;
            public iterador(Loan[] list)
            {
                _loan = list;
            }
            public bool MoveNext()
            {
                position++;
                return (position < _loan.Length);
            }
            public void Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public Loan Current
            {
                get
                {
                    try
                    {
                        return _loan[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
