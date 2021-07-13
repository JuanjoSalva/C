using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _266
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("QUESTION 266\n You are developing a C# application. The application includes the following code segment. ");

            Console.WriteLine("\nclass Tree\n{\n\tpublic string Description {get; set;}\n\tpublic string Color{get; set;}	\n\tpublic int Id {get; set;}\n\tpublic decimal Height {get; set;}\n}\n\nDictionary<int, Tree> trees = new Dictionary<int, Tree>\n{\n\t{111,new Tree {Description = 'Fern', Color = 'Green', Id = 211, Height = 22.23m}},\n\t{112,new Tree {Description = 'Evergreen', Color = 'Green', Id = 317, Height = 11.13m}},\n\t{113,new Tree {Description = 'Birch', Color = 'White', Id = 198, Height = 37.91m}},\n\t{114,new Tree {Description = 'Ash', Color = 'Gray', Id = 192, Height = 17.13m}},\n\t{115,new Tree {Description = 'Crabapple', Color = 'Pink', Id = 196, Height = 8.45m}},\n};");
            Console.WriteLine("\ntrees.Add{115, new Tree{Description = 'Maple', Color = 'Red', Id = 214, Height = 28.16}};");


            Console.WriteLine("\nThe application fails at line 17 with the following error message: 'An item with the same key has already been added.'\n\nYou need to resolve the error.\n\nWhich code segment should you insert at line 16?\n");

            Console.WriteLine("\nA.  foreach(Tree tree in trees.Values.where(t => t.Id != 115))\nB.  if (!trees.ContainsKey(115))\nC.  foreach (int key in trees.Keys.Where(k => k != 115))\nD.  foreach (KeyValuePair<int, Tree> key in trees.Where(t => t.Key != 115)) ");

            Console.WriteLine("\nCorrect Answer: B");

            Console.WriteLine("\n\n Probamos con el mismo código.\n");


           Dictionary<int, Tree> trees = new Dictionary<int, Tree>
            {
                {111,new Tree {Description = "Fern", Color = "Green", Id = 211, Height = 22.23m}},
                {112,new Tree {Description = "Evergreen", Color = "Green", Id = 317, Height = 11.13m}},
                {113,new Tree {Description = "Birch", Color = "White", Id = 198, Height = 37.91m}},
                {114,new Tree {Description = "Ash", Color = "Gray", Id = 192, Height = 17.13m}},
                {115,new Tree {Description = "Crabapple", Color = "Pink", Id = 196, Height = 8.45m}},
            };

           
            foreach (var entry in trees)
                System.Console.WriteLine(entry.Key + ":" + entry.Value);

            Console.WriteLine("\nIntentamos añadir trees.Add(115, new Tree { Description = 'Maple', Color = 'Red', Id = 214, Height = 28.16m });");
            //Los foreach no son porqué no hace falta recorrer el Diccionario sino que con 
            //A.  foreach (Tree tree in trees.Values.where(t => t.Id != 115))

            //B
            if (!trees.ContainsKey(115))
            //C.  foreach (int key in trees.Keys.Where(k => k != 115))
            //D.  foreach (KeyValuePair<int, Tree> key in trees.Where(t => t.Key != 115))*/

                trees.Add(115, new Tree { Description = "Maple", Color = "Red", Id = 214, Height = 28.16m });
            else
                Console.WriteLine("\nNo he ha añadido el registro {115, tree} porque ya existe");
        }

         class Tree
        {
            public string Description { get; set; }
            public string Color { get; set; }
            public int Id { get; set; }
            public decimal Height { get; set; }
        }
    }

    
   
}
