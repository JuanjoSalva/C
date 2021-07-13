using System;

namespace opera_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            desafio1();
        }

        /*Dado el punto inicial de la lista de código siguiente, agregará código para extraer, reemplazar y quitar
        partes del valor de input para generar el resultado deseado.

        Quantity: 5000
        Output: <h2>Widgets &reg;</h2><span>5000</span>

        Operaciones:
        -Establezca la variable quantity en el valor que se extrae entre las etiquetas <span> y </span>.
        -Establezca la variable output en el valor de la entrada, y después quite las etiquetas <div> y </div>.
        -Reemplace el carácter HTML &trade; por &reg; en la variable output.*/
        static void desafio1()
        {
            string input = "<div class='product'><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }
    }
}
