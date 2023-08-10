
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestSelenium1
{
    public class Dropdownlist
    {

        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\herramientas\");

        //instancia de manera global la URL de la pagina a testear
        public string url = "http://www.tizag.com/phpT/examples/formex.php";

        [Test]
        public void Testpage()
        {
            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();

            IWebElement control = driver.FindElement(By.Name("Fname"));
            control.SendKeys("VPR - 1");


            driver.FindElement(By.Name("Lname")).SendKeys("vidapogosoft");

            driver.FindElement(By.XPath("//input[@name='gender' and @value='Male']")).Click();

            driver.FindElement(By.XPath("//input[@name='food[]' and @value='Chicken']")).Click();

            driver.FindElement(By.Name("quote")).Clear();

            driver.FindElement(By.Name("quote")).SendKeys("Be Present VPR !");

            //SELECT THE DROP DOWN LIST
            var education = driver.FindElement(By.Name("education"));
            var selectelement = new SelectElement(education);

            //select by value
            selectelement.SelectByValue("Jr.High");

            Thread.Sleep(5000);

            selectelement.SelectByText("HighSchool");

            Thread.Sleep(3000);

            //Take Foto

            ITakesScreenshot foto = driver as ITakesScreenshot;
            Screenshot screen = foto.GetScreenshot();

            screen.SaveAsFile(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\" + DateTime.Now.Ticks.ToString() + ".png");

        }

    }
}
