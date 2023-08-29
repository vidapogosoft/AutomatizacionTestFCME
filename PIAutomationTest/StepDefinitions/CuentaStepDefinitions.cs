using System;
using TechTalk.SpecFlow;

using BankAccountNS;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class CuentaStepDefinitions
    {
        [Given(@"Mi saldo inicial de dolares en cuenta es de (.*)")]
        public void GivenMiSaldoInicialDeDolaresEnCuentaEsDe(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"Se debita un monto en dolares de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresDe(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Saldo actual en cuenta de (.*)")]
        public void ThenSaldoActualEnCuentaDe(int p0)
        {
            throw new PendingStepException();
        }
    }
}
