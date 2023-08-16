using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlowTest1.Features
{
    [Binding]
    public class Test1Steps
    {
        [Given(@"the first number es (.*)")]
        public void GivenTheFirstNumberEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the second number es (.*)")]
        public void GivenTheSecondNumberEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the two numbers son added")]
        public void WhenTheTwoNumbersSonAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should es (.*)")]
        public void ThenTheResultShouldEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
