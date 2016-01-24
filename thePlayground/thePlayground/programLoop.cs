// Created by Seunghyun Yoo
// 11.1.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace thePlayground
{
    class programLoop
    {
        // All the loops correspond to their display message
        // For example launchMenu() corresponds to launchLoop()... etc.

        // Main loop for the lauching page
        public static void launchLoop()
        {
            do
            {
                menuDisplay.launchMenu();
                string input = Console.ReadLine();
                if(input == "1")
                {
                    programLoop.loginLoop();
                }
                else if(input == "2")
                {
                    programLoop.createLoop();
                }
                else if(input == "3")
                {
                    // Exit the program
                    Environment.Exit(0);
                }
                else
                {
                    // Error message display (if applicable)
                    global.message = "Please input a valid option";
                    global.displayMsg = true;
                    global.msgType = 0;
                }
            } while (true);
        }

        // Main Menu Loop
        // As you add in more programs, just make sure to add the more options into 
        // the IF loop for global.isLoggedIn == true :)
        public static void menuLoop()
        {
            if(global.isLoggedIn == true)
            {
                menuDisplay.loggedInMenu();
                string input = Console.ReadLine();

                // ADD IN MORE OPTIONS AS THEY COME
                // Maybe look into REGEX for these menu options?
                // Calendar option
                if(input == "1")
                {

                }
                // Notes option
                else if(input == "2")
                {

                }
                // Logout option
                else if(input == "3")
                {

                }
            }
            else if(global.isLoggedIn == false)
            {
                // Something something error here
            }
        }

        // Login Loop (Username + Password)
        public static void loginLoop()
        {
            do
            {
                string line;
                bool userFound = false;
                menuDisplay.loginMenu();
                string input = Console.ReadLine().ToLower();
                StreamReader file = new StreamReader(global.userDatabase);

                // Read each line in from file to find username
                while ((line = file.ReadLine()) != null)
                {
                    string[] line2 = line.Split(',');

                    // If username exists, show info and go to password screen
                    if (line2[0] == input)
                    {
                        global.message = "Username Found!\nPress 2 at any time to go back";
                        global.displayMsg = true;
                        global.msgType = 1;

                        do
                        {
                            menuDisplay.loginMenuPswd();
                            string input2 = Console.ReadLine();
                            if (input2 == line2[1])
                            {
                                global.message = "Welcome: " + input + ".";
                                global.displayMsg = true;
                                global.msgType = 1;
                                global.isLoggedIn = true;
                                global.userLogged = input;
                                global.userPassword = line2[1];
                                global.userLvl = line2[2];
                                userFound = true;
                                break;
                            }
                            else if (input2 == "2")
                            {
                                programLoop.launchLoop();
                            }
                            else
                            {
                                global.message = "Incorrect Password!\nPress 2 at any time to go back";
                                global.displayMsg = true;
                                global.msgType = 0;
                            }
                        } while (true);
                    }
                    if(userFound == true)
                    {
                        break;
                    }
                }
                file.Close();
                if(userFound == false)
                {
                    global.message = "User not found!\n";
                    global.displayMsg = true;
                    global.msgType = 0;
                    programLoop.launchLoop();
                }
                else if(userFound == true)
                {
                    break;
                }
            } while (true);

            // Take user to menu loop if user found
            programLoop.menuLoop();
        }

        // Create user loop (Username + password)
        public static void createLoop()
        {
            do
            {
                string line;
                bool cont = true;
                menuDisplay.createMenu();
                string input = Console.ReadLine().ToLower();
                StreamReader file = new StreamReader(global.userDatabase);

                // Read each line in from file to see if username already exists
                while((line = file.ReadLine()) != null)
                {
                    string[] line2 = line.Split(',');

                    // If username exists, throw error message
                    if(line2[0] == input)
                    {
                        global.message = "Username: " + input + " already exists. Please select a different name";
                        global.displayMsg = true;
                        global.msgType = 0;
                        cont = false;
                        break;
                    }
                }
                file.Close();

                // If username exists, loop back to starting point
                if(cont == false)
                {
                    programLoop.createLoop();
                }

                // If username doesn't exist, we create a new user
                else
                {
                    global.message = "Username: " + input + " successfully created.";
                    global.displayMsg = true;
                    global.msgType = 1;
                    menuDisplay.createMenuPswd();
                    string input2 = Console.ReadLine();

                    // The output format for the userDat.txt is username,password,userLevel
                    using (StreamWriter file2 = new StreamWriter(global.userDatabase, true))
                    {
                        file2.WriteLine(input + "," + input2 + ",1\n");
                    }
                    global.message = "User account successfully created.";
                    global.displayMsg = true;
                    global.msgType = 1;
                    programLoop.launchLoop();
                }
            } while (true);
        }
    }
}
