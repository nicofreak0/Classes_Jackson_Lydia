using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Jackson_Lydia
{
    internal class Greetings
    {

        public void Welcome()
        {
            Console.WriteLine("Welcome Traveler!");
        }


        public void Hello(string name) 
        { 
            Console.WriteLine($"{name}, it's a pleasure to have you here!");
        }

    }
}
