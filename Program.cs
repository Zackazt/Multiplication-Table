using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static int top_number;

        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            top_number = Int32.Parse(Console.ReadLine());
            print_table();
        }

        private static void print_table()
        {
            int x = 1;
            for (int i = 1; i <= top_number; i++)
            {
                for (int z = 1; z <= top_number; z++)
                {
                    if (Math.Floor(Math.Log10(z * x) + 1) == 1)
                    {
                        Console.Write((z * x) + "      ");
                    }
                    if (Math.Floor(Math.Log10(z * x) + 1) == 2)
                    {
                        Console.Write((z * x) + "     ");
                    }
                    if (Math.Floor(Math.Log10(z * x) + 1) == 3)
                    {
                        Console.Write((z * x) + "    ");
                    }
                    if (Math.Floor(Math.Log10(z * x) + 1) == 4)
                    {
                        Console.Write((z * x) + "  ");
                    }
                }
                x++;
                print_whitespace();              
            }
            Console.ReadLine();
        }

        private static void print_whitespace() 
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
            }
        }
    }
}
