using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

using System.Threading;

namespace NetAppiumMobile1
{
    [TestClass]
    public class UnitTest1
    {

        //crear la instancia para el appium driver

        private AndroidDriver<AndroidElement> driverMobile;

        [TestMethod]

        public void TestInit()
        {

            DesiredCapabilities cap = new DesiredCapabilities();

            cap.SetCapability("app", "C://vidapogosoft//cursos//2021//CSD//ContactManager.apk");
            cap.SetCapability("device", "RQ300729UE");
            cap.SetCapability("deviceName", "G3223");
            cap.SetCapability("platformName", "Android");

            cap.SetCapability("app-package", "com.example.android.contactmanager-1");
            


            ///launch del android driver
            driverMobile = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);


            //Encontrar elementos

            ///Boton
            AndroidElement BtnAddContact = driverMobile.FindElementByXPath("//android.widget.Button[@content-desc=\"Add Contact\"]");
            BtnAddContact.Click();


            Thread.Sleep(5000);

            //Cajas de texto
            AndroidElement TxtContactName = driverMobile.FindElementById("com.example.android.contactmanager:id/contactNameEditText");
            TxtContactName.SendKeys("Victor VPR");


            ///verificacion

            //Assert.IsNull(driverMobile.Context);

        }
    }
}
