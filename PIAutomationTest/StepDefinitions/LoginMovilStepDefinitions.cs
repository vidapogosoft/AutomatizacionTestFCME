using PIAutomationTest.Drivers.dto;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class LoginMovilStepDefinitions
    {
        [Given(@"usuario se dirige a app de registro")]
        public void GivenUsuarioSeDirigeAAppDeRegistro()
        {
            throw new PendingStepException();
        }

        [When(@"llena formulario con los siguientes datos en lista")]
        public void WhenLlenaFormularioConLosSiguientesDatosEnLista(Table table)
        {
            var ListRegistroApp = table.CreateSet<RegistroApp>();

            foreach (var data in ListRegistroApp)
            {
                //TODO
                //data.codigo;

            }

            throw new PendingStepException();
        }

        [When(@"llena formulario con los siguientes datos (.*), (.*), (.*)")]
        public void WhenLlenaFormularioConLosSiguientesDatos(string codigo, string descripcion, string precio)
        {
            throw new PendingStepException();
        }

        [When(@"realiza click en boton save")]
        public void WhenRealizaClickEnBotonSave()
        {
            throw new PendingStepException();
        }

        [Then(@"registro correcto de la lista")]
        public void ThenRegistroCorrectoDeLaLista()
        {
            throw new PendingStepException();
        }

        [Then(@"registro correcto esperando (.*)-(.*)")]
        public void ThenRegistroCorrectoEsperando(string codigo, string descripcion)
        {
            throw new PendingStepException();
        }
    }
}
