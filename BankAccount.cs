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

        // static variable
        public static int totalAccounts = 0;
        public static String bankName = "Kabul Bank";
        // Constructor
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            balance = initialBalance;

            // incrementing static variable
            totalAccounts ++;
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

        // static methods

        public static void displayBankName()
        {
            Console.WriteLine(bankName);
        }
    }
}
