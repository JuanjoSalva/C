using System;
using static System.Console;

namespace herencia_implicita
{
    public class LotaltyCardNotFoundException : Exception
    {
        public LotaltyCardNotFoundException()
        {

        }
        public LotaltyCardNotFoundException(string message) : base(message){}
        public LotaltyCardNotFoundException(string message, Exception inner):base(message, inner){}
    }

    
}