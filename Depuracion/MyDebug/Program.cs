// Specify /d:DEBUG when compiling.

using System;
using System.Data;
using System.Diagnostics;
using System.IO;

class Test
{
    static void Main()
    {

        Stream myFile = File.Create("Juanjo.log");
        //Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Debug.Listeners.Add(new TextWriterTraceListener(myFile));
        Debug.AutoFlush = true;
        Debug.Indent(); // Para distinguir los resultados de la traza
        Trace.WriteLine("Entering Main-Trace");
        Debug.WriteLine("Entering Main-Debug");
        int number;
        Console.WriteLine("Please type a number between 1 and 10, and then press Enter");
        string userInput = Console.ReadLine();
        Debug.Assert(int.TryParse(userInput, out number), string.Format("Debug-Unable to parse {0} as integer", userInput));
        Trace.Assert(int.TryParse(userInput, out number), string.Format("Trace-Unable to parse {0} as integer", userInput));
        Trace.WriteLine($"Trace-The Current Value of userInput is: {userInput}");
        Debug.WriteLine($"Debug-The Current Value of userInput is: {userInput}");
        Trace.WriteLine($"Trace-The current value of number is:{number}");
        Debug.WriteLine("Debug-The current value of number is:{0}", number);
        Console.WriteLine("Press Enter to finish");
        Console.ReadLine();
        Trace.WriteLine("Exiting Main-Trace");
        Debug.WriteLine("Exiting Main-Debug");
        Debug.Unindent();
        Console.ReadKey();
    }
}