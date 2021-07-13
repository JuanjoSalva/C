using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q107
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ScoreCard
    {
        private Dictionary<string, int> players = new Dictionary<string, int>();
        public void Add(string name, int score)
        {
            players.Add(name, score);
        }
        // Option A - Correct
        public int this[string name]
        {
            get { return players[name]; }
        }

        // Option B - Incorrect
        //public Dictionary<string, int> Players { get => players; } // get{return players;}

        // Option C - Incorrect
        //public Dictionary<string, int> Players = new Dictionary<string, int>();

        // Opciont D - Incorrect
        //public int score(string name) { return players[name];}
    }
}
