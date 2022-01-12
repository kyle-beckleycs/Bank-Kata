using Bank_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Bank_KataTests
{
    [TestClass]
    public class DepositUnitTest
    {
        /// <summary>
        /// Assert true: A deposit can be made to the account.
        /// </summary>
        [TestMethod]
        public void InitiateDeposit()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Deposit(500.00);

            Assert.AreEqual(1200.00, TestBank.BankAccounts[0].Balance);
            Assert.IsTrue(actual);
        }


        /// <summary>
        /// Assert false: An individual cannot deposit a negative value.
        /// </summary>
        [TestMethod]
        public void InvalidIndividualDeposit()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Deposit(-500.00);

            Assert.AreEqual(700.00, TestBank.BankAccounts[0].Balance);
            Assert.IsFalse(actual);
        }

  

        /// <summary>
        /// Assert false: Deposit cannot be made due to invalid withdraw value.
        /// </summary>
        [TestMethod]
        public void ImpossibleDeposit()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Deposit(0.00);

            Assert.AreEqual(700.00, TestBank.BankAccounts[0].Balance);
            Assert.IsFalse(actual);
        }
    }
}
