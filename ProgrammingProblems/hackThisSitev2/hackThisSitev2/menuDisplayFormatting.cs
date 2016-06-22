using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSitev2
{
    class menuDisplayFormatting
    {
        private string[] menuOptions;

        public menuDisplayFormatting()
        {
            // Null Constructor
        }

        public void setMenuOptions(string[] menuOptions)
        {
            this.menuOptions = menuOptions;
        }

        public void displayMenuOptions(string nameOfMenu)
        {
            globalFunc.clearScreen();

            globalFunc.createLineDivider();

            Console.WriteLine(nameOfMenu);

            globalFunc.createLineDivider();

            // Print out each menu option
            for(int optionNumber = 0; optionNumber < menuOptions.Length; optionNumber++)
            {
                Console.WriteLine(menuOptions[optionNumber]);
            }

            globalFunc.createLineDivider();

            globalFunc.outputMessage(globalFunc.messageToBeDisplayed, globalFunc.typeOfMessage);

            globalFunc.createLineDivider();

            Console.Write("->: ");
        }
    }
}
