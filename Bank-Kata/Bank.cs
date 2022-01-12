using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Kata
{
    public class Bank
    {
        public readonly List<Account> BankAccounts = new();
        public string BankName = null;

        public Bank(List<Account> newAccounts, string newName)
        {
            for (int i = newAccounts.Count - 1; i >= 0; i--)
            {
                BankAccounts.Add(newAccounts[i]);
            }

            BankName = newName;
        }
    }
}
