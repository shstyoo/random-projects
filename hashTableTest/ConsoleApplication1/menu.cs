// Created by Seunghyun Yoo
// 10.23.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class menu
    {
        // Clear the console screen
        public static void clear()
        { Console.Clear(); }

        // Make your menu all pretty
        public static void makeLine()
        { Console.WriteLine(("").PadRight(50, '-')); }

        // Main Menu Display
        public static void mainMenu()
        {
            makeLine();
            Console.WriteLine("Main Menu");
            makeLine();
            Console.WriteLine("1. Upload a .txt file");
            Console.WriteLine("2. Print top 20 most used words");
            Console.WriteLine("3. Quit");
            Console.WriteLine("4. Clear Console");
            Console.Write("->:");
        }

        // Quit Screen
        public static void quitMenu()
        {
            makeLine();
            Console.WriteLine("Quit Menu");
            makeLine();
            Console.WriteLine("Are you sure you want to quit? [y/n]");
            Console.Write("->:");
        }

        // Upload Screen
        public static void uploadMenu()
        {
            makeLine();
            Console.WriteLine("Upload Options");
            makeLine();
            Console.WriteLine("Enter the name of the file you want to read");
            Console.WriteLine("Don't append a .txt to the end of the filename");
            Console.Write("->:");
        }
        // Print Screen
        public static void printMenu()
        {
            makeLine();
            Console.WriteLine("Print Options");
            makeLine();
            Console.WriteLine("1. Print Top 20 Words");
            Console.WriteLine("2. Choose which words are ignored in toplist");
            Console.WriteLine("3. Print which words are too be ignored");
            Console.WriteLine("4. Toggle ignore words on/off");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("->:");
        }

        // Print Screen Option 2
        public static void printMenu2()
        {
            makeLine();
            Console.WriteLine("Print Options 2");
            makeLine();
            Console.WriteLine("Enter the words you wish to ignore");
            Console.WriteLine("Separate each word with a comma (no spaces)");
            Console.Write("->:");
        }
    }
}
