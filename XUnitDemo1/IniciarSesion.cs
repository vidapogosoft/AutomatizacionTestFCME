using OpenQA.Selenium;

namespace XUnitDemo1
{
    public class IniciarSesion
    {
        private readonly string UserName = "userName";
        private readonly string Password = "password";
        private readonly string Login = "login";

        private IWebDriver driver;

        public IniciarSesion(IWebDriver driverparam)
        {
            driver = driverparam;
        }

        public void IngresarUsuario(string user)
        {
            var txtuser = driver.FindElement(By.Id(UserName));

            txtuser.SendKeys(user);
        }

        public void IngresarPassword(string pass)
        {
            var txtpwd = driver.FindElement(By.Id(Password));

            txtpwd.SendKeys(pass);
        }


        public void Iniciar()
        {
            var iniciarElement = driver.FindElement(By.Id(Login));

            iniciarElement.Click();

        }
    }
}
