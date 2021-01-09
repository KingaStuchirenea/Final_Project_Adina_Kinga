using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public const string UsernameLoginField = "#loginPanel > form > div:nth-child(2) > input";
        public const string PasswordLoginField = "#loginPanel > form > div:nth-child(4) > input";
        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("#loginPanel > form > div:nth-child(5) > input"));
        public IWebElement AccountServicesPanel => _driver.FindElement(By.CssSelector("#leftPanel > h2"));
        public IWebElement LogoutButton => _driver.FindElement(By.CssSelector("#leftPanel > ul > li:nth-child(8) > a"));

    }
}
