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
    class programLoop
    {
        
        // The Menu you wish to loop through requires the index a
        public static int menuLoop(int a)
        {
            // Loop Control
            bool loop = true;

            // Do-While loop for our menu
            do
            {
                if(a == globalVar.mainMenu)
                {
                    menu.display(globalVar.mainMenu);
                    string choice = Console.ReadLine();
                    if(choice == "1")
                    {
                        return globalVar.one;
                    }
                    else if(choice == "2")
                    {
                        return globalVar.two;
                    }
                    else if(choice == "3")
                    {
                        return globalVar.thr;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect intput, please try again");
                        loop = true;
                    }
                }
                else if(a == globalVar.quitScreen)
                {
                    menu.display(globalVar.quitScreen);
                    string choice = Console.ReadLine().ToUpper();
                    if(choice == "Y")
                    {
                        Console.WriteLine("Now Quitting...");
                        return globalVar.zer;
                    }
                    else if (choice == "N")
                    {
                        Console.WriteLine("Returning to Menu");
                        return globalVar.one;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Statement");
                        loop = true;
                    }
                }
            } while (loop);

            // Default Return Statement
            return globalVar.nin;
        }
    }
}
