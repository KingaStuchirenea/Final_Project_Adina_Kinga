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

        #region Customer care request locators
        public IWebElement ContactButton => _driver.FindElement(By.CssSelector("li[class=contact]"));
        public IWebElement NameField => _driver.FindElement(By.Id("name"));
        public IWebElement EmailField => _driver.FindElement(By.Id("email"));
        public IWebElement PhoneField => _driver.FindElement(By.Id("phone"));
        public IWebElement MessageTextbox => _driver.FindElement(By.Id("message"));
        public IWebElement SubmitButton => _driver.FindElement(By.CssSelector("input[value='Send to Customer Care'"));
        public IWebElement SubmitMessage => _driver.FindElement(By.CssSelector("div#rightPanel p"));
        public IWebElement WarningMessage => _driver.FindElement(By.Id("email.errors"));

        #endregion

        #region Products locators
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


        #endregion

        #region Registration locators
        public IWebElement RegisterButton => _driver.FindElement(By.CssSelector("#loginPanel > p:nth-child(3) > a"));
        public const string FirstNameField = "customer.firstName";
        public const string LastNameField = "customer.lastName";
        public const string AddressField = "customer.address.street";
        public const string CityField = "customer.address.city";
        public const string StateField = "customer.address.state";
        public const string ZipCodeField = "customer.address.zipCode";
        public const string PhoneNumberField = "customer.phoneNumber";
        public const string SSNNumberField = "customer.ssn";
        public const string UsernameField = "customer.username";
        public const string PasswordField = "customer.password";
        public const string ConfirmPasswordField = "repeatedPassword";
        public IWebElement SubmitRegisterationButton => _driver.FindElement(By.CssSelector("#customerForm > table > tbody > tr:nth-child(13) > td:nth-child(2) > input"));
        public IWebElement AccountCreatedSuccessfullyMessage => _driver.FindElement(By.CssSelector("#rightPanel > p"));

        #endregion

    }
}
