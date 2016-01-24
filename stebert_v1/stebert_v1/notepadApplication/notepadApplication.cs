using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stebert_v1
{
    class notepadApplication
    {
        private string line;
        private string filename;
        private string choice;
        private string appNamespace = "notepad";

        public void menuInterface()
        {
            bool cont = true;
            while (cont == true)
            {
                Console.Clear();
                System.Console.WriteLine("Notepad MENU");
                System.Console.WriteLine("1. Open a File");
                System.Console.WriteLine("2. Remove a File");
                System.Console.WriteLine("3. Quit");
                System.Console.WriteLine("Choose an option");
                globalVar.blankLine();
                System.Console.Write(appNamespace);
                globalVar.inputLine();
                choice = System.Console.ReadLine();
                
                if(choice == "1")
                {
                    globalVar.blankLine();
                    System.Console.Write("Enter a Filename: ");
                    filename = System.Console.ReadLine();
                    openFile(filename);
                }
                else if(choice == "2")
                {
                    globalVar.blankLine();
                    System.Console.WriteLine("Removing a file goes here");
                }
                else if(choice == "3")
                {
                    globalVar.blankLine();
                    System.Console.WriteLine("Quitting...");
                    globalVar.blankLine();
                    break;
                }
            }
        } 

        private void opened_fileInterface()
        {
            parseAndExecuteNotepad object1 = new parseAndExecuteNotepad();
            bool cont = true;
            while (cont == true)
            {
                globalVar.blankLine();
                System.Console.Write(appNamespace);
                globalVar.directoryLine();
                System.Console.Write(filename);
                globalVar.inputLine();
                object1.getAndExecuteCommand(Console.ReadLine());
            }
        }

        private void viewEdit_fileInterface()
        {
            parseAndExecuteNotepad object1 = new parseAndExecuteNotepad();
            bool cont = true;
            while (cont == true)
            {

            }
        }

        private void openFile(string filename)
        {
            if(!File.Exists(filename))
            {
                System.Console.WriteLine("System Cannot find specified File");
                System.Console.WriteLine("Would you like to create a file with the specified name? (Y/N)");
                choice = System.Console.ReadLine();
                if(choice.ToUpper() == "YES" || choice.ToUpper() == "Y")
                {
                    System.Console.WriteLine("Creating file" + filename);
                    opened_fileInterface();
                }
                else if(choice.ToUpper() == "NO" || choice.ToUpper() == "N")
                {
                    System.Console.WriteLine("Could not open file.");
                }
                else
                {
                    System.Console.WriteLine("Incorrect Input");
                }
            }
            else if(File.Exists(filename))
            {
                opened_fileInterface();
            }
        }

        private void addLineToFile(string lineToAdd)
        {
            // Maybe functionallity for easy editing, or adding notes (kinda like Wall of Timmy prototype?)
        }
    }
}
