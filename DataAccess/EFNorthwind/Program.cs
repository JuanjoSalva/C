using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EFNorthwind
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Definimos la conexión a la BBDD*/
            var db = new NorthwindEntities();


            //LIsta de todos los clientes
            WriteLine("Todos los clientes de la lista");
            foreach (var cust in db.Customers)
            {
                WriteLine($"{cust.CompanyName} \t{cust.ContactName} \n {cust.Country}");
            }
            PressKey();

            WriteLine("\n \n");
            WriteLine("El primer cliente de la lista: ");
            Customer cust1 = db.Customers.FirstOrDefault(e => e.ContactName == "Antonio MOreno");
            if (cust1 != null)
            {
                WriteLine(cust1.CompanyName);
                WriteLine(cust1.CustomerID);
                WriteLine(cust1.Country);
                WriteLine(cust1.City);
                WriteLine(cust1.Phone);
            }
            PressKey();


            // Actualizamos datos del un registro en la tabla
            WriteLine("\n \n");
            WriteLine("Actualizando un registro en la BD");
            Customer cus1 = db.Customers.FirstOrDefault(e => e.ContactName == "Liz Nixon");
            // Customer cus1 = db.Customers.First(e => e.ContactName == "Vanegas");
            if (cus1 != null)
            {
                WriteLine($"Cambiando el telefono:{cus1.Phone} por el (905)125-5010 para el Contacto:{cus1.ContactName}");
                cus1.Phone = "(305)125-5810";
                db.SaveChanges();
            }
            PressKey();

            // Una agrupación por pais y el resultado nombre de la compañia y la persona de contacto
            WriteLine("\n \n");
            WriteLine($"AGRUPACION - Listando customer por país : sintaxis LINQ");
            var cus2 = from e in db.Customers
                       group e by e.Country into eGroup
                       select new { Country = eGroup.Key, CustomersByCountry = eGroup };

            foreach (var c in cus2)
            {
                Write($"{c.Country}: ");
                WriteLine(c.CustomersByCountry.Count());
                foreach (var cun in c.CustomersByCountry)
                {
                    WriteLine($"            {cun.CompanyName}");

                }
            }
            PressKey();


            WriteLine("AGRUPACION -Listando customer por país:  lampda de expereson");
            WriteLine("\n \n");
            var usersGroupedByCountry = db.Customers.GroupBy(customer => customer.Country);
            foreach (var c in usersGroupedByCountry)
            {
                Write($"{c.Key}:");
                WriteLine(c.Count());
                foreach (var cun in c)
                {
                    Console.WriteLine($"            { cun.CompanyName}");
                }

            }
            PressKey();


            /*CON JOIN*/
            WriteLine("\n |n");
            WriteLine("Llamadas con relacion entre entidades JOIN: \n");
            var innerJoinQuery =
                                from o in db.Orders
                                join o2 in db.Order_Details on o.OrderID equals o2.OrderID
                                where o.OrderID == 10611
                                select new
                                {
                                    ProductID = o2.ProductID,
                                    OrderID = o.OrderID,
                                    Order = o.ShipCountry //produces flat sequence
                                };
                                foreach (var or in innerJoinQuery)
                                {
                                    WriteLine($"Número de orden: {or.OrderID}");
                                    WriteLine($"    ID del producto: {or.ProductID}");
                                    WriteLine($"    País de envío: {or.Order}");
                                    WriteLine("\n");

                                }
                                PressKey();
            /**/

            WriteLine("\n |n");
            WriteLine("Llamadas con relacion entre entidades: \n");
            var ordenes = from o in db.Order_Details
                          where o.OrderID == 10611
                          select new
                          {
                              ProductID = o.ProductID,
                              OrderID = o.OrderID,
                              Order = o.Order.ShipCountry  //JOIN
                             
                          };
                
            
            foreach(var or in ordenes)
            {
                WriteLine($"Número de orden: {or.OrderID}");
                WriteLine($"    ID del producto: {or.ProductID}");                
                WriteLine($"    País de envío: {or.Order}");
                WriteLine("\n");

            }
            PressKey();



            WriteLine("Consulta dierida del LINQ");
            IQueryable<Customer> cus4 = from e in db.Customers
                                        select e;
            foreach(var c in cus4)
            {
                WriteLine("{0}{1}", c.CompanyName, c.ContactName);
            }


            PressKey();
            WriteLine("Consulta No diferida del LINQ -- Aquí fozamos la ejecucion del LINQ");
            IList<Customer> cus5 = (from e in db.Customers
                                    select e).ToList();
            foreach(var c in cus5)
            {
                WriteLine("{0} {1}", c.CompanyName, c.ContactName);
            }
            PressKey();

        }

        public static void  PressKey()
        {
            WriteLine("Press any key");
            ReadKey();
        }
    }
}
