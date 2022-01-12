using Bank_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Bank_KataTests
{
    [TestClass]
    public class WithdrawlUnitTest
    {
        /// <summary>
        /// Assert true: An individual can withdraw a balance under their maximum balance
        /// </summary>
        [TestMethod]
        public void individualWithdraw()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 425.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(400.00);

            Assert.AreEqual(25.00, TestBank.BankAccounts[0].Balance);
            Assert.IsTrue(actual);
        }


        /// <summary>
        /// Assert true: An individual cannot withdraw a balance over their maximum balance
        /// </summary>
        [TestMethod]
        public void invalidIndividualWithdraw ()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 425.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(475.00);

            Assert.AreEqual(425.00, TestBank.BankAccounts[0].Balance);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Assert True: Individual investment accounts cannot withdraw over $500.00
        /// </summary>
        [TestMethod]
        public void IndividualMaximumWithdraw()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(500.00);

            Assert.AreEqual(200.00, TestBank.BankAccounts[0].Balance);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Assert false: Individual investment accounts cannot withdraw over $500.00
        /// </summary>
        [TestMethod]
        public void invalidIndividualMaximumWithdraw ()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(500.01);

            Assert.AreEqual(700.00, TestBank.BankAccounts[0].Balance);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Assert true: Investment Corporate accounts can withdraw over $500.00
        /// </summary>
        [TestMethod]
        public void corporateWithdraw()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 200000.00, InvestmentType = "Corporate", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(100000.00);

            Assert.AreEqual(100000.00, TestBank.BankAccounts[0].Balance);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Assert false: Withdraw cannot be made due to negative withdraw value.
        /// </summary>
        [TestMethod]
        public void NegativeWithdraw()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Withdrawl(-500.00);

            Assert.AreEqual(700.00, TestBank.BankAccounts[0].Balance);
            Assert.IsFalse(actual);
        }
    }
}
