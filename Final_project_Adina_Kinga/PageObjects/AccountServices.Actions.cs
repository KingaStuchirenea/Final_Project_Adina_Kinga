using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
