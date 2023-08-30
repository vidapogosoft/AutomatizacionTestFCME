using System;
using TechTalk.SpecFlow;

using PIAutomationTest.Drivers.dto;
using TechTalk.SpecFlow.Assist;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class RegistroWinformStepDefinitions
    {
        [Given(@"usuario se dirige a aplicativo winform de registro")]
        public void GivenUsuarioSeDirigeAAplicativoWinformDeRegistro()
        {
            throw new PendingStepException();
        }

        [When(@"llena formulario con los siguientes datos")]
        public void WhenLlenaFormularioConLosSiguientesDatos(Table table)
        {
            var LisRegistro = table.CreateSet<Registro>();

            foreach (var data in LisRegistro)
            {
                //TODO
                //data.nombres;

            }

            throw new PendingStepException();
        }

        [When(@"realiza click en boton registrar")]
        public void WhenRealizaClickEnBotonRegistrar()
        {
            throw new PendingStepException();
        }

        [Then(@"registro correcto")]
        public void ThenRegistroCorrecto()
        {
            throw new PendingStepException();
        }
    }
}
