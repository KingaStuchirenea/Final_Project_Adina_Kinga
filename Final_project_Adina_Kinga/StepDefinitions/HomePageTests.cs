using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Final_project_Adina_Kinga.PageObjects;

namespace Final_project_Adina_Kinga.StepDefinitions
{
    [Binding]
    public sealed class HomePageTests : BaseDriver // Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public HomePageTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //Customer care form populated and registered with success

        [Given(@"User populates Customer Care Form")]
        public void GivenUserPopulatesCustomerCareForm()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ContactButton.Click();
            homePage.PopulateCustomerCareForm("John Miller", "john.miller@somemail.com", 0798765432, "Message text for customer care support.");
        }

        [When(@"clicking on Send to customer care button")]
        public void WhenClickingOnSubmitButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.SubmitButton.Click();
        }

        [Then(@"message is registered")]
        public void ThenMessageIsRegistered()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.SubmitMessage.Displayed);
        }

        //Customer care form populated partially, message NOT registered -> Warning message

        [Given(@"User populates partially Customer Care Form")]
        public void GivenUserPopulatesPartiallyCustomerCareForm()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ContactButton.Click();
            homePage.PopulatePartiallyCustomerCareForm("John Miller", 0798765432, "Message text for customer care support.");
        }

        [When(@"click on Send to customer care button")]
        public void WhenClickOnSendToCustomerCareButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.SubmitButton.Click();
        }

        [Then(@"warning message appears")]
        public void ThenWarningMessageAppears()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.WarningMessage.Displayed);
        }

        //As admin, initialize and clean database

        [Given(@"User navigates to Admin page")]
        public void GivenUserNavigatesToAdminPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AdminPageOption.Click();
        }

        [When(@"clicks on initialize button")]
        public void WhenClicksOnInitializeButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.InitializeButton.Click();
        }

        [Then(@"database is initialized")]
        public void ThenDatabaseIsInitialized()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DatabaseInitializedMessage.Displayed);
        }

        [When(@"clicks on clean button")]
        public void WhenClicksOnCleanButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.CleanButton.Click();
        }

        [Then(@"database is cleaned")]
        public void ThenDatabaseIsCleaned()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DatabaseCleanedMessage.Displayed);
        }

    }
}
