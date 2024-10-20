using NUnit.Framework;
using BankSystem.Models;
using System.Collections.Generic;

namespace BankSystemTests
{
    
    public class EverydayAccountTests
    {
        private Everyday _everydayAccount;
        [SetUp]
        public void Setup()
        {
            _everydayAccount = new Everyday(1000);
        }

        [Test]
        public void Deposit_validAmount_updateBalance()
        {
            decimal depositAmount = 200;
            bool result = _everydayAccount.Deposit(depositAmount);

            Assert.That(result, Is.True);
            Assert.That(_everydayAccount.Balance, Is.EqualTo(1200));
        }
    }
}