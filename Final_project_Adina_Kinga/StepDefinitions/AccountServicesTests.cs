using Final_project_Adina_Kinga.Dto;
using Final_project_Adina_Kinga.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Final_project_Adina_Kinga.StepDefinitions
{
    [Binding]
    public sealed class AccountServicesTests : BaseDriver
    {

        private readonly ScenarioContext _scenarioContext;

        public AccountServicesTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"logged in with valid user")]
        public void GivenLoggedInWithValidUser()
        {
            AccountServices accountServices = new AccountServices(Driver);
            accountServices.LoginValidUser("john.miller", "john.miller123");
        }

        [Given(@"navigate to open new account")]
        public void GivenNavigateToOpenNewAccount()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Thread.Sleep(1000);
            accountServices.OpenNewAccountOption.Click();
        }

        [When(@"choosing to open savings account")]
        public void WhenChoosingToOpenSavingsAccount()
        {
            AccountServices accountServices = new AccountServices(Driver);
            accountServices.SavingsOption.Click();
            accountServices.OpenNewAccountButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"the account is created")]
        public void ThenTheAccountIsCreated()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Assert.IsTrue(accountServices.AccountOpenedMessage.Displayed);
        }

        [Given(@"I am logged in with valid user")]
        public void GivenIAmLoggedInWithValidUser()
        {
            UserInformationDetailsDto populateLoginCredentials = new UserInformationDetailsDto();
            new LoginPage(Driver)
                .PopulateLoginFields(populateLoginCredentials)
                .ClickLoginButton();
        }

        [Given(@"I navigate to request loan page")]
        public void GivenINavigateToRequestLoanPage()
        {
            new AccountServices(Driver)
                .GoToRequestALoanPage();
        }

        [When(@"filling in requested details")]
        public void WhenFillingInRequestedDetails()
        {
            RequestLoanDto loan = new RequestLoanDto();
            new AccountServices(Driver)
                .ApplyForALoan(loan);
        }

        [When(@"clicking Apply Now button")]
        public void WhenClickingApplyNowButton()
        {
            new AccountServices(Driver)
                .ClickApplyNow();
        }

        [Then(@"a confirmation table message is displayed")]
        public void ThenAConfirmationTableMessageIsDisplayed()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(accountServices.LoanProviderTable.Displayed);
        }

        [Given(@"I navigate to Update Contact Info page")]
        public void GivenINavigateToUpdateContactInfoPage()
        {
            new AccountServices(Driver)
                .GoToUpdateContactInfoPage();
        }

        [When(@"filling the updated information fields")]
        public void WhenFillingTheUpdatedInformationFields()
        {
            UserInformationDetailsDto contactInfo = new UserInformationDetailsDto();
            new AccountServices(Driver)
                .UpdateContactInfo(contactInfo);
        }

        [When(@"clicking Update Contact Info button")]
        public void WhenClickingUpdateContactInfoButton()
        {
            new AccountServices(Driver)
                .ClickUpdateProfileButton();
        }

        [Then(@"a confirmation message is shown")]
        public void ThenAConfirmationMessageIsShown()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(accountServices.UpdateProfileMessage.Displayed);
        }

    }
}
