using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSiteProject
{
    class global
    {
        // Clear the Console
        public static void conClear()
        {
            Console.Clear();
        }

        // Make line function
        public static void makeLine()
        {
            Console.WriteLine(("").PadRight(50, '-'));
        }

        // Read each word into an array
        public static string[] words = System.IO.File.ReadAllLines("word.txt");
        public static string[] wordList = System.IO.File.ReadAllLines("wordList.txt");

        // This is the Notification/Message script that accompanies every menu in this code.
        public static void dispMessage(int a)
        {
            if(global.displayMsg == false)
            {
                // Do Nothing
            }
            else if(global.displayMsg == true)
            {
                // Error Notification
                if(a == 0)
                {
                    Console.WriteLine("Error\n" + global.message);
                    global.displayMsg = false;
                }
            }
        }
        // Message that contains a[n] error/notification/information
        public static string message = "";
        // If FALSE message will not display
        public static bool displayMsg = false;
        // Type of message
        // 0 - Error
        // 1 - Notification
        // 2 - Info
        public static int msgType = 0;
    }
}
