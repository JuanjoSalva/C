using System;

namespace _06Estrucruras
{
    class Program
    {
        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {
            Day favoriteDay = Day.Friday;
            Console.WriteLine(favoriteDay);
            favoriteDay = (Day)1;
            Console.WriteLine(favoriteDay);
            Console.WriteLine((int)favoriteDay);


            Coffee colombia = new Coffee();
            colombia.Strength = 8;
            colombia.Bean = "una";
            colombia.CountryOfOrigin = "Colombia";
            colombia.saludo();

            Coffee brasil = new Coffee(7, "otra", "Brasil");
            brasil.saludo();
        }
    }

    public struct Coffee
    {
        // This is the custom constructor.
        public Coffee(int strength, string bean, string countryOfOrigin)
        {
            this.Strength = strength;
            this.Bean = bean;
            this.CountryOfOrigin = countryOfOrigin;
        }
        // These statements declare the struct fields and set the default values.
        public int Strength;
        public string Bean;
        public string CountryOfOrigin;
        // Other methods, fields, properties, and events.
        public void  saludo(){
            Console.WriteLine($"Soy café de semilla: {this.Bean} con fortaleza: {this.Strength} y de origen: {this.CountryOfOrigin}");
        }
    }
}
