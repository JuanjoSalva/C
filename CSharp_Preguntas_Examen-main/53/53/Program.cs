using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 53\nYou are developing an application that includes a class named Order. The application will store a collection of\nOrder objects.\nThe collection must meet the following requirements:\n-Internally store a key and a value for each collection item.\n-Provide objects to iterators in ascending order based on the key.\n-Ensure that items are accessible by zero-based index or by key.\nYou need to use a collection type that meets the requirements.\n\nWhich collection type should you use?A. LinkedList\nB. Queue\nC. Array\nD. HashTable\nE. SortedList\n\nCorrect Answer: E");
            Console.WriteLine("\n\n Para la prueba creamos una SortedList insertando estas claves/valores y en este orden. \n Las claves: hola, adiós, hasta luego y bueno \n \n");
            // Creamos e insertamos datos
            SortedList<string, string> miSortedList = new SortedList<string, string>();
            miSortedList.Add("hola", "4 - hello");
            miSortedList.Add("adiós", "1 - good bye");
            miSortedList.Add("hasta luego", "3 - see you later");
            miSortedList.Add("bueno", "2 - good");

            // Mostramos los datos
            Console.WriteLine("Mostramos el diccionario y debería salir ordenado por clave ascendentemente");
            for (int i = 0; i < miSortedList.Count; i++)
            {
                Console.WriteLine("{0} = {1}",
                //miSortedList.GetKey(i), miSortedList.GetByIndex(i));                
                miSortedList.Keys[i], miSortedList.Values[i]);
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("Accedemos por clave: \"hola\": {0}",
            miSortedList["hola"]);


            Console.WriteLine("Accedemos por indice de base 0: \"0\": {0}", 
            miSortedList.Values[0]);
            

            

        }
    }
}
