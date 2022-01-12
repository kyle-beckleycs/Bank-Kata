using System;

namespace Bank_Kata
{
    public class Account : ITransactions
    {
        public string Owner { get; set; }
        public double Balance { get; set; }
        public string InvestmentType { get; set; }
        public string AccountType { get; set; }

        public bool Withdrawl(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Amount presented is negative or not a number");
                    return false;
                }
                else if (amount > Balance)
                {
                    Console.WriteLine("Account does not have available balance to withdraw.");
                    return false;
                }
                else if (amount > 500.00)
                {
                    if (InvestmentType.Equals("Individual"))
                    {
                        Console.WriteLine("Individual account cannot withdraw over $500.00.");
                        return false;
                    }
                    else
                    {
                        Balance -= amount;
                        return true;
                    }
                }
                else
                {
                    Balance -= amount;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Amount presented is negative or not a number");
                    return false;
                }
                else
                {
                    Balance += amount;
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Transfer(Account sendingAccount, Account receivingAccount, double transferAmount)
        {
            try
            {
                if (transferAmount <= 0)
                {
                    Console.WriteLine("Amount presented is negative or not a number");
                    return false;
                }
                else if (transferAmount > sendingAccount.Balance)
                {
                    Console.WriteLine("Account does not have available balance to transfer.");
                    return false;
                }
                else
                {
                    sendingAccount.Balance -= transferAmount;
                    receivingAccount.Balance += transferAmount;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}