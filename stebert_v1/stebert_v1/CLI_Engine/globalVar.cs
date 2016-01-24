using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stebert_v1
{
    class globalVar
    {
        #region Console Commands (string values stored here)
        public static string command_whoami = "whoami";
        public static string command_help = "!help";
        public static string command_pwd = "pwd";
        public static string command_ls = "ls";
        public static string command_open_wall = "open_wall";
        public static string command_clear = "clear";
        public static string command_quit = "quit";
        public static string command_notepadApp = "notepad";
        public static string enter_pressed = "";
        #endregion

        #region Private Commands (for internal use only)
        public static void blankLine() { Console.WriteLine(" "); }
        public static void bufferLine() { Console.Write("-"); }
        public static void directoryLine() { Console.Write("/"); }
        public static void inputLine() { Console.Write("=$ ");  }
        public static void makeLine() { Console.WriteLine(("").PadRight(50, '-')); }
        #endregion

    }
}
