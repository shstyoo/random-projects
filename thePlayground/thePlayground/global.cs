// Created by Seunghyun Yoo
// 11.1.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace thePlayground
{
    class global
    {
        /* Formatting Classes
         * Classes that can be used to help format console output
         * for readability
         */ 

        // Make a line (for visibility) accross the console screen
        public static void makeLine()
        {
            Console.WriteLine(("").PadRight(50, '-'));
        }

        // Clear the Console Screen
        public static void conClear()
        {
            Console.Clear();
        }

        /* Global Variables
         */

        // Contains all the username/password stuff
        public static string userDatabase = "../../userDat.txt";

        /* Message
         * Displays error/notification/information
         * If the program requires to ouput a message (true) 
         * whatever is contained in global.message will be output
         * 
         * If you want to output a message the syntax is as follows:
         * 
         * global.message = "Error Message Goes Here";
         * global.displayMsg = true;
         * global.msgType = 1;
         */
        public static void dispMessage(int a)
        {
            if(global.displayMsg == false)
            {
                // Do Nothing
            }
            else if(global.displayMsg == true)
            {
                // Error
                if(a == 0)
                {
                    Console.WriteLine("Error\n" + global.message);
                    global.displayMsg = false;
                }
                // Notification
                else if(a == 1)
                {
                    Console.WriteLine("Notification\n" + global.message);
                    global.displayMsg = false;
                }
                // Information
                else if(a == 2)
                {
                    Console.WriteLine("Information\n" + global.message);
                    global.displayMsg = false;
                }
            }
        }
        // Message that contains an error/notification/information
        public static string message = "";
        // If FALSE message will not display
        public static bool displayMsg = false;
        // Type of message
        // 0 = Error
        // 1 = Notification
        // 2 = Info
        public static int msgType = 0;

        // Determines whether or not the user is logged in
        public static bool isLoggedIn = false;

        // Determines current user
        public static string userLogged = "";

        // Determine User LVL
        public static string userLvl = "1";

        // Determine current user password
        public static string userPassword = "";

        // REGEX Variables
        // ADD THIS SHIT IN NIGGA

    }
}
