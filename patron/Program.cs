using System;

namespace patron
{
    class Program
    {
        static void Main(string[] args)
        {
           //letraSinArray();

          /*Billy*/
          //letraSinArrayTernario();

            /* Justo*/
            //devuleve el array el genera(letra)
            char[,] letra = genera('S');
            //imprime(letra);
            Console.WriteLine("\n");
            letra = genera('B');
            //imprime(letra);
        }



static void letraSinArrayTernario()
        {
            Console.WriteLine("Pintanos la S y la B");
            string cadena = " ";
            string pinta = " X";

            Console.WriteLine("");
            Console.WriteLine("");
            //recorremos vertical para pintar la B
            for (byte i=0; i<7; i++)
            {
                //recorremos horizontal
                for (byte j=0; j<7; j++)
                {
                    Console.Write(
                            (((i==0 || i==6) && j<4)
                            ||
                            ((i==1 || i==5 ||i==2) && ( j ==0 || j==3))
                            ||
                            ((i==3 ||i==4)  && ( j ==0 || j==2)))? pinta:cadena
                    );
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            //recorremos vertical para pintar la S
             for (byte i=0; i<7; i++)            {
                //recorremos horizontal
                for (byte j=0; j<7; j++)
                {
                    Console.Write(
                    (((i==0 || i==6) && (j <3))
                        ||((i==1 || i==2) && ( j ==0))
                        ||(i==3  && j ==1)
                        ||((i==4 || i==5) && ( j ==2)))?pinta:cadena
                    );
                }
                Console.WriteLine("");
            }
        }

        static void letraSinArray()
        {
            Console.WriteLine("Pintanos la S y la B");
            string cadena = " ";

            Console.WriteLine("");
            Console.WriteLine("");
            //recorremos vertical para pintar la B
            for (byte i=0; i<7; i++)
            {
                //recorremos horizontal
                for (byte j=0; j<7; j++)
                {
                    cadena = "  ";
                    if ((i==0 || i==6) && j<4)
                        cadena = " X";
                    else if ((i==1 || i==5 ||i==2) && ( j ==0 || j==3))
                        cadena = " X";
                    else if ((i==3 ||i==4)  && ( j ==0 || j==2))
                        cadena = " X";

                    Console.Write(cadena);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            //recorremos vertical para pintar la S
             for (byte i=0; i<7; i++)            {
                //recorremos horizontal
                for (byte j=0; j<7; j++)
                {
                    cadena = "  ";
                    if ((i==0 || i==6) && (j <3))
                        cadena = " X";
                    else if ((i==1 || i==2) && ( j ==0))
                        cadena = " X";
                    else if (i==3  && j ==1)
                        cadena = " X";
                    else if ((i==4 || i==5) && ( j ==2))
                        cadena = " X";
                    Console.Write(cadena);
                }
                Console.WriteLine("");
            }
        }

        /*Método que genera las matrices de las letras*/
        static public char[,] genera(char letra) {
            char[,] matr = new char[7,7];
            switch(letra) {
                case 'B':
                    matr = new char[7,7] {  {'X','X','X',' ',' ',' ',' '},
                                            {'X',' ','X',' ',' ',' ',' '},
                                            {'X',' ','X',' ',' ',' ',' '},
                                            {'X','X',' ',' ',' ',' ',' '},
                                            {'X',' ','X',' ',' ',' ',' '},
                                            {'X',' ','X',' ',' ',' ',' '},
                                            {'X','X','X',' ',' ',' ',' '}
                    };
                    break;
                case 'S':
                    matr = new char[7,7] {  {'X','X','X',' ',' ',' ',' '},
                                            {'X',' ',' ',' ',' ',' ',' '},
                                            {'X',' ',' ',' ',' ',' ',' '},
                                            {' ','X',' ',' ',' ',' ',' '},
                                            {' ',' ','X',' ',' ',' ',' '},
                                            {' ',' ','X',' ',' ',' ',' '},
                                            {'X','X','X',' ',' ',' ',' '}
                    };
                    break;
               // default:

            }
            imprime(matr);
            return matr;
        }

        static public void imprime(char[,] matr) {
            for (int fila=0; fila < 7; fila++) {
                for (int colu=0; colu<7; colu++) {
                    Console.Write(matr[fila,colu]);
                }
                Console.WriteLine("");
            }
        }
    }
}
