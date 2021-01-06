using Final_project_Adina_Kinga.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class HomePage : BaseDriver
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

        //public void PopulateRegisterNewAccountForm(string firstName, string lastName, string address, string city, string state, string zipCode, int phone, int ssn) 
        //{
        //    FirstNameField.SendKeys(firstName);
        //    LastNameField.SendKeys(lastName);
        //    AddressField.SendKeys(address);
        //    CityField.SendKeys(city);
        //    StateField.SendKeys(state);
        //    ZipCodeField.SendKeys(zipCode);
        //    PhoneNumberField.SendKeys(phone.ToString());
        //    SSNNumberField.SendKeys(ssn.ToString());
        //}

        //public void PopulateRegisterAccountDetails(string username, string password, string confirmPassword)
        //{
        //    UsernameField.SendKeys(username);
        //    PasswordField.SendKeys(password);
        //    ConfirmPasswordField.SendKeys(confirmPassword);
        //    SubmitRegisterationButton.Click();
        //}

        public HomePage PopulateRegisterAccountForm(RegisterAccount registerAccount)
        {
            TypeTextId(FirstNameField, registerAccount.FirstName);
            TypeTextId(LastNameField, registerAccount.LastName);
            TypeTextId(AddressField, registerAccount.Address);
            TypeTextId(CityField, registerAccount.City);
            TypeTextId(StateField, registerAccount.State);
            TypeTextId(ZipCodeField, registerAccount.ZipCode);
            TypeTextId(PhoneNumberField.ToString(), registerAccount.Phone.ToString());
            TypeTextId(SSNNumberField.ToString(), registerAccount.SSN.ToString());

            TypeTextId(UsernameField, registerAccount.Username);
            TypeTextId(PasswordField, registerAccount.Password);
            TypeTextId(ConfirmPasswordField, registerAccount.ConfirmPassword);
            return this;
        }

        public void ClickRegisterButton()
        {
            
            SubmitRegisterationButton.Click();
        }

        public void PopulateTryJtestForm(string firstName, string lastName, string company, string jobTitle, string email, int phone, string country)
        {
            Thread.Sleep(1000);
            FirstNameFieldJtest.SendKeys(firstName);
            LastNameFieldJtest.SendKeys(lastName);
            CompanyFieldJtest.SendKeys(company);
            JobtitleFieldJtest.SendKeys(jobTitle);
            EmailFieldJtest.SendKeys(email);
            PhoneFieldJtest.SendKeys(phone.ToString());
            CountryDropdownJtest.SendKeys(country);
        }

        public void PopulateTryJtestFormPartially( string company, string jobTitle, string email, int phone, string country)
        {
            Thread.Sleep(1000);
            CompanyFieldJtest.SendKeys(company);
            JobtitleFieldJtest.SendKeys(jobTitle);
            EmailFieldJtest.SendKeys(email);
            PhoneFieldJtest.SendKeys(phone.ToString());
            CountryDropdownJtest.SendKeys(country);
        }

    }
}
