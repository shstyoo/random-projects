using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stebert_v1
{
    class parseAndExecuteNotepad
    {
        private List<string> commandLine = new List<string>();
        private Dictionary<string, int> commandDict = new Dictionary<string, int>();
        private Dictionary<string, int> viewEditDict = new Dictionary<string, int>();
        private string userCommandString;
        private bool firstTimeRunning = true;

        private void preloadCommands()
        {
            #region Command Line Inputs for the Notepad Application
            // Displays help for commands
            commandDict.Add(notepadVar.command_help, 1);

            // Displays creator info
            commandDict.Add(notepadVar.command_whoami, 0);

            // Open a file
            commandDict.Add(notepadVar.command_addEntry, 2);

            // Edit a file
            commandDict.Add(notepadVar.command_editEntry, 3);

            // View a file
            commandDict.Add(notepadVar.command_viewEntry, 4);
            #endregion

            #region Command Line Inputs for the View/Edit Application
            // Remove an entry
            viewEditDict.Add(notepadVar.command_deleteEntry, 0);

            // Search for an entry
            viewEditDict.Add(notepadVar.command_parseEntry, 1);

            // Edit an entry    
            viewEditDict.Add(notepadVar.command_editEntry, 2);

            // Display an entry
            viewEditDict.Add(notepadVar.command_displayEntry, 3);
            #endregion

            firstTimeRunning = false;
        }

        private void executeCommand(int commandIndex)
        {
            switch(commandIndex)
            {
                // Using File.WriteAllText(path, createText); to write to file
                // Also going to use a temporary file buffer for removal of lines, or editing in lines
                // Basically Original -> Temp Buffer -> User edits/removals -> Temp Buffer -> New File
            }
        }

        private void splitCommand(string userCommand)
        {
            commandLine = userCommand.Split(' ').ToList();
            userCommandString = commandLine[0];
        }

        public void getAndExecuteCommand(string userCommand)
        {
            if (firstTimeRunning == true)
            {
                preloadCommands();
            }

            splitCommand(userCommand);

            userCommandString = userCommand;

            int commandOutput;

            if (commandDict.ContainsKey(userCommand) == true)
            {
                commandDict.TryGetValue(userCommand, out commandOutput);
                executeCommand(commandOutput);
            }
            else
            {
                executeCommand(-1);
            }
        }

        public void getAndExecuteCommandViewEdit(string userCommand)
        {
            splitCommand(userCommand);

            userCommandString = userCommand;

            int commandOutput;

            if (commandDict.ContainsKey(userCommand) == true)
            {
                viewEditDict.TryGetValue(userCommand, out commandOutput);
                executeCommand(commandOutput);
            }
            else
            {
                executeCommand(-1);
            }
        }
    }
}
