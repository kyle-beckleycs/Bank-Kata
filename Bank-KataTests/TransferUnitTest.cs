using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Bank_KataTests
{
    class TransferUnitTest
    {
        /// <summary>
        /// Assert true: transfer from one account to another is successful
        /// </summary>
        [TestMethod]
        public void BasicTransfer (){

        }

        /// <summary>
        /// Assert False: Transfer fails when account 1 has insufficent funds to complete transfer.
        /// </summary>
        [TestMethod]
        public void insufficentFundsToTransfer()
        {

        }

        /// <summary>
        /// Assert False: Transer fails when funds to transfer is not a valid balance
        /// </summary>
        [TestMethod]
        public void impossibleTransferAmount()
        {

        }

        /// <summary>
        /// Assert False: Trnsaction cannot be made due to invalid transfer value.
        /// </summary>
        [TestMethod]
        public void negativeTransferValue()
        {

        }

    }
}
