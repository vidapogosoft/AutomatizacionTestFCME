using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

using System.Threading;

namespace NetAppiumMobile1
{
    [TestClass]
    public class UnitTest2
    {

        //crear la instancia para el appium driver

        private AndroidDriver<AndroidElement> driverMobile;

        [TestMethod]
        public void TestInit()
        {

            DesiredCapabilities cap = new DesiredCapabilities();

            cap.SetCapability("app", "D:\\vidapogosoft\\cursos\\2023\\SIPECOM\\TestAutomatizadosFCME\\herramientas\\CrudContact\\app-release.apk");
            cap.SetCapability("device", "SM-T295");
            cap.SetCapability("deviceName", "Tab VPR");
            cap.SetCapability("platformName", "Android");



            ///launch del android driver
            driverMobile = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);


            //Encontrar elementos

            Thread.Sleep(5000);

            //Cajas de texto
            AndroidElement TxtId = driverMobile.FindElementById("com.android.sqlite:id/TxtCodigo");
            TxtId.SendKeys("100");

            AndroidElement TxtDescripcion = driverMobile.FindElementById("com.android.sqlite:id/TxtDescripcion");
            TxtDescripcion.SendKeys("Product Test Automation");

            AndroidElement TxtPrecio = driverMobile.FindElementById("com.android.sqlite:id/TxtPrecio");
            TxtPrecio.SendKeys("15");

            Thread.Sleep(3000);

            ///Boton
            AndroidElement BtnSave = driverMobile.FindElementById("com.android.sqlite:id/BtnSave");
            BtnSave.Click();

            Thread.Sleep(3000);

            AndroidElement Resultado = driverMobile.FindElementById("com.android.sqlite:id/TxtResultado");
            
            Assert.AreEqual("100-Product Test Automation", Resultado.Text);

        }

    }
}
