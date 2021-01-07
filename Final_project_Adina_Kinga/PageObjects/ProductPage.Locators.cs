using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ProductsOption => _driver.FindElement(By.XPath("//*[@id='headerPanel']/ul[1]/li[4]/a"));
        public IWebElement AllowCookies => _driver.FindElement(By.XPath("//div[text()='Allow All']"));
        public IWebElement AcceptCookies => _driver.FindElement(By.Id("hs-eu-confirmation-button"));
        public IWebElement ProductsDropdown => _driver.FindElement(By.CssSelector("a[title=Products]"));
        public IWebElement Product1 => _driver.FindElement(By.XPath("//*[@id='menu-item-6907']"));
        public IWebElement Product2 => _driver.FindElement(By.XPath("//*[@id='menu-item-6908']"));
        public IWebElement Product3 => _driver.FindElement(By.XPath("//*[@id='menu-item-6909']"));
        public IWebElement Product4 => _driver.FindElement(By.XPath("//*[@id='menu-item-6910']"));
        public IWebElement Product5 => _driver.FindElement(By.XPath("//*[@id='menu-item-6911']"));
        public IWebElement Product6 => _driver.FindElement(By.XPath("//*[@id='menu-item-6912']"));
        public IWebElement Product7 => _driver.FindElement(By.XPath("//*[@id='menu-item-6913']"));
        public IWebElement Product8 => _driver.FindElement(By.XPath("//*[@id='menu-item-6914']"));
        public IWebElement Product9 => _driver.FindElement(By.XPath("//*[@id='menu-item-6915']"));
        public IWebElement ParasoftJtestBlock => _driver.FindElement(By.XPath("//section[3]/div[3]/div[2]/div[2]/a"));
        public IWebElement TryParasoftJtestButton => _driver.FindElement(By.CssSelector(".btn-list > a:nth-child(1)"));
        public IWebElement FirstNameFieldJtest => _driver.FindElement(By.Name("firstname"));
        public IWebElement LastNameFieldJtest => _driver.FindElement(By.Name("lastname"));
        public IWebElement CompanyFieldJtest => _driver.FindElement(By.Name("company"));
        public IWebElement JobtitleFieldJtest => _driver.FindElement(By.Name("jobtitle"));
        public IWebElement EmailFieldJtest => _driver.FindElement(By.Name("email"));
        public IWebElement PhoneFieldJtest => _driver.FindElement(By.Name("phone"));
        public IWebElement CountryDropdownJtest => _driver.FindElement(By.Name("country"));
        public IWebElement TryParasJtestButton => _driver.FindElement(By.CssSelector("input[value='TRY PARASOFT JTEST']"));
        public IWebElement SubmitMessageParasoftJtest => _driver.FindElement(By.CssSelector("div[data-reactid='.hbspt-forms-0']"));
        public IWebElement WarningMessageParasoftJtest => _driver.FindElement(By.CssSelector(".hs-form-field > ul > li > label"));
    }
}
