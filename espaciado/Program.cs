using System;

namespace ocho
{
    class Program
    {
        static void Main(string[] args)
        {
            desafio("The quick brown fox jumps over the lazy dog.");
        }

        /*Método que pasado una cadena:
            1- La escribe por consola al revés
            2- Escribe el númeor de 'o' que tiene*/
        static void desafio(String str){

            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);

            int x = 0;

            foreach (char i in charMessage)
            {
                if (i == 'o')
                {
                    x++;
                }
            }

            string new_message = new String(charMessage);

            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");
        }
    }


}
