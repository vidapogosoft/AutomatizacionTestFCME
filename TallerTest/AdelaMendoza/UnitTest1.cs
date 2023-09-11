
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AdelaMendoza
{
    [TestClass]
    public class UnitTest1
    {
        //Se Inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"C:\Users\amendoza\Documents\CURSOS PRUEBAS AUTOMATIZADAS\Taller\AdelaMendoza\Herramientas\11605845179\");
        //intancia de manera global la URL de la pagian a testear
        public string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx?AspxAutoDetectCookieSupport=1";




        [TestMethod]
        public void Registro()
        {
            ITakesScreenshot ScreenShotDrive = driver as ITakesScreenshot;

            Screenshot screenshot = ScreenShotDrive.GetScreenshot();

            try
            {
                //seteo de la pagina a probar 
                driver.Navigate().GoToUrl(url);
                //se maximiza la pagina 
                driver.Manage().Window.Maximize();
                //instancia del campo para login campo USER
                driver.FindElement(By.Id("LoginUser_UserName"));
                driver.FindElement(By.Id("LoginUser_UserName")).Click();
                driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

                //instancia del campo para login campo PASS
                driver.FindElement(By.Id("LoginUser_Password"));
                driver.FindElement(By.Id("LoginUser_Password")).Click();
                driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

                //Pausa para procerder a dar click 
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                //Click en login 
                driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

                //Hasta este momento logueo exitoso
              
                WebDriverWait wait2 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("liClientes")).Click();
                Thread.Sleep(3000);
                WebDriverWait wait3 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_btnAdd")).Click();
                Thread.Sleep(2000);
                WebDriverWait wait4 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_txtNombreCliente"));
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("Juanita Mendoza");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtIdentificacion"));
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0917178352");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("042422324");


                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtExtension"));
                driver.FindElement(By.Id("MainContent_txtExtension")).Click();
                driver.FindElement(By.Id("MainContent_txtExtension")).SendKeys("4219");


                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular"));
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0984378996");


                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtDireccion"));
                driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
                driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Rocafuerte 748 y Luis Urdaneta");

                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtMailDefecto"));
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).Click();
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("adela_mj@hotmail.com");


                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente"));
                driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).Click();
                driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("amendoza@fcme.com.ec");







                Thread.Sleep(2000);


                var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
                var selectElement = new SelectElement(TipoIdent);
                selectElement.SelectByValue("05");

                IWebElement Check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
                Check1.Click();

                Thread.Sleep(2000);

               // driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
                Thread.Sleep(3000);
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\amendoza\Documents\CURSOS PRUEBAS AUTOMATIZADAS\Taller\AdelaMendoza\Capturas\ProcesoOK" + DateTime.Now.Ticks.ToString() + ".png");
            }
            catch (Exception ex)
            {
                screenshot.SaveAsFile(@"C:\Users\amendoza\Documents\CURSOS PRUEBAS AUTOMATIZADAS\Taller\AdelaMendoza\Capturas\" + " Error " + ".png");
                driver.Close();
            }




        }
    }
}