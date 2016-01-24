// Created by Seunghyun Yoo
// 10.23.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main Program Execution
            do
            {
                // Iterates through our main menu
                Loop.menuLoop();

                // After first iteration if user wants to quit
                if(global.quit == true)
                {
                    break;
                }
            } while (true);

        }
    }
}
