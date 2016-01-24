// Created by Seunghyun Yoo
// At:      10.16.2014
// Latest:  10.22.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunnerv2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                // Start the program by calling the programLoop driver
                int choice = programLoop.menuLoop(globalVar.mainMenu);

                // This is where we upload a maze
                if (choice == globalVar.one)
                {
                    // Code for uploading a maze goes here

                    // Default output
                    Console.WriteLine("We will upload the default 10x10 maze");
                    Console.WriteLine("This class currently does nothing");

                    // THIS IS FOR DEBUGGING PURPOSES
                    Console.WriteLine("Press any key to return to main menu");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                        // Returns to main menu
                    }
                    else
                    {
                        // Returns to main menu
                    }
                }
                else if (choice == globalVar.two)
                {
                    // Large array (16x20)
                    mazeRunner mazeTest = new mazeRunner(globalVar.defMaze);

                    // Medium Array (9x10)
                    //mazeRunner mazeTest = new mazeRunner(globalVar.testMaze);

                    // Small Array (4x5)
                    //mazeRunner mazeTest = new mazeRunner(globalVar.testMaze2);

                    mazeTest.solve();
                    mazeTest.print();
                    // THIS IS FOR DEBUGGING PURPOSES
                    Console.WriteLine("Press any key to return to main menu");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                       // Returns to main menu
                    }
                    else
                    {
                        // Returns to main menu
                    }
                }
                else if (choice == globalVar.thr)
                {
                    int choice3 = programLoop.menuLoop(globalVar.quitScreen);
                    if(choice3 == globalVar.zer)
                    {
                        break;
                    }
                    else if(choice3 == globalVar.one)
                    {
                        // Returns to main menu
                    }
                }
                else { }
            } while (loop);
        }
    }
}
