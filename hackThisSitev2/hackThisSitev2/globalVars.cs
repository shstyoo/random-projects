using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSitev2
{
    class globalVars
    {
        /* This class contains all of the non-static variables that may need to be 
         * changed throughout the programs life. When browsing the code, if you find
         * a variable that is preceeded by globalVars you should know that the value
         * of the variable can be found in this class.
         * */

        #region Main Menu Options
        public static string nameOfMainMenu = "Main Menu";
        public static string[] mainMenuOptions = {
                                                     "1. Project Hub",
                                                     "2. About",
                                                     "3. Quit"
                                                 };
        #endregion Main Menu Options

        #region Project Hub Menu
        public static string nameOfProjectHubMenu = "Project Hub Menu";
        public static string[] projectHubOptions = {
                                                       "1. Project 1",
                                                       "2. Project 2",
                                                       "4. Project 4",
                                                       "6. Project 6"
                                                   };
        #endregion

        #region Project 1 Variables
        // Location of words and wordBank .txt files
        public static string wordsLocation = "words.txt";
        public static string wordBankLoc = "wordBank.txt";
        #endregion Project 1 Variables

        #region Project 2 Variables
        // Location of bitmap image 
        public static string imageLocation = "bitmap.png";
        public static Dictionary<string, string> letterToMorseDict = new Dictionary<string, string>
        {
            #region Letters To Morse Key
            {"a", ".-"},
            {"b", "-..."},
            {"c","-.-."},
            {"d","-.."},
            {"e","."},
            {"f","..-."},
            {"g","--."},
            {"h","...."},
            {"i",".."},
            {"j",".---"},
            {"k","-.-"},
            {"l",".-.."},
            {"m","--"},
            {"n","-."},
            {"o","---"},
            {"p",".--."},
            {"q","--.-"},
            {"r",".-."},
            {"s","..."},
            {"t","-"},
            {"u","..-"},
            {"v","...-"},
            {"w",".--"},
            {"x","-..-"},
            {"y","-.--"},
            {"z","--.."},
            {"1",".----"},
            {"2","..---"},
            {"3","...--"},
            {"4","....-"},
            {"5","....."},
            {"6","-...."},
            {"7","--..."},
            {"8","---.."},
            {"9","----."},
            {"0","-----"}
            #endregion
        };
        public static Dictionary<string, string> morseToLetterDict = letterToMorseDict.ToDictionary(x => x.Value, x => x.Key);
        
        #endregion Project 2 Variables

        #region Project 4 Variables
        public static string xmlLocation = "plotMe.xml";
        #endregion Project 4 Variables

        #region Project 6 Variables
        public static string decryptImageLoc = "ocrTest.png";
        #endregion
    }
}
