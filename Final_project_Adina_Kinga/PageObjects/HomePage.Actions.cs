using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class HomePage
    {
        public void PopulateCustomerCareForm(string name, string email, int phone, string message)
        {
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
            PhoneField.SendKeys(phone.ToString());
            MessageTextbox.SendKeys(message);
        }

        public void PopulatePartiallyCustomerCareForm(string name, int phone, string message)
        {
            NameField.SendKeys(name);
            PhoneField.SendKeys(phone.ToString());
            MessageTextbox.SendKeys(message);
        }

        public void NineProductsDisplayed() 
        {
            Assert.IsTrue(Product1.Displayed);
            Assert.IsTrue(Product2.Displayed);
            Assert.IsTrue(Product3.Displayed);
            Assert.IsTrue(Product4.Displayed);
            Assert.IsTrue(Product5.Displayed);
            Assert.IsTrue(Product6.Displayed);
            Assert.IsTrue(Product7.Displayed);
            Assert.IsTrue(Product8.Displayed);
            Assert.IsTrue(Product9.Displayed);
        }

        public void GoToRegisterNewAccountPage()
        {
            RegisterButton.Click();
        }

        public void PopulateRegisterNewAccountForm(string firstName, string lastName, string address, string city, string state, string zipCode, int phone, int ssn) 
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            AddressField.SendKeys(address);
            CityField.SendKeys(city);
            StateField.SendKeys(state);
            ZipCodeField.SendKeys(zipCode);
            PhoneNumberField.SendKeys(phone.ToString());
            SSNNumberField.SendKeys(ssn.ToString());
        }

        public void PopulateRegisterAccountDetails(string username, string password, string confirmPassword)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            ConfirmPasswordField.SendKeys(confirmPassword);
            SubmitRegisterationButton.Click();
        }

    }
}
