using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class Loop
    {

        // Main Menu Loop
        public static void menuLoop()
        {
            do
            {
                menu.mainMenu();
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Loop.uploadLoop();
                    break;
                }
                else if(choice == "2")
                {
                    Loop.printLoop();
                    break;
                }
                else if (choice == "3")
                {
                    Loop.quitLoop();
                    break;
                }
                else if(choice == "4")
                {
                    menu.clear();
                }
                else
                {
                    Console.WriteLine("Please choose a valid input");
                }
            } while (true);
        }

        // Quit Screen Loop
        public static void quitLoop()
        {
            do
            {
                menu.quitMenu();
                string choice = Console.ReadLine();
                if(choice.ToUpper() == "Y")
                {
                    Console.WriteLine("Now Quitting");
                    global.quit = true;
                    break;
                }
                else if(choice.ToUpper() == "N")
                {
                    Console.WriteLine("Returning to Main Menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a valid input");
                }
            } while (true);
        }

        // Upload Screen Loop
        public static void uploadLoop()
        {
            menu.uploadMenu();
            string choice = Console.ReadLine();
            string _choice = choice + ".txt";
            if(File.Exists(_choice))
            {
                Console.WriteLine("Uploading File!");
                global.fileName = _choice;
                Console.WriteLine(global.fileName + " has been successfully uploaded!");
            }
            else if(!File.Exists(_choice))
            {
                Console.WriteLine("This filename does not exist");
            }
        }

        // Print Screen Loop
        public static void printLoop()
        {
            do
            {
                menu.printMenu();
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    textTable test1 = new textTable();
                    test1.readFile(global.ignoreWords, global.fileName);
                    break;
                }
                else if (choice == "2")
                {
                    Loop.printLoop2();
                    break;
                }
                else if (choice == "3")
                {
                    int x = 1;
                    menu.makeLine();
                    Console.WriteLine("Words to be Ignored");
                    menu.makeLine();
                    foreach(string word in global.ignoreWords)
                    {
                        Console.Write(x + ".");
                        Console.WriteLine(word);
                        x++;
                    }
                }
                else if (choice == "4")
                {
                    // Displays current state of global.ignore (found in global.cs)
                    Console.Write("Ignore words is currently: ");
                    if (global.ignore == true)          { Console.Write("ON"); }
                    else if (global.ignore == false)    { Console.Write("OFF"); }

                    // User can choose whether or not to toggle global.ignore on or off
                    Console.WriteLine(Environment.NewLine);
                    menu.makeLine();
                    Console.WriteLine("Would you like to toggle:");
                    Console.WriteLine("1. ON");
                    Console.WriteLine("2. OFF");
                    string _choice = Console.ReadLine();
                    if(_choice == "1")                  { global.ignore = true; }
                    else if (_choice == "2")            { global.ignore = false; }

                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a valid input");
                }
            } while (true);
        }

        // Print Screen 2 Loop
        public static void printLoop2()
        {
            // This splits the string of words user wants to ignore into the global array
            menu.printMenu2();
            string b = Console.ReadLine();
            string[] b2 = b.Split(',');
            global.ignoreWords = new string[b2.GetLength(0)];
            for(int x = 0; x < b2.GetLength(0); x++)
            {
                global.ignoreWords[x] = b2[x];
            }
        }
    }
}
