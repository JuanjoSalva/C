using System;

namespace tercero
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Juanjo";
            string lastName = "Salvador";

            Console.WriteLine("nombre: " ,firstName," segundo: ",lastName);
            Console.WriteLine("nombre {0} y apellido {1}: ", firstName, lastName);
            Console.WriteLine("nombre: {0}{1}{2}", firstName, " y apellido: ",lastName);
            Console.WriteLine($"nombre: {firstName} y apellido: {lastName}");
            Console.WriteLine(@$"nombre: {firstName} y apellido: {lastName}");


            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        }
    }
}
