using Final_project_Adina_Kinga.PageObjects;
using Final_project_Adina_Kinga.Models;
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
            RegisterAccount createForm = new RegisterAccount();
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
    }
}
