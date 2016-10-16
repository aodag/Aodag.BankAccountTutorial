using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Aodag.BankAccountTutorial.Test
{
    public class TestBankAccount
    {
        public TestBankAccount()
        {
        }

        [Fact]
        public void TestDeposit()
        {
            var target = new BankAccount();
            target.Deposit(10);
            target.Deposit(3);
            Assert.Equal(13, target.Balance);
        }

        [Fact]
        public void TestWithdraw()
        {
            var target = new BankAccount(10);
            target.Withdraw(3);
            Assert.Equal(7, target.Balance);
        }

        [Fact]
        public void TestWithdrawNotEnoughFunds()
        {
            var target = new BankAccount(3);
            Assert.Throws<NotEnoughFundsException>(() => target.Withdraw(4));
        }
    }
}
