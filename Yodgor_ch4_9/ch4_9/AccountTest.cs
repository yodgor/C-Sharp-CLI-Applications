using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_9
{
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", 7.53m);

            // display initial balance of each object
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            decimal depositAmount;

            // prompt for then read input
            Console.Write("\nEnter deposit amount for account1: ");
            //depositAmount = decimal.Parse(Console.ReadLine());
            depositAmount = 9.99m;
            Console.WriteLine(
               $"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount); // add to account1's balance

            // display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            // prompt for then read input
            Console.Write("\nEnter deposit amount for account2: ");
            // depositAmount = decimal.Parse(Console.ReadLine());
            depositAmount = 7.77m;
            Console.WriteLine(
               $"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount); // add to account2's balance

            // display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            decimal withdrawalAmount; // withdrawal amount entered by user

            // prompt for then read input
            Console.Write("\nEnter withdrawal amount for account1: ");
            //withdrawalAmount = decimal.Parse(Console.ReadLine());
            withdrawalAmount = 11.11m;
            Console.WriteLine(
               $"subtracting {withdrawalAmount:C} from account1 balance\n");
            // subtract amount from account1
            account1.Withdraw(withdrawalAmount);

            // display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            // prompt for then read input
            Console.Write("\nEnter withdrawal amount for account2: ");
            //withdrawalAmount = decimal.Parse(Console.ReadLine());
            withdrawalAmount = 13.13m;
            Console.WriteLine(
               $"subtracting {withdrawalAmount:C} from account2 balance\n");
            // subtract amount from account1
            account2.Withdraw(withdrawalAmount);

            // display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");
            
            
            //Testing Withdraw
            Console.Write("\nEnter withdrawal amount for account2: ");
            withdrawalAmount = 14.13m;
            Console.WriteLine($"subtracting {withdrawalAmount:C} from account2 balance");
            account2.Withdraw(withdrawalAmount);
            // display balances
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
           

        }
    }
}
