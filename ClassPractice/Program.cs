using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            //display initial balance of each object
            Console.WriteLine(
                $"{account1.Name}'s balace: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance is: {account2.Balance:C}");

            //prompt for then read input
            Console.Write($"\nEnter deposit ammount for {account1.Name}\n");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"Adding {depositAmount:C} to {account1.Name}'s account balance\n");
            account1.Deposit(depositAmount);//add to account1's balance

            //display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance}");

            //prompt for then read input
            Console.Write($"\nEnter deposit ammount for {account2.Name}\n");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"Adding {depositAmount:C} to {account2.Name}'s account balance\n");
            account2.Deposit(depositAmount);//add to account1's balance

            //display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:c}");
        }
    }
}
