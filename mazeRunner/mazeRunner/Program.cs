using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mazeLoad = false;
            bool loop = true;
            do
            {
                string choice = menu.displayMenu(0);
                if(choice == "1")
                {
                    Console.WriteLine("Loading Maze...");
                    Console.WriteLine("Loading Defualt 4x4 Maze...");
                    int[,] Maze = new int[4,4] {{0,0,0,0},
                                                  {0,0,0,0},
                                                  {0,0,0,0},
                                                  {0,0,0,0}};
                    mazeLoad = true;
                }
                else if(choice == "2")
                {
                    if(mazeLoad == false)
                    {
                        Console.WriteLine("You need to load a maze before you can run a maze");
                    }
                    else if(mazeLoad == true)
                    {
                        
                    }
                }
                else if(choice == "3")
                {
                    string choice2 = menu.displayMenu(2);
                    if(choice2 == "y")
                    {

                    }
                }
            }while(loop);
            
        }
    }
}
