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
    public sealed class HomePageTests : Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public HomePageTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

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


    }
}
