using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class BankAccount
    {
// Fields / Insatnce Variables 
        private string accountNumber;
        private string ownerName;
        private decimal balance;

// Constructor
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            balance = initialBalance;
        }

        // Mehtods
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("----- BANK ACCOUNT -----");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Owner: {ownerName}");
            Console.WriteLine($"Balance: {balance}");
        }

    }
}
