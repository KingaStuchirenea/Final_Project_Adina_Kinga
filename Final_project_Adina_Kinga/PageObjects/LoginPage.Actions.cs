using System.Threading;
using Final_project_Adina_Kinga.Dto;
using OpenQA.Selenium;

namespace Final_project_Adina_Kinga.PageObjects
{
    partial class LoginPage : BaseDriver
    {
        public LoginPage PopulateLoginFields(UserInformationDetailsDto loginAccount)
        {
            Thread.Sleep(1000);
            TypeTextCss(UsernameLoginField, loginAccount.Username);
            TypeTextCss(PasswordLoginField, loginAccount.Password);
            return this;
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ClickLogoutButton()
        {
            LogoutButton.Click();
        }

    }
}
