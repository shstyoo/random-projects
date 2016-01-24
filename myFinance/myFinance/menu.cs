using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myFinance;

namespace myFinance
{
    static class menu
    {
        public static int mainMenu()
        {
            do
            {
                Console.WriteLine("MY FINANCE MAIN MENU");
                Console.WriteLine("1. Create New Finance Account");
                Console.WriteLine("2. Add Funds to Account");
                Console.WriteLine("3. Remove Funds from Account");
                Console.WriteLine("4. Quit");
                Console.Write("->: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        return 1;
                    case "2":
                        return 2;
                    case "3":
                        return 3;
                    case "4":
                        return 4;
                    default:
                        Console.WriteLine("Your input is not recognized");
                        Console.WriteLine("Please try again");
                        break;
                }
            } while (true);
        }
    }
}
