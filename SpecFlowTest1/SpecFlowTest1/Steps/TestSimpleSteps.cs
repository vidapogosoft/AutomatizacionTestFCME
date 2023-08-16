using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;

using System.Threading;

namespace SpecFlowTest1.Steps
{
    [Binding]
    public class TestSimpleSteps
    {

        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\herramientas\");

        public string UrlLoginExitoso = "https://demoqa.com/profile";
        public string URlLoginValidar = "";


        [Given(@"Usuario se dirige a web site demoqa.com/login")]
        public void GivenUsuarioSeDirigeAWebSiteDemoqa_ComLogin()
        {

            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();

        }
        
        [When(@"usuario ingresa credenciales")]
        public void WhenUsuarioIngresaCredenciales()
        {
            driver.FindElement(By.Id("userName")).SendKeys("testuser_1");
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
   
        }
        
        [When(@"realiza click en boton Login")]
        public void WhenRealizaClickEnBotonLogin()
        {
            Thread.Sleep(5000);

            driver.FindElement(By.Id("login")).Click();

        }

        [Then(@"Login es exitoso")]
        public void ThenLoginEsExitoso()
        {
            Thread.Sleep(5000);

            URlLoginValidar = driver.Url;

            Assert.AreEqual(UrlLoginExitoso, URlLoginValidar);

        }

        [When(@"usuario realiza LogOut")]
        public void WhenUsuarioRealizaLogOut()
        {

            Thread.Sleep(5000);

        }
      
        
        [Then(@"Salio de aplicacion")]
        public void ThenSalioDeAplicacion()
        {

            Thread.Sleep(5000);

            driver.Close();

        }
    }
}
