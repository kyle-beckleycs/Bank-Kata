namespace Bank_Kata
{
    public class Account : ITransactions
    {
        private string  Owner;
        private double balance;
        private string  InvestmentType;
        private string  AccountType;

        public bool Withdrawl(Account account, double amount)
        {
        }

        public bool Deposit(Account account, double amount)
        {

        }

        public bool Transfer(Account account1, Account account2, double transferAmount)
        {

        }
    }
}