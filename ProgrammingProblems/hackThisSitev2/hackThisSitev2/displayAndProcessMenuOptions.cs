using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSitev2
{
    class displayAndProcessMenuOptions
    {
        public static void mainMenuDisplay()
        {
            menuDisplayFormatting mainMenu = new menuDisplayFormatting();
            mainMenu.setMenuOptions(globalVars.mainMenuOptions);
            mainMenu.displayMenuOptions(globalVars.nameOfMainMenu);
            processMainMenuOptions();
        }
        public static void processMainMenuOptions()
        {
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                projectHubDisplay();
            }
            else if(userInput == "2")
            {
                globalFunc.clearScreen();
                globalFunc.createLineDivider();
                Console.WriteLine("ABOUT: This Program was created by Seunghyun Yoo\n" +
                                  "It contains all the missions from HackThisSite\n\n" +

                                  "Press Any Key to Exit"
                                  );
                Console.ReadLine();
                mainMenuDisplay();
            }
            else if(userInput == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                globalFunc.messageToBeDisplayed = "Incorrect Input! Please try again";
                globalFunc.typeOfMessage = 0;
                mainMenuDisplay();
            }
        }

        public static void projectHubDisplay()
        {
            menuDisplayFormatting projectHub = new menuDisplayFormatting();
            projectHub.setMenuOptions(globalVars.projectHubOptions);
            projectHub.displayMenuOptions(globalVars.nameOfProjectHubMenu);
            processProjectHubOptions();
        }
        public static void processProjectHubOptions()
        {
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                // Write Code that goes to project 1 here.
                project1 project1 = new project1();
                project1.unscrambleWords();
            }
            else if(userInput == "2")
            {
                project2 project2 = new project2();
                project2.parseThruBitmap();
                Console.ReadLine();
            }
            else if(userInput == "3")
            {
                // Project 3 goes here
            }
            else if(userInput == "4")
            {
                project4 project4 = new project4();
                project4.parseThroughXML();
                mainMenuDisplay();
            }
            else if(userInput == "5")
            {
                // Project 5 goes here
            }
            else if(userInput == "6")
            {
                project6 project6 = new project6();
                project6.analyzeFile();
            }
        }
    }
}
