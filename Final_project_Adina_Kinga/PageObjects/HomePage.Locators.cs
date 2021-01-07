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

        #region Admin page locator
        public IWebElement AdminPageOption => _driver.FindElement(By.XPath("//a[text()='Admin Page']"));
        public IWebElement InitializeButton => _driver.FindElement(By.CssSelector("button[value='INIT']"));
        public IWebElement CleanButton => _driver.FindElement(By.CssSelector("button[value='CLEAN']"));
        public IWebElement DatabaseInitializedMessage => _driver.FindElement(By.XPath("//*[@id='rightPanel']/p/b"));
        public IWebElement DatabaseCleanedMessage => _driver.FindElement(By.CssSelector("#rightPanel > p > b"));

        #endregion

    }
}
