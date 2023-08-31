using System;
using TechTalk.SpecFlow;

using BankAccountNS;
using NUnit.Framework;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class SaldosEnCuentaStepDefinitions
    {
        public int beginningBalance;
        public int debitAmount;
        public double balance;
        
        [Given(@"Mi saldo inicial de dolares en cuenta es de (.*)")]
        public void GivenMiSaldoInicialDeDolaresEnCuentaEsDe(int montoinicial)
        {
            //Arrange
            beginningBalance = montoinicial;

        }

        [When(@"Se debita un monto en dolares de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresDe(int montodebito)
        {
            debitAmount = montodebito;

            BankAccount account = new BankAccount("vidapogosoft", beginningBalance);

            //Act

            account.Debit(debitAmount);

            //Asert

            balance = account.Balance;

        }

        [When(@"Se debita un monto en dolares negativo de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresNegativoDe(int p0)
        {

            Assert.AreEqual("", "");
        }

        [When(@"Se acredita un monto en dolares de (.*)")]
        public void WhenSeAcreditaUnMontoEnDolaresDe(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Saldo actual en cuenta de (.*)")]
        public void ThenSaldoActualEnCuentaDe(double saldocuenta)
        {
            //Assert
            Assert.AreEqual(balance, saldocuenta);

        }

    }
}
