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

        public IWebElement ContactButton => _driver.FindElement(By.CssSelector("li[class=contact]"));
        public IWebElement NameField => _driver.FindElement(By.Id("name"));
        public IWebElement EmailField => _driver.FindElement(By.Id("email"));
        public IWebElement PhoneField => _driver.FindElement(By.Id("phone"));
        public IWebElement MessageTextbox => _driver.FindElement(By.Id("message"));
        public IWebElement SubmitButton => _driver.FindElement(By.CssSelector("input[value='Send to Customer Care'"));
        public IWebElement SubmitMessage => _driver.FindElement(By.CssSelector("div#rightPanel p"));
        public IWebElement WarningMessage => _driver.FindElement(By.Id("email.errors"));
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

        #region Registration locators
        public IWebElement RegisterButton => _driver.FindElement(By.CssSelector("#loginPanel > p:nth-child(3) > a"));
        public IWebElement FirstNameField => _driver.FindElement(By.Id("customer.firstName"));
        public IWebElement LastNameField => _driver.FindElement(By.Id("customer.lastName"));
        public IWebElement AddressField => _driver.FindElement(By.Id("customer.address.street"));
        public IWebElement CityField => _driver.FindElement(By.Id("customer.address.city"));
        public IWebElement StateField => _driver.FindElement(By.Id("customer.address.state"));
        public IWebElement ZipCodeField => _driver.FindElement(By.Id("customer.address.zipCode"));
        public IWebElement PhoneNumberField => _driver.FindElement(By.Id("customer.phoneNumber"));
        public IWebElement SSNNumberField => _driver.FindElement(By.Id("customer.ssn"));
        public IWebElement UsernameField => _driver.FindElement(By.Id("customer.username"));
        public IWebElement PasswordField => _driver.FindElement(By.Id("customer.password"));
        public IWebElement ConfirmPasswordField => _driver.FindElement(By.Id("repeatedPassword"));
        public IWebElement SubmitRegisterationButton => _driver.FindElement(By.CssSelector("#customerForm > table > tbody > tr:nth-child(13) > td:nth-child(2) > input"));
        public IWebElement AccountCreatedSuccessfullyMessage => _driver.FindElement(By.CssSelector("#rightPanel > p"));

        #endregion

    }
}
