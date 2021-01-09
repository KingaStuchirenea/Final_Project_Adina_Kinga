using Final_project_Adina_Kinga.PageObjects;
using Final_project_Adina_Kinga.Dto;
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
            UserInformationDetailsDto createForm = new UserInformationDetailsDto();
            new HomePage(Driver)
                .PopulateRegisterAccountForm(createForm)
                .ClickRegisterButton();
        }

        [Then(@"a welcome message is displayed")]
        public void ThenAWelcomeMessageIsDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.AccountCreatedSuccessfullyMessage.Displayed);
        }

        [Given(@"I navigate to Forgot Login Info Page")]
        public void GivenINavigateToForgotLoginInfoPage()
        {
            new HomePage(Driver)
                .GoToForgotLoginInfoPage();
        }

        [When(@"I populate the Customer Lookup Form")]
        public void WhenIPopulateTheCustomerLookupForm()
        {
            UserInformationDetailsDto forgotLoginInfoForm = new UserInformationDetailsDto();
            new HomePage(Driver)
                .PopulateForgotLoginInfoForm(forgotLoginInfoForm);
        }

        [When(@"I click the Find My Login Info button")]
        public void WhenIClickTheFindMyLoginInfoButton()
        {
            new HomePage(Driver)
                .ClickFindMyLoginInfoButton();
        }

        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.ForgotLoginInfoMessageText.Displayed);
        }

        [Given(@"I populate the correct login credentials")]
        public void GivenIPopulateTheCorrectLoginCredentials()
        {
            UserInformationDetailsDto populateLoginCredentials = new UserInformationDetailsDto();
            new LoginPage(Driver)
                .PopulateLoginFields(populateLoginCredentials);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            new LoginPage(Driver)
                .ClickLoginButton();
        }

        [Then(@"an Account Services menu is displayed in the left hand side")]
        public void ThenAnAccountServicesMenuIsDisplayedInTheLeftHandSide()
        {
            LoginPage loginPage = new LoginPage(Driver);
            Assert.IsTrue(loginPage.AccountServicesPanel.Displayed);
        }

        [Given(@"I login to Parabank website")]
        public void GivenILoginToParabankWebsite()
        {
            UserInformationDetailsDto populateLoginCredentials = new UserInformationDetailsDto();
            new LoginPage(Driver)
                .PopulateLoginFields(populateLoginCredentials)
                .ClickLoginButton();
        }

        [When(@"I click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            new LoginPage(Driver)
                .ClickLogoutButton();
        }

        [Then(@"the Register button is displayed")]
        public void ThenTheRegisterButtonIsDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.RegisterButton.Displayed);
        }

    }
}
