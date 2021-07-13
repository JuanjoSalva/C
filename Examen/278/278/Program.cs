using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 278\nDRAG DROP\nYou are developing an application that includes a class named Customer.\nThe application will output the Customer class as a structured XML document by using the following code\nsegment:");
            Console.WriteLine("\n\n<?xml version = '1.0' encoding = 'utf - 8'?>\n<Prospect xmlns:xsi= 'http://www.w3.org/2001/XMLShema-instance'\nxmlmns:xsd= 'http://www.w3.org/2001/XMLShema'\nProspectId='' xmlns='http://prospect'>\n<Fullname>David Jones</Fullname>\n<DateOfBirth>1977-06-11T00:00:00</DateOfBirth>\n</Prospect>");
            Console.WriteLine("\nYou need to ensure that the Customer class will serialize to XML.\n\nYou have the following code:");
            Console.WriteLine("\nSelect and Place:\n\nTarget1\npublic class Customer\n{\nTarget2\npublic Guid Id{get;set}\nTarget3\npublic string Name{get;set}\npublic DateTime DateOfBirth{get;set}\nTarget4\npublic int Tin{get;set}");
            Console.WriteLine("\nWhich code segments should you include in Target 1, Target 2, Target 3, and Target 4 to complete the code?\nTo answer, drag the appropriate code segments to the correct targets. Each code segment may be used once,\nmore than once, or not at all. You may need to drag the split bar between panes or scroll to view content.\n\nCorrect Answer:");
            Console.WriteLine("\n\n[XmlRoot('Prospect', Namespace = 'http://prospect')]\npublic class Customer\n{\n[XmlAttribute('ProspectId')]\npublic Guid Id{get;set}\n[XmlElement('FullName')]\npublic string Name{get;set}\npublic DateTime DateOfBirth{get;set}\n[XmlIgnore]\npublic int Tin{get;set}");
            
            Console.WriteLine("\\Para probar instanciamos un customer y le damos valores a Name: Juanjo, DateOfBirth: 5/1/1979 y Tin: 50");
            Customer cus = new Customer();
            cus.Name = "Juanjo";

            var dateString = "5/1/1979";
            DateTime date1 = DateTime.Parse(dateString,
                                      System.Globalization.CultureInfo.InvariantCulture);
            cus.DateOfBirth = date1;
            cus.Tin = 50;
            Console.WriteLine($"\n\nAhora los mostramos. Name: {cus.Name},  DateOfBith: {cus.DateOfBirth}, Tin: {cus.Tin}");


        }

        [XmlRoot("Prospect", Namespace = "http://prospect")]
        public class Customer
        {
            [XmlAttribute("ProspectId")]
            public Guid Id { get; set; }
            [XmlElement("FullName")]
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            [XmlIgnore]
            public int Tin { get; set; }
        }
    }
}
