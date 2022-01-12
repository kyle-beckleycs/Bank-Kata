using Bank_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Bank_KataTests
{
    [TestClass]
    public class TransferUnitTest
    {
        /// <summary>
        /// Assert true: transfer from one account to another is successful
        /// Lists work as a stack. Individual account gets pushed to [1] in list. 
        /// This tripped me up for a moment, but TDD helped catch this mixup.
        /// </summary>
        [TestMethod]
        public void BasicTransfer ()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Checking" },
                new Account() { Owner ="KAR Global", Balance = 700000.00, InvestmentType = "Corporate", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[1].Transfer(TestBank.BankAccounts[0], TestBank.BankAccounts[1], 500.00);

            
            Assert.AreEqual(699500.00,TestBank.BankAccounts[0].Balance);
            Assert.AreEqual(1200.00,TestBank.BankAccounts[1].Balance);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Assert False: Transfer fails when account 1 has insufficent funds to complete transfer.
        /// </summary>
        [TestMethod]
        public void InsufficentFundsToTransfer()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" },
                new Account() { Owner ="KAR Global", Balance = 700000.00, InvestmentType = "Corporate", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[1].Transfer(TestBank.BankAccounts[1],TestBank.BankAccounts[0], 800.00);

            
            Assert.AreEqual(700000.00,TestBank.BankAccounts[0].Balance);
            Assert.AreEqual(700.00,TestBank.BankAccounts[1].Balance);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Assert False: Transer fails when funds to transfer is not a valid balance
        /// </summary>
        [TestMethod]
        public void impossibleTransferAmount()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" },
                new Account() { Owner ="KAR Global", Balance = 700000.00, InvestmentType = "Corporate", AccountType = "Checking" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[1].Transfer(TestBank.BankAccounts[0], TestBank.BankAccounts[1], -0.00);


            Assert.AreEqual(700000.00, TestBank.BankAccounts[0].Balance);
            Assert.AreEqual(700.00, TestBank.BankAccounts[1].Balance);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Assert False: Trnsaction cannot be made due to invalid transfer value.
        /// </summary>
        [TestMethod]
        public void negativeTransferValue()
        {
            var accountList = new List<Account>
            {
                new Account() { Owner ="Kyle Beckley", Balance = 700.00, InvestmentType = "Individual", AccountType = "Investment" },
                new Account() { Owner ="KAR Global", Balance = 700000.00, InvestmentType = "Corporate", AccountType = "Investment" }
            };
            Bank TestBank = new(accountList, "Test Bank");

            var actual = TestBank.BankAccounts[0].Transfer(TestBank.BankAccounts[0],TestBank.BankAccounts[1], -500.00);


            Assert.AreEqual(700000.00, TestBank.BankAccounts[0].Balance);
            Assert.AreEqual(700.00, TestBank.BankAccounts[1].Balance);
            Assert.IsFalse(actual); ;
        }

    }
}
