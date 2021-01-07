using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class ProductPage: BaseDriver
    {
        public void NineProductsDisplayed()
        {
            Assert.IsTrue(Product1.Displayed);
            Assert.IsTrue(Product2.Displayed);
            Assert.IsTrue(Product3.Displayed);
            Assert.IsTrue(Product4.Displayed);
            Assert.IsTrue(Product5.Displayed);
            Assert.IsTrue(Product6.Displayed);
            Assert.IsTrue(Product7.Displayed);
            Assert.IsTrue(Product8.Displayed);
            Assert.IsTrue(Product9.Displayed);
        }

        public void PopulateTryJtestForm(string firstName, string lastName, string company, string jobTitle, string email, int phone, string country)
        {
            Thread.Sleep(1000);
            FirstNameFieldJtest.SendKeys(firstName);
            LastNameFieldJtest.SendKeys(lastName);
            CompanyFieldJtest.SendKeys(company);
            JobtitleFieldJtest.SendKeys(jobTitle);
            EmailFieldJtest.SendKeys(email);
            PhoneFieldJtest.SendKeys(phone.ToString());
            CountryDropdownJtest.SendKeys(country);
        }

        public void PopulateTryJtestFormPartially(string company, string jobTitle, string email, int phone, string country)
        {
            Thread.Sleep(1000);
            CompanyFieldJtest.SendKeys(company);
            JobtitleFieldJtest.SendKeys(jobTitle);
            EmailFieldJtest.SendKeys(email);
            PhoneFieldJtest.SendKeys(phone.ToString());
            CountryDropdownJtest.SendKeys(country);
        }
    }
}
