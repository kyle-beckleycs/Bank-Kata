namespace Bank_Kata
{
    public interface ITransactions
    {
        /// <summary>
        /// passes amount to be deposited to receiving account.
        /// </summary>
        /// <param name="depositAmount"></param>
        public bool Deposit(double depositAmount);

        /// <summary>
        /// Queries account to initiate a withdrawl if possible.
        /// </summary>
        /// <param name="withdrawlAmount"></param>
        /// <returns></returns>
        public bool Withdrawl(double withdrawlAmount);

       /// <summary>
       /// Transfers specified amount from sending to receiving Account.
       /// </summary>
       /// <param name="sendingAccount"></param>
       /// <param name="receivingAccount"></param>
       /// <param name="transferAmount"></param>
       /// <returns></returns>
        public bool Transfer(Account sendingAccount, Account receivingAccount, double transferAmount);
    }
}