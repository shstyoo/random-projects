using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class global
    {
        // If TRUE program will not ignore key words
        public static bool ignore = false;

        // If TRUE program will quit
        public static bool quit = false;

        // Array of words to ignore
        public static string[] ignoreWords;

        // Name of File
        public static string fileName = "";

        // Array of 20 most used words in file
        public static string[] words;
    }
}
