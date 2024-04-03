using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Jackson_Lydia
{
   //class name
    internal class Greetings
    {

        public void Welcome()
        {
            //prints to console a welcome message
            Console.WriteLine("Welcome Traveler!");
        }


        public void Hello(string name) 
        { 
            //prints to console the user'sname with a hello greating
            Console.WriteLine($"{name}, it's a pleasure to have you here!");
        }

    }
}
