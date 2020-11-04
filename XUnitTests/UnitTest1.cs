using System;
using Xunit;
using Bank;
using System.Security;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PositiveinitialBalance()
        {
            decimal initialBalance = 0.00001M;
            Account account = new Account("BBU", initialBalance);
            Assert.True(account.Balance > 0);
        }
        [Fact]
        public void NegativeWithdrawalAmount()
        {
            decimal initialBalance = 10000, pop = -100;
            Account account = new Account("BBU", initialBalance);
            account.Withdrawal(pop, DateTime.Now, "Hammock");
            Assert.True(account.Balance == initialBalance);
        }
        [Fact]
        public void Overdrawn()
        {
            decimal initialBalance = 10000, pop = 10000;
            Account account = new Account("BBU", initialBalance);
            account.Withdrawal(pop, DateTime.Now, "Hammock");
            Assert.True(account.Balance == initialBalance);
        }
        [Fact]
        public void NegativeDepositAmount()
        {
            decimal initialBalance = 10000, pop = -100;
            Account account = new Account("BBU", initialBalance);
            account.Deposit(pop, DateTime.Now, "Hammock");
            Assert.True(account.Balance == initialBalance);
        }
    }
}
