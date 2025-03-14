﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();
            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountryOfOrigin = "Indonesia";
            coffee1.Strength = 3;

            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountryOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
        }
    }
    struct Coffee
    {
        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Strength { get; set; }
    }
}
