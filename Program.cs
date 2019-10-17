using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi there , We have three service for you : ");

            Console.WriteLine(" 1 for Deposit");
            Console.WriteLine(" 2 for Withdraw");
            Console.WriteLine(" 3 for check your Balance");

            Console.WriteLine("What service do you want ?");
            
            int result;

            if (int.TryParse(Console.ReadLine(), out result))
            {
                if(result == 1)
                {
                    Account acc = new Account(200000);
                    Console.WriteLine("Please enter your money you want to deposit : ");
                    string str = Console.ReadLine();
                    int a = Convert.ToInt32(str);
                    acc.Deposit(a);
                }
                else if (result == 2)
                {
                    Account acc = new Account(200000);
                    Console.WriteLine("Please enter your money you want to withdraw : ");
                    string str1 = Console.ReadLine();
                    int a = Convert.ToInt32(str1);
                    acc.Withdraw(a);
                }
                else if ( result == 3)
                {
                    Account acc = new Account(200000);
                    acc.Balance();
                }
                Console.ReadLine();

            }
            
        }
    }
}
