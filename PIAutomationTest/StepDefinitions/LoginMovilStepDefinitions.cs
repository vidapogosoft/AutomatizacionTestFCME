using PIAutomationTest.Drivers.dto;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

namespace PIAutomationTest.StepDefinitions
{
    [Binding]
    public class LoginMovilStepDefinitions
    {
        //crear la instancia para el appium driver

        private readonly AndroidDriver<AndroidElement> driverMobile;

        [Given(@"usuario se dirige a app de registro")]
        public void GivenUsuarioSeDirigeAAppDeRegistro()
        {
            DesiredCapabilities cap = new DesiredCapabilities();

            cap.SetCapability("app", "D:\\vidapogosoft\\cursos\\2023\\SIPECOM\\TestAutomatizadosFCME\\herramientas\\CrudContact\\app-release.apk");
            cap.SetCapability("device", "SM-T295");
            cap.SetCapability("deviceName", "Tab VPR");
            cap.SetCapability("platformName", "Android");
        }

        [When(@"llena formulario con los siguientes datos en lista")]
        public void WhenLlenaFormularioConLosSiguientesDatosEnLista(Table table)
        {
            var ListRegistroApp = table.CreateSet<RegistroApp>();

            foreach (var data in ListRegistroApp)
            {
                //TODO
                //data.codigo;

                //Cajas de texto
                AndroidElement TxtId = driverMobile.FindElementById("com.android.sqlite:id/TxtCodigo");
                TxtId.SendKeys(data.codigo);

                AndroidElement TxtDescripcion = driverMobile.FindElementById("com.android.sqlite:id/TxtDescripcion");
                TxtDescripcion.SendKeys(data.descripcion);

                AndroidElement TxtPrecio = driverMobile.FindElementById("com.android.sqlite:id/TxtPrecio");
                TxtPrecio.SendKeys(data.precio);

                ///Boton
                AndroidElement BtnSave = driverMobile.FindElementById("com.android.sqlite:id/BtnSave");
                BtnSave.Click();
            }
        }

        [When(@"visualiza resultado de la lista")]
        public void WhenRealizaClickEnBotonSaveLista()
        {
            throw new PendingStepException();
        }

        [When(@"llena formulario con los siguientes datos (.*), (.*), (.*)")]
        public void WhenLlenaFormularioConLosSiguientesDatos(string codigo, string descripcion, string precio)
        {
            //Cajas de texto
            AndroidElement TxtId = driverMobile.FindElementById("com.android.sqlite:id/TxtCodigo");
            TxtId.SendKeys(codigo);

            AndroidElement TxtDescripcion = driverMobile.FindElementById("com.android.sqlite:id/TxtDescripcion");
            TxtDescripcion.SendKeys(descripcion);

            AndroidElement TxtPrecio = driverMobile.FindElementById("com.android.sqlite:id/TxtPrecio");
            TxtPrecio.SendKeys(precio);
        }

        [When(@"realiza click en boton save")]
        public void WhenRealizaClickEnBotonSave()
        {
            ///Boton
            AndroidElement BtnSave = driverMobile.FindElementById("com.android.sqlite:id/BtnSave");
            BtnSave.Click();
        }

        [Then(@"registro correcto de la lista")]
        public void ThenRegistroCorrectoDeLaLista()
        {
            //Assert de la lista
            throw new PendingStepException();
        }

        [Then(@"registro correcto esperando (.*)-(.*)")]
        public void ThenRegistroCorrectoEsperando(string codigo, string descripcion)
        {
            //Assert

            throw new PendingStepException();
        }
    }
}
