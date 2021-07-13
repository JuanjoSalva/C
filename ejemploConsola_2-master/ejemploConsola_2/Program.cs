using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploConsola_2
{
    class Program
    {
        static string[][] letrasDibujo = new string[25][];
        static char[] letras = new char[25];
        static int totalLetras = 0;
        static void Main(string[] args)
        {
            verLetra("N");
            Console.WriteLine();
            verLetra("D");
            Console.WriteLine();

            totalLetras = 5;
            crearLetra('N', 0);
            crearLetra('D', 1);
            crearLetra(' ', 2);
            crearLetra('O', 3);
            crearLetra('E', 4);
            pintarPalabra("DONDE");

            Console.WriteLine("fin programa.");
            Console.ReadKey();
        }

        
        static public void verLetra(string letraEleccionada)
        {
            string[] letra= new string[7];
            switch (letraEleccionada)
            {
                case "D":
                    letra[0] = "******* ";
                    letra[1] = "*      *";
                    letra[2] = "*      *";
                    letra[3] = "*      *";
                    letra[4] = "*      *";
                    letra[5] = "*      *";
                    letra[6] = "******* ";
                    break;
                case "N":
                    letra[0] = "*       *";
                    letra[1] = "* *     *";
                    letra[2] = "*  *    *";
                    letra[3] = "*   *   *";
                    letra[4] = "*    *  *";
                    letra[5] = "*     * *";
                    letra[6] = "*       *";
                    break;
                default:
                    break;
            }
            for (int fila = 0; fila < 7; fila++)
            {                
                Console.WriteLine(letra[fila]);
            }

            
        }

        static public void crearLetra(char letraEleccionada,int posicion)
        {
            string[] letra = new string[7];
            switch (letraEleccionada)
            {
                case ' ':
                    letra[0] = "        ";
                    letra[1] = "        ";
                    letra[2] = "        ";
                    letra[3] = "        ";
                    letra[4] = "        ";
                    letra[5] = "        ";
                    letra[6] = "        ";
                    break;
                case 'E':
                    letra[0] = "********";
                    letra[1] = "*       ";
                    letra[2] = "*       ";
                    letra[3] = "******* ";
                    letra[4] = "*       ";
                    letra[5] = "*       ";
                    letra[6] = "********";
                    break;
                case 'O':
                    letra[0] = "********";
                    letra[1] = "*      *";
                    letra[2] = "*      *";
                    letra[3] = "*      *";
                    letra[4] = "*      *";
                    letra[5] = "*      *";
                    letra[6] = "********";
                    break;
                case 'D':
                    letra[0] = "******* ";
                    letra[1] = "*      *";
                    letra[2] = "*      *";
                    letra[3] = "*      *";
                    letra[4] = "*      *";
                    letra[5] = "*      *";
                    letra[6] = "******* ";
                    break;
                case 'N':
                    letra[0] = "*       *";
                    letra[1] = "* *     *";
                    letra[2] = "*  *    *";
                    letra[3] = "*   *   *";
                    letra[4] = "*    *  *";
                    letra[5] = "*     * *";
                    letra[6] = "*       *";
                    break;
                default:
                    break;
            }
            letrasDibujo[posicion] = letra;
            letras[posicion] = letraEleccionada;
        }

        static public void pintarPalabra(string palabra)
        {
            char letra ;
            for (int fila = 0; fila < 7; fila++)
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    letra = palabra[i];
                    for (int letraActual = 0; letraActual < totalLetras; letraActual++)
                    {
                        if (letras[letraActual] == letra)
                        {
                            Console.Write(letrasDibujo[letraActual][fila]);
                            Console.Write(" ");
                        }
                    }
                    
                }
                Console.WriteLine();
            }            
        }


    }
}
