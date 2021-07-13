using System;

namespace opera_matices
{
    class Program
    {
        static void Main(string[] args)
        {
            desafio1();
            desafio2();
        }

        /*tring pangram = "The quick brown fox jumps over the lazy dog";
        Escriba el código necesario para invertir las letras de cada palabra existente y muestre el resultado.
        En otras palabras, no vamos a revertir simplemente cada letra de la variable pangram, sino que
        invertiremos las letras de cada palabra, pero las palabras con los caracteres desordenados se
        imprimirán en su posición original dentro del mensaje.*/
        static void desafio1()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }

        /*Usando el siguiente código como punto de partida, deberemos analizar los identificadores de pedido de
        una cadena que contiene una secuencia de pedidos entrantes (orderStream). Luego, imprimiremos cada
        identificador de pedido que empiece por la letra "B".*/
        static void desafio2()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');

            foreach (var item in items)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
