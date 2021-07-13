using System;

namespace siete
{
    class Program
    {
        static void Main(string[] args)
        {
            //prueba();
            //ejemplo();
            //desafio();
            //desafio3();
            desafio4();
        }

        static void ejemplo()
        {
            //string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            String[] fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
            foreach (string name in fraudulentOrderIDs)
            {
                Console.WriteLine(name);
            }
        }


        static void desafio()
        {

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;

                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in inventory.");

            String[] datos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string item in datos)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void desafio3()
        {
            Random cara = new Random();
            //int result = cara.Next(0,2);
            //Console.WriteLine(result == 0 ? "Ha salido Cara" :"Ha slido Cruz");

            Console.WriteLine((cara.Next(0, 2)) == 0 ? "Ha salido Cara" : "Ha slido Cruz");
        }

        static void desafio4()
        {
            //string permission = "Admin";
            string permission = "Mana";
            int level = 56;

            Console.WriteLine(permission.Contains("Admin"));
            Console.WriteLine(permission.Contains("Manager"));

            bool admin = permission.Contains("Admin");
            bool manager = permission.Contains("Manager");

            Console.WriteLine(
            (level > 55 && admin) ? "Welcome, Super Admin user."
            : (level <= 55 && admin) ? "Welcome, Admin user."
            : (level > 20 && manager) ? "Contact an Admin for access."
            : (level < 20 && manager) ? "You do not have sufficient privileges."
            : "You do not have sufficient privileges.");
        }

    }
}
