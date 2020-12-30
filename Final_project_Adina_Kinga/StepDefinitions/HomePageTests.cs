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
        }

        //[When(@"clicking on Send to customer care button")]
        //public void WhenClickingOnButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"message is registered")]
        //public void ThenMessageIsRegistered()
        //{
        //    ScenarioContext.Current.Pending();
        //}

    }
}
