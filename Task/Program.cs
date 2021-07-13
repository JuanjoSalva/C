using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {



        static void Main(string[] args)
        {


             Thread.CurrentThread.Name = "Main";

             Task task1 = Task.Run(
                ()=>
                Console.WriteLine("Hola desde la tarea Task A")
            );


            Console.WriteLine("Hellow from thread '{0}.'", Thread.CurrentThread.Name);

            //Task1.Wait();
        }
    }
}
