// Created by Seunghyun Yoo
// At:      10.16.2014
// Latest:  10.19.2014


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunnerv2
{
    class menu
    {
        // Make your menu pretty
        private static void makeLine()
        { Console.WriteLine(("").PadRight(50, '-')); }

        // Clear the console screen (makes things pretty)
        private static void clear()
        { Console.Clear(); }
 
        /* 
         * Displays all of our dialog boxes
         * Displays a specific box based on index a
         * Indexes can be found in globalVar.cs
         */
        public static void display(int a)
        {
            // Main Menu
            if (a == globalVar.mainMenu)
            {
                clear();
                makeLine();
                Console.WriteLine("Main Menu");
                makeLine();
                Console.WriteLine("1. Upload a Maze");
                Console.WriteLine("2. Solve an uploaded Maze");
                Console.WriteLine("3. Quit");
                Console.Write("->: ");
            }

            // Quit Screen
            else if(a == globalVar.quitScreen)
            {
                clear();
                makeLine();
                Console.WriteLine("Quit Screen");
                makeLine();
                Console.WriteLine("Are you sure you want to quit?");
                Console.WriteLine("[y/n]");
                Console.Write("->: ");
            }

            // Maze Running Dialog
            else if(a == globalVar.mazeDia)
            {
                clear();
                Console.WriteLine("Now Running Maze...");
            }

            // Maze Running Dialog 2
            else if(a == globalVar.mazeDia2)
            {
                Console.WriteLine("...");
            }
        }
    }
}
