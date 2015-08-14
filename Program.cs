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
            int x = 1;
            for (int i = 1; i <= topNumber; i++)
            {
                for (int z = 1; z <= topNumber; z++)
                {                 
                    int d = (int)Math.Floor(Math.Log10(z * x) + 1);  //Removed the list of if statements and replaced it with 
                    Console.Write((z * x) + new String(' ', 7 - d)); //computation. 
                }
                x++;
                Console.WriteLine("\n\n");                           //Replaced the for loop for adding new lines.  
            }
            Console.ReadLine();
        }
    }
}
