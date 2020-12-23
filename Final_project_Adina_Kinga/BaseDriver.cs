using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Final_project_Adina_Kinga
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
    public class BaseDriver
    {
        private BrowserType _browserType;
        public static IWebDriver Driver;

        public void CreateDriver()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Firefox");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            ChooseDriverInstance(_browserType);
            Driver.Manage().Window.Maximize();
        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }
    }
}