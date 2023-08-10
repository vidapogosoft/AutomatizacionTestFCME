

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using NUnit.Framework;

namespace TestSelenium1
{
    public class CheckRadio
    {

        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\herramientas\");

        //instancia de manera global la URL de la pagina a testear
        public string url = "http://demo.guru99.com/test/radio.html";

        [Test]
        public void Testpage()
        {
            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();

            Thread.Sleep(4000);

            IWebElement radio1 = driver.FindElement(By.Id("vfb-7-1"));
            IWebElement radio2 = driver.FindElement(By.Id("vfb-7-2"));
            IWebElement radio3 = driver.FindElement(By.Id("vfb-7-3"));

            radio1.Click();
            Thread.Sleep(6000);
            radio2.Click();
            Thread.Sleep(6000);
            radio3.Click();


            IWebElement Check1 = driver.FindElement(By.Id("vfb-6-0"));

            // Se localiza el segundo radio button por su id
            IWebElement Check2 = driver.FindElement(By.Id("vfb-6-2"));

            Check1.Click();

            Thread.Sleep(6000);
            //El radio button 1 es deseleccionado y el segundo es seleccionado
            Check2.Click();

        }
    }
}
