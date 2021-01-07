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
            ProductPage productPage = new ProductPage(Driver);
            productPage.ProductsOption.Click();
            productPage.AllowCookies.Click();
            productPage.AcceptCookies.Click();
        }

        [When(@"opens dropdown")]
        public void WhenOpensDropdown()
        {
            ProductPage productPage = new ProductPage(Driver);
            //hover method -> could be added in helpers
            Actions actions = new Actions(Driver);
            actions.MoveToElement(productPage.ProductsDropdown).Perform();
        }

        [Then(@"9 products should be displayed")]
        public void ThenProductsShouldBeDisplayed()
        {
            ProductPage productPage = new ProductPage(Driver);
            Thread.Sleep(3000);
            productPage.NineProductsDisplayed();
        }

        //Request for Parasoft Jtest trial registered with success

        [Given(@"user navigates to Parasoft Jtest page")]
        public void GivenUserNavigatesToParasoftJtestPage()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.ProductsOption.Click();
            productPage.AllowCookies.Click();
            productPage.AcceptCookies.Click();
            productPage.ProductsDropdown.Click();
            productPage.ProductsDropdown.Click();
            //scrolls down page 1000px -> could be added in helpers
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,1000)", "");
            Thread.Sleep(5000);
            productPage.ParasoftJtestBlock.Click();
        }

        [When(@"populates request for trial form")]
        public void WhenPopulatesRequestForTrialForm()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.TryParasoftJtestButton.Click();
            productPage.PopulateTryJtestForm("Mary", "Smith", "Parabank", "Agent", "mary.smith@123.com", 0798765432, "France");
        }

        [When(@"sends request")]
        public void WhenSendsRequest()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.TryParasJtestButton.Click();
        }

        [Then(@"request is registered")]
        public void ThenRequestIsRegistered()
        {
            ProductPage productPage = new ProductPage(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(productPage.SubmitMessageParasoftJtest.Displayed);
        }

        //Request for Parasoft Jtest trial NOT registered -> Warning message

        [Given(@"user navigates to Jtest page")]
        public void GivenUserNavigatesToJtestPage()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.ProductsOption.Click();
            productPage.AllowCookies.Click();
            productPage.AcceptCookies.Click();
            productPage.ProductsDropdown.Click();
            productPage.ProductsDropdown.Click();
            //scrolls down page 1000px -> could be added in helpers
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,1000)", "");
            Thread.Sleep(5000);
            productPage.ParasoftJtestBlock.Click();
        }

        [When(@"populates request for trial form partially")]
        public void WhenPopulatesRequestForTrialFormPartially()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.TryParasoftJtestButton.Click();
            productPage.PopulateTryJtestFormPartially("Parabank", "Agent", "mary.smith@123.com", 0798765432, "France");
        }

        [When(@"sends the request")]
        public void WhenSendsTheRequest()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.TryParasJtestButton.Click();
        }

        [Then(@"request is NOT registered")]
        public void ThenRequestIsNotRegistered()
        {
            ProductPage productPage = new ProductPage(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(productPage.WarningMessageParasoftJtest.Displayed);
        }
    }
}
