namespace Bank_Kata
{
    public interface ITransactions
    {
        /// <summary>
        /// Specify account and amount to be deposited into.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="depositAmount"></param>
        public bool Deposit(Account account, double depositAmount);

        /// <summary>
        /// Queries account to initiate a withdrawl if possible.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="withdrawlAmount"></param>
        /// <returns></returns>
        public bool Withdrawl(Account account, double withdrawlAmount);

        /// <summary>
        /// Account 1 is the funding account.
        /// Account 2 is the receiving account.
        /// </summary>
        /// <param name="account1"></param>
        /// <param name="account2"></param>
        public bool Transfer(Account account1, Account account2, double transferAmount);
    }
}