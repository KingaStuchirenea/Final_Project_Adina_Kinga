using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Final_project_Adina_Kinga.Tests
{
    [TestFixture]
    public class LoginTests : Hooks
    {
        [Test]
        public void OpenBrowser()
         {
            Driver.Navigate().GoToUrl(BasePage.ParaBank);
}
    }
}
