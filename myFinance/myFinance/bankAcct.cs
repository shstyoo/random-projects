using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance
{
    class bankAcct
    {
        public bankAcct()
        {
            // Empty Constructor
        }
        public bankAcct(double balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }

        public double balance { get; set; }

        public string name { get; set; }

        public void addFunds()
        {
            double add;
            Console.WriteLine("How much are you adding?");
            Console.WriteLine("Your prior balance is: " + balance);
            add = Convert.ToDouble(Console.ReadLine());
            balance += add;
            Console.WriteLine("Your new balance is: " + balance);
        }

        public void rmvFunds()
        {
            double remove;
            Console.WriteLine("How much would you like to remove?");
            Console.WriteLine("Your prior balance is: " + balance);
            remove = Convert.ToDouble(Console.ReadLine());
            balance -= remove;
            Console.WriteLine("Your new balance is: " + balance);
        }
    }
}
