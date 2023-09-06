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
        private readonly WindowsDriver<WindowsElement> _driver;


        [Given(@"usuario se dirige a aplicativo winform de registro")]
        public void GivenUsuarioSeDirigeAAplicativoWinformDeRegistro()
        {

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "D:\\vidapogosoft\\cursos\\2023\\SIPECOM\\TestAutomatizadosFCME\\herramientas\\AppWinForm1.exe");
            options.AddAdditionalCapability("deviceName", "PORTUGALASUS");

            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [When(@"llena formulario con los siguientes datos")]
        public void WhenLlenaFormularioConLosSiguientesDatos(Table table)
        {
            var LisRegistro = table.CreateSet<Registro>();

            foreach (var data in LisRegistro)
            {
                //TODO
                //data.nombres;

                _driver.FindElementByAccessibilityId("TxtIdentificacion").Click();
                _driver.FindElementByAccessibilityId("TxtIdentificacion").SendKeys(data.identificacion);

                _driver.FindElementByAccessibilityId("TxtNombres").Click();
                _driver.FindElementByAccessibilityId("TxtNombres").SendKeys(data.nombres);


                _driver.FindElementByAccessibilityId("TxtDireccion").Click();
                _driver.FindElementByAccessibilityId("TxtDireccion").SendKeys(data.direccion);


                _driver.FindElementByName("Confirmar Datos").Click();
            }
        }

        [When(@"visualizo datos registrados")]
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
