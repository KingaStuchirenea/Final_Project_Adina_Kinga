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

        // Open new account

        [Given(@"logged in with valid user")]
        public void GivenLoggedInWithValidUser()
        {
            AccountServices accountServices = new AccountServices(Driver);
            accountServices.LoginValidUser("John.Miller", "John.Miller123");
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
            Thread.Sleep(2000);
            accountServices.OpenNewAccountButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the account is created")]
        public void ThenTheAccountIsCreated()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Assert.IsTrue(accountServices.AccountOpenedMessage.Displayed);
        }

        // Transfer funds

        [Given(@"navigate to transfer funds")]
        public void GivenNavigateToTransferFunds()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Thread.Sleep(1000);
            accountServices.TransferFundsOption.Click();
            Thread.Sleep(2000);
        }

        [When(@"transfering the inserted amount")]
        public void WhenTransferingTheInsertedAmount()
        {
            AccountServices accountServices = new AccountServices(Driver);
            accountServices.AmountField.SendKeys("100");
            Thread.Sleep(2000);
            accountServices.TrandferButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the tranfer is done")]
        public void ThenTheTranferIsDone()
        {
            AccountServices accountServices = new AccountServices(Driver);
            Assert.IsTrue(accountServices.TransferCompleteMessage.Displayed);
        }

        // Request a loan

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


    }
}
