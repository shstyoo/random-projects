using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSiteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Startup Text
            global.conClear();
            global.makeLine();
            global.message = "Choose a project";
            global.msgType = 2;
            global.displayMsg = true;
            
            // Program Menu Loop
            do
            {
                Console.WriteLine(
                    "Hack This Site Project");
                global.makeLine();
                Console.WriteLine(
                    "1. Unscramble the words");
                global.makeLine();
                global.dispMessage(global.msgType);
                global.makeLine();
                Console.Write(
                    "->:");
            } while (true);
        }
    }
}
