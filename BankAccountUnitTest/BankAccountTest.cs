using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrialExamInvariantUnitTest;

namespace BankAccountUnitTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void CheckOwnerOKTest()
        {
            var account = new BankAccount("John");
            try
            {
                Assert.AreEqual("John", account.CheckOwner());
            }
            catch (Exception)
            {
                
                Assert.Fail("Exception should not have happened");
            }
        }

        [TestMethod]
        public void CheckOwnerFailTest()
        {
            var account = new BankAccount("");

            try
            {
                account.CheckOwner();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Owner can not be null or empty", e.Message);
            }
        }

        [TestMethod]
        public void CheckInterestRateOK()
        {
            var account = new BankAccount("John", 1);
            
            try
            {
                Assert.AreEqual(1, account.CheckInterestRate());
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not have happened");
            }
        }

        [TestMethod]
        public void CheckZeroInterestRate()
        {
            var account = new BankAccount("John", 0);
            try
            {
                Assert.AreEqual(0, account.CheckInterestRate());
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not have happened");
            }
        }

        [TestMethod]
        public void CheckInterestRateFail()
        {
            var account = new BankAccount("John", -1);

            try
            {
                account.CheckInterestRate();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Interest rate must be >= 0", e.Message);
            }
        }
    }
}
