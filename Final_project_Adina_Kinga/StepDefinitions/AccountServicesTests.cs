﻿using Final_project_Adina_Kinga.PageObjects;
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

    }
}
