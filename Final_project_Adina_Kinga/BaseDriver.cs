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
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
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

        public IWebElement WebElementId(string id)
        {
            IWebElement webElement;
            webElement = Driver.FindElement(By.Id(id));
            return webElement;
        }
        public IWebElement WebElementCss(string css)
        {
            IWebElement webElement;
            webElement = Driver.FindElement(By.CssSelector(css));
            return webElement;
        }
        public IWebElement WebElementXPath(string xpath)
        {
            IWebElement webElement;
            webElement = Driver.FindElement(By.XPath(xpath));
            return webElement;
        }
        public BaseDriver TypeTextId(string id, string text)
        {
            var element = WebElementId(id);
            element.SendKeys(text);
            return this;
        }
        public BaseDriver TypeTextCss(string css, string text)
        {
            var element = WebElementCss(css);
            element.SendKeys(text);
            return this;
        }
        public BaseDriver TypeTextXPath(string xpath, string text)
        {
            var element = WebElementXPath(xpath);
            element.SendKeys(text);
            return this;
        }
    }
}