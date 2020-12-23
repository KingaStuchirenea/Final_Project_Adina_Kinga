using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga
{
    class User
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }


        public User GetValidUser()
        {
            User validUser = new User();
            if (this.userEmail != null)
            {
                validUser.userEmail = userEmail;
            }
            else
            {
                validUser.userEmail = string.Empty;

            }

            if (this.userPassword != null)
            {
                validUser.userPassword = userPassword;
            }
            else
            {
                validUser.userPassword = string.Empty;

            }
            return validUser;
        }
    }
}
