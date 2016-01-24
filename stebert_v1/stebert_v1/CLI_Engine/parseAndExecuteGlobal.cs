using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stebert_v1
{
    class parseAndExecuteGlobal
    {
        private List<string> commandLine = new List<string>();
        private Dictionary<string, int> commandDict = new Dictionary<string, int>();
        private string userCommandString;
        private bool firstTimeRunning = true;

        private void preloadCommands()
        {
            #region Command Line Inputs
            // Displays creator info
            commandDict.Add(globalVar.command_whoami, 0);

            // Displays help for commands
            commandDict.Add(globalVar.command_help, 1); 

            // Print working directory
            commandDict.Add(globalVar.command_pwd, 2);

            // List files in current working directory
            commandDict.Add(globalVar.command_ls, 3);

            // Opens an editor for a text file database
            commandDict.Add(globalVar.command_open_wall, 4);

            // Clears the console screen
            commandDict.Add(globalVar.command_clear, 5);

            // Quits the console
            commandDict.Add(globalVar.command_quit, 6);

            // Opens notepad application
            commandDict.Add(globalVar.command_notepadApp, 7);

            // Return (enter key) functionality
            commandDict.Add(globalVar.enter_pressed, 8);
            #endregion

            firstTimeRunning = false;
        } 

        private void executeCommand(int commandIndex)
        {
            switch(commandIndex)
            {
                case 0:
                    Console.WriteLine("Created by Seunghyun Yoo");
                    Console.WriteLine("Or better known as Steebert, Steeb, or Sterb");
                    globalVar.blankLine();
                    break;
                case 1:
                    Console.WriteLine("Help section goes here");
                    globalVar.blankLine();
                    break;
                case 2:
                    Console.WriteLine("Print working directory goes here");
                    globalVar.blankLine();
                    break;
                case 3:
                    Console.WriteLine("List files in current working directory goes here");
                    globalVar.blankLine();
                    break;
                case 4:
                    Console.WriteLine("Kevin's wall of retard goes here");
                    globalVar.blankLine();
                    break;
                case 5:
                    Console.Clear();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                case 7:
                    notepadApplication noteApp = new notepadApplication();
                    noteApp.menuInterface();
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine(commandLine[0] + " is not recognized as an internal or external command.\nType !help for help with commands");
                    globalVar.blankLine();
                    break;
            }
        }

        private void splitCommand(string userCommand)
        {
            commandLine = userCommand.Split(' ').ToList();
            userCommandString = commandLine[0];
        }

        public void getAndExecuteCommand(string userCommand)
        {
            if(firstTimeRunning == true)
            {
                preloadCommands();
            }

            splitCommand(userCommand);

            userCommandString = userCommand;

            int commandOutput;

            if(commandDict.ContainsKey(userCommand) ==  true)
            {
                commandDict.TryGetValue(userCommand, out commandOutput);
                executeCommand(commandOutput);
            }
            else
            {
                executeCommand(-1);
            }
        }
    }
}
