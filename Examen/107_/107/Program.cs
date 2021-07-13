using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("QUESTION 107\nYou are developing a class named Scorecard.The following code implements the Scorecard class.");

            Console.WriteLine("\npublic class Scorecard\n{\n\t	private Dictionary<string, int> players = new Dictionary<string, int>();\n\t	public void Add(string name, int score)\n\t	{\n\t\t		players.Add(name, score);\n\t    }\n}");
            Console.WriteLine("\nYou create the following unit test method to test the Scorecard class implementation:");
            Console.WriteLine("\n[TestMethod]\npublic void TestMethod1()\n{\n\t	Scorecard scorecard = new Scorecard();\n\t	scorecard.Add('Player1', 10);\n\t	scorecard.Add('Player2', 15);\n\t	int expectedScore = 15;\n\t	int actualScore = scorecard['Player2'];\n\t	Assert.AreEqual(expectedScore, actualScore);\n}      	");
            Console.WriteLine("\nYou need to ensure that the unit test will pass.\n\nWhat should you do?");
            Console.WriteLine("\nA. public int this[string name]\n{\n\t	get\n\t	{\n\t\t		return players[name];\n\t	}\n}");
            Console.WriteLine("\nB. public Dictionary<string, int> Players\n{\n\t	get\n\t	{\n\t\t		return players;\n\t	}\n}");
            Console.WriteLine("\n\nC.public Dictionary<string, int> Players = new Dictionary<string, int>; \n\nD.public int score(String name)\n{\n\t	return players[name];\n}");
            Console.WriteLine("\nCorrect Answer: A");
            Console.WriteLine("\nPara probarlo he construido 2 proyectos. Uno con la clase Scoredcard del ejercicio y otro Proyecto de Test con el metodo de\n prueba TestMethod1. Hay que lanzar los 2 proyectos");
        }
    }

    public class Scorecard
    {
        private Dictionary<string, int> players = new Dictionary<string, int>();
        public void Add(string name, int score)
        {
            players.Add(name, score);
        }

        //A
        public int this[string name]
        {
            get
            {
                return players[name];
            }
        }

        //B
        /*public Dictionary<string, int> Players
        {
            get
            {
                return players;
            }
        }*/

        //C
        //public Dictionary<string, int> Players = new Dictionary<string, int>; 

        //D
        /* public int score(String name)
         {
             return players[name];
         }*/
    }

}
