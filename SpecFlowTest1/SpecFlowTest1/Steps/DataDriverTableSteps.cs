using System;
using TechTalk.SpecFlow;

using TechTalk.SpecFlow.Assist;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

using System.Threading;

using SpecFlowTest1.Drivers;
using System.Data;

namespace SpecFlowTest1.Steps
{
    [Binding]
    public class DataDriverTableSteps
    {
        public ChromeDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2021\SINERGIASS\CSD\herramientas\");
        public string URlLoginExitoso = "https://demoqa.com/profile";
        public string URlLoginValidar = "";


        [Given(@"Usuario ingresa a website demoqa.com/login")]
        public void GivenUsuarioIngresaAWebsiteDemoqa_ComLogin()
        {

            driver.Navigate().GoToUrl("https://demoqa.com/login");

            driver.Manage().Window.Maximize();

        }

        [When(@"digita sus credenciales de acceso")]
        public void WhenDigitaSusCredencialesDeAcceso(Table table)
        {


            //cuando solo viene la tabla con un dato
            var CredencialesAcceso = table.CreateInstance<Credenciales>();

            driver.FindElement(By.Id("userName")).SendKeys(CredencialesAcceso.Username);
            driver.FindElement(By.Id("password")).SendKeys(CredencialesAcceso.Password);


            //cuando viene la tabla con varios datos
            //var credentials = table.CreateSet<Credenciales>();

            //foreach (var userData in credentials)
            //{
            //    driver.FindElement(By.Id("userName")).SendKeys(userData.Username);
            //    driver.FindElement(By.Id("password")).SendKeys(userData.Password);
            //    driver.FindElement(By.Id("login")).Click();

            //    Thread.Sleep(5000);

            //    driver.Quit();
            //}
        }

        [When(@"realiza click en Login para ingresar")]
        public void WhenRealizaClickEnLoginParaIngresar()
        {
            //Thread.Sleep(5000);
            driver.FindElement(By.Id("login")).Click();
        }


        [Then(@"Ingreso correcto")]
        public void ThenIngresoCorrecto()
        {
            Thread.Sleep(5000);

            URlLoginValidar = driver.Url;
            Assert.AreEqual(URlLoginExitoso, URlLoginValidar);
        }


        
        [When(@"Usuario realiza Log out")]
        public void WhenUsuarioRealizaLogOut()
        {
            Thread.Sleep(5000);

            Console.WriteLine("Se Sale del web site");

        }


        [Then(@"Salio")]
        public void ThenSalio()
        {
            Thread.Sleep(5000);

            driver.Quit();
        }

       
    }
}
