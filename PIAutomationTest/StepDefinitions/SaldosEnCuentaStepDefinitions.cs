using System;
using TechTalk.SpecFlow;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class SaldosEnCuentaStepDefinitions
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

        [When(@"Se debita un monto en dolares negativo de (.*)")]
        public void WhenSeDebitaUnMontoEnDolaresNegativoDe(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"Se acredita un monto en dolares de (.*)")]
        public void WhenSeAcreditaUnMontoEnDolaresDe(int p0)
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
