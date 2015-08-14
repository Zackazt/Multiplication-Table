using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            printTable(Int32.Parse(Console.ReadLine()));              //Removed topNumber as a class variable and used it as a parameter instead.
        }

        private static void printTable(int topNumber)                 //Changed variable names to fit typical C# style.
        {
            for (int i = 1; i <= topNumber; i++)
            {
                for (int y = 1; y <= topNumber; z++)
                {
                    int z = x * y;
                    int d = (int)Math.Floor(Math.Log10(z) + 1);       //Removed the list of if statements and replaced it with 
                    Console.Write((z) + new String(' ', 7 - d));      //computation. 
                }
                Console.WriteLine("\n\n");                            //Replaced the for loop for adding new lines.  
            }
            Console.ReadLine();
        }
    }
}
