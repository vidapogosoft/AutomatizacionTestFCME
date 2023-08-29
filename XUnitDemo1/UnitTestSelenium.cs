
using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitDemo1
{
    public class UnitTestSelenium : IDisposable
    {
        private IWebDriver driver;

        public UnitTestSelenium()
        {

            driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2023\SIPECOM\TestAutomatizadosFCME\herramientas\");
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            driver.Quit();
        }

        [Theory]
        [InlineData("testuser_1", "Test@123")]
        [InlineData("vpr", "TestV@143")]
        [InlineData("testuser_9", "Test@143")]
        public void login (string u, string p)
        {
            IniciarSesion log = new IniciarSesion(driver);

            log.IngresarUsuario(u);
            log.IngresarPassword(p);

            Thread.Sleep(5000);

            log.Iniciar();

            Thread.Sleep(5000);

            var actual = driver.Url;

            Assert.Equal("https://demoqa.com/profile", actual);

        }

   }
}
