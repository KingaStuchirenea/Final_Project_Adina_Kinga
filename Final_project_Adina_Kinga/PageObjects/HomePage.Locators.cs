using OpenQA.Selenium;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
