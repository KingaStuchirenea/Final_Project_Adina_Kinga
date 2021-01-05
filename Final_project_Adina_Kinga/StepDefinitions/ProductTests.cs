using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Final_project_Adina_Kinga.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;

namespace Final_project_Adina_Kinga.StepDefinitions
{
    [Binding]
    public sealed class ProductTests : BaseDriver//Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public ProductTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //Check products are displayed

        [Given(@"user navigates to product page")]
        public void GivenUserNavigatesToProductPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ProductsOption.Click();
            homePage.AllowCookies.Click();
            homePage.AcceptCookies.Click();
        }

        [When(@"opens dropdown")]
        public void WhenOpensDropdown()
        {
            HomePage homePage = new HomePage(Driver);
            //hover method -> could be added in helpers
            Actions actions = new Actions(Driver);
            actions.MoveToElement(homePage.ProductsDropdown).Perform();
        }

        [Then(@"9 products should be displayed")]
        public void ThenProductsShouldBeDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(3000);
            homePage.NineProductsDisplayed();
        }

        //Request for Parasoft Jtest trial registered with success

        [Given(@"user navigates to Parasoft Jtest page")]
        public void GivenUserNavigatesToParasoftJtestPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ProductsOption.Click();
            homePage.AllowCookies.Click();
            homePage.AcceptCookies.Click();
            homePage.ProductsDropdown.Click();
            homePage.ProductsDropdown.Click();
            //scrolls down page 1000px -> could be added in helpers
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,1000)", "");
            Thread.Sleep(5000);
            homePage.ParasoftJtestBlock.Click();
        }

        [When(@"populates request for trial form")]
        public void WhenPopulatesRequestForTrialForm()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.TryParasoftJtestButton.Click();
            homePage.PopulateTryJtestForm("Mary", "Smith", "Parabank", "Agent", "mary.smith@123.com", 0798765432, "France");
        }

        [When(@"sends request")]
        public void WhenSendsRequest()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.TryParasJtestButton.Click();
        }

        [Then(@"request is registered")]
        public void ThenRequestIsRegistered()
        {
            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(homePage.SubmitMessageParasoftJtest.Displayed);
        }

        //Request for Parasoft Jtest trial NOT registered -> Warning message

        [Given(@"user navigates to Jtest page")]
        public void GivenUserNavigatesToJtestPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ProductsOption.Click();
            homePage.AllowCookies.Click();
            homePage.AcceptCookies.Click();
            homePage.ProductsDropdown.Click();
            homePage.ProductsDropdown.Click();
            //scrolls down page 1000px -> could be added in helpers
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,1000)", "");
            Thread.Sleep(5000);
            homePage.ParasoftJtestBlock.Click();
        }

        [When(@"populates request for trial form partially")]
        public void WhenPopulatesRequestForTrialFormPartially()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.TryParasoftJtestButton.Click();
            homePage.PopulateTryJtestFormPartially("Parabank", "Agent", "mary.smith@123.com", 0798765432, "France");
        }

        [When(@"sends the request")]
        public void WhenSendsTheRequest()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.TryParasJtestButton.Click();
        }

        [Then(@"request is NOT registered")]
        public void ThenRequestIsNotRegistered()
        {
            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(homePage.WarningMessageParasoftJtest.Displayed);
        }
    }
}
