using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga
{
   public class BasePage : BaseDriver
    {
        public const string ParaBank = "https://parabank.parasoft.com/parabank/index.htm";
        private IWebDriver _driver;

        public BasePage()
        {
            _driver = Driver;
        }

        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
