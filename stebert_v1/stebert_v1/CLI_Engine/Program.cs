using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stebert_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            parseAndExecuteGlobal object1 = new parseAndExecuteGlobal();
            bool cont = true;
            while(cont == true)
            {
                globalVar.inputLine();
                object1.getAndExecuteCommand(Console.ReadLine());
            }
        }
    }
}
