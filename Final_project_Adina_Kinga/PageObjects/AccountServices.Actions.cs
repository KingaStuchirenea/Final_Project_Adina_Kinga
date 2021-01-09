using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project_Adina_Kinga.Dto;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class AccountServices : BaseDriver
    {
        public void LoginValidUser(string user, string password)
        {
            UsernameField.SendKeys(user);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public void GoToRequestALoanPage()
        {
            RequestLoanOption.Click();
        }
        public AccountServices ApplyForALoan(RequestLoanDto requestLoan)
        {
            TypeTextId(LoanAmountField, requestLoan.LoanAmount.ToString());
            TypeTextId(DownPaymentField, requestLoan.DownPayment.ToString());
            TypeTextId(FromAccountDropdown, requestLoan.FromAccount);
            return this;
        }

        public void ClickApplyNow()
        {
            ApplyNowButton.Click();
        }
    }
}
