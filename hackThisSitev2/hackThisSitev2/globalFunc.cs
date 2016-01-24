using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSitev2
{
    class globalFunc
    {
        // General Global Functions
        public static void clearScreen()
        {
            Console.Clear();
        }
        public static void createLineDivider()
        {
            Console.WriteLine(("").PadRight(50, '-'));
        }

        // Default values for our ouputMessage (the default values will output no message)
        public static string messageToBeDisplayed = "";
        public static int typeOfMessage = 3;

        public static void outputMessage(string messageToBeDisplayed, int typeOfMessage)
        {
            // ERROR MESSAGE (typeOfMessage = 0)
            if (typeOfMessage == 0)
            {
                Console.WriteLine("Error");
                createLineDivider();
                Console.WriteLine(messageToBeDisplayed);
                globalFunc.typeOfMessage = 3;
                globalFunc.messageToBeDisplayed = "";
            }
            // NOTIFICATION MESSAGE (typeOfMessage = 1)
            else if (typeOfMessage == 1)
            {
                Console.WriteLine("Notification");
                createLineDivider();
                Console.WriteLine(messageToBeDisplayed);
                globalFunc.typeOfMessage = 3;
                globalFunc.messageToBeDisplayed = "";
            }
            // INFORMATION MESSAGE (typeOfMessage = 2)
            else if (typeOfMessage == 2)
            {
                Console.WriteLine("Information");
                createLineDivider();
                Console.WriteLine(messageToBeDisplayed);
                globalFunc.typeOfMessage = 3;
                globalFunc.messageToBeDisplayed = "";
            }
            // DEFAULT CASE NO OUPUT (typeOfMessage = 3)
            else if (typeOfMessage == 3)
            {
                globalFunc.typeOfMessage = 3;
                globalFunc.messageToBeDisplayed = "";
            }
        }
    }
}
