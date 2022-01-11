using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        }


        /// <summary>
        /// Assert true: An individual cannot withdraw a balance over their maximum balance
        /// </summary>
        [TestMethod]
        public void invalidIndividualWithdraw ()
        {

        }

        /// <summary>
        /// Assert false: Individual investment accounts cannot withdraw over $500.00
        /// </summary>
        [TestMethod]
        public void invalidIndividualMaximumWithdraw ()
        {

        }

        /// <summary>
        /// Assert true: Investment Corporate accounts can withdraw over $500.00
        /// </summary>
        [TestMethod]
        public void corporateWithdraw()
        {

        }

        /// <summary>
        /// Assert false: Withdraw cannot be made due to invalid withdraw value.
        /// </summary>
        [TestMethod]
        public void impossibleWithdraw()
        {

        }
    }
}
