using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance
{
    class Program
    {
        static void Main(string[] args)
        {

            bankAcct acct = new bankAcct();
            bool loop = true;
            do
            {
                int choice = menu.mainMenu();
                if (choice == 1)
                {
                    Console.WriteLine("What is your desired Username?");
                    Console.Write("->: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the current balance on the account?");
                    Console.Write("->: ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    acct.name = name;
                    acct.balance = balance;
                }
                else if (choice == 2)
                {
                    acct.addFunds();
                }
                else if (choice == 3)
                {
                    acct.rmvFunds();
                }
                else
                {
                    loop = false;
                }
            } while (loop == true);
        }
    }
}
