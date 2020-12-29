using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace Final_project_Adina_Kinga
{

    [Binding]
    public class Hooks : BaseDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            CreateDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            {
                Driver.Quit();
            }
        }
    }
}