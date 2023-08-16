using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest1.Steps
{
    [Binding]
    public class Test2Steps
    {
        [Given(@"el primer numero es (.*)")]
        public void GivenElPrimerNumeroEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el segundo numero es (.*)")]
        public void GivenElSegundoNumeroEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"los dos numeros son sumados")]
        public void WhenLosDosNumerosSonSumados()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"el resultado es (.*)")]
        public void ThenElResultadoEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
