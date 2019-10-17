using System;
namespace Problem1
{
    public class Account
    {
        int money = 200000;

        public Account(int amount)
        {
            money = amount;
        }
        public void Deposit(int amount)
        {
            money += amount;
            Console.WriteLine("The amount you Deposit is : " + money + "\nThanks you for use our service . Have a nice day!");
            
        }
        public void Withdraw(int amount)
        {
            money -= amount;
            Console.WriteLine("The amount you Withdraw is : " + money + "\nThanks you for use our service . Have a nice day!");
         
        }
        public int Balance()
        {
            Console.WriteLine("The amount of your is : " + money + "\nThanks you for use our service . Have a nice day!");
            return money;
        }
    }
}
