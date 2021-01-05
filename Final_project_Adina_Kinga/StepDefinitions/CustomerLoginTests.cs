using Final_project_Adina_Kinga.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Final_project_Adina_Kinga.StepDefinitions
{
    [Binding]
    public sealed class CustomerLoginTests : BaseDriver //Hooks
    {
        [Given(@"I navigate to Register Page")]
        public void GivenINavigateToRegisterPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToRegisterNewAccountPage();
            
        }

        [When(@"I populate the registration form")]
        public void WhenIPopulateTheRegistrationForm()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.PopulateRegisterNewAccountForm("John", "Doe", "John's Address", "City", "State", "ZipCode", 1234567890, 0987654321);
        }

        [When(@"populate account login details")]
        public void WhenPopulateAccountLoginDetails()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.PopulateRegisterAccountDetails("John.Doe", "password123", "password123");
        }

        [Then(@"a welcome message is displayed")]
        public void ThenAWelcomeMessageIsDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.AccountCreatedSuccessfullyMessage.Displayed);
        }



    }
}
