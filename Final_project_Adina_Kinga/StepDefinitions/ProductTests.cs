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
    public sealed class ProductTests : Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public ProductTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

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
            //hover method - could be added in helpers
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

    }
}
