using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toprmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Prompt("Please type your name: ");
            Console.Clear();
            Console.WriteLine("The name entered was: " + name);
            Console.ReadKey();
        }//end main

        static string Prompt(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }//end class

   
    
}//end namespace
