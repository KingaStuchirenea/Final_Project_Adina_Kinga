﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class AccountServices
    {
        private IWebDriver _driver;
        public AccountServices(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UsernameField => _driver.FindElement(By.CssSelector("input[name='username']"));
        public IWebElement PasswordField => _driver.FindElement(By.CssSelector("input[name='password']"));
        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("input[value='Log In']"));
        public IWebElement OpenNewAccountOption => _driver.FindElement(By.XPath("//a[text()='Open New Account']"));
        public IWebElement SavingsOption => _driver.FindElement(By.CssSelector("option[value='1']"));
        public IWebElement OpenNewAccountButton => _driver.FindElement(By.CssSelector("input[value='Open New Account']"));
        public IWebElement AccountOpenedMessage => _driver.FindElement(By.CssSelector("#rightPanel > div > div > p:nth-child(2)"));




    }
}
