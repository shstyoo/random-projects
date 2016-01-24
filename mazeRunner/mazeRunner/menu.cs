using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunner
{
    class menu
    {
        public static string displayMenu(int a)
        {
            if(a == 0)
            {
                Console.WriteLine("Maze Runner");
                Console.WriteLine("1. Load Maze");
                Console.WriteLine("2. Run through Maze");
                Console.WriteLine("3. Quit");
                Console.Write("->: ");
                string choice = Console.ReadLine();
                return choice;
            }
            else if(a == 1)
            {
                Console.WriteLine("What depth of search would you like?");
                string choice = Console.ReadLine();
                return choice;
            }
            else if(a == 2)
            {
                Console.WriteLine("Are you sure you want to quit [y/n]?");
                string choice = Console.ReadLine();
                return choice;
            }
            else if(a == 3)
            {
                Console.WriteLine("Running through the maze...");
                return "0";
            }
            else if(a == 4)
            {
                Console.WriteLine("...");
                return "0";
            }
            else
            {
                Console.WriteLine("Incorrect Choice");
                return "0";
            }
        }
    }
}
