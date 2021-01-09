using OpenQA.Selenium;
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


        public IWebElement RequestLoanOption => _driver.FindElement(By.CssSelector("a[href='/parabank/requestloan.htm']"));
        public const string LoanAmountField = "amount";
        public const string DownPaymentField = "downPayment";
        public IWebElement FromAccountDropdown => _driver.FindElement(By.CssSelector("#fromAccountId > option:nth-child(1)"));
        public IWebElement ApplyNowButton => _driver.FindElement(By.CssSelector("input[type='submit']"));
        public IWebElement LoanProviderTable => _driver.FindElement(By.CssSelector("table[class='form']"));

        public IWebElement UpdateContactInfoOption => _driver.FindElement(By.CssSelector("a[href='/parabank/updateprofile.htm"));

        public const string FirstNameField = "customer.firstName";
        public const string LastNameField = "customer.lastName";
        public const string AddressField = "customer.address.street";
        public const string CityField = "customer.address.city";
        public const string StateField = "customer.address.state";
        public const string ZipCodeField = "customer.address.zipCode";
        public const string PhoneNumberField = "customer.phoneNumber";

        public IWebElement UpdateProfileButton => _driver.FindElement(By.CssSelector("input[type='submit']"));
        public IWebElement UpdateProfileMessage => _driver.FindElement(By.CssSelector("#rightPanel > div > div"));


    }
}
