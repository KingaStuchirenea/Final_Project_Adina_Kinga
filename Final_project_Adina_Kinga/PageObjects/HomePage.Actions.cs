using Final_project_Adina_Kinga.Dto;
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

        public void GoToRegisterNewAccountPage()
        {
            RegisterButton.Click();
        }

        public HomePage PopulateRegisterAccountForm(UserInformationDetailsDto registerAccount)
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

        public void GoToForgotLoginInfoPage()
        {
            ForgotLoginInfoButton.Click();
        }

        public HomePage PopulateForgotLoginInfoForm(UserInformationDetailsDto forgotAccountDetails)
        {
            TypeTextId(ForgotLoginInfoFirstNameField, forgotAccountDetails.FirstName);
            TypeTextId(ForgotLoginInfoLastNameField, forgotAccountDetails.LastName);
            TypeTextId(ForgotLoginInfoAddressField, forgotAccountDetails.Address);
            TypeTextId(ForgotLoginInfoCityField, forgotAccountDetails.City);
            TypeTextId(ForgotLoginInfoStateField, forgotAccountDetails.State);
            TypeTextId(ForgotLoginInfoZipCodeField, forgotAccountDetails.ZipCode);
            TypeTextId(ForgotLoginInfoSSNNumberField.ToString(), forgotAccountDetails.SSN.ToString());
            return this;
        }

        public void ClickFindMyLoginInfoButton()
        {
            FindMyLoginInfoButton.Click();
        }
    }
}
