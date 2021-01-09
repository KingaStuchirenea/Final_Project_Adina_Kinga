using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.Dto
{
    public class UserInformationDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int Phone { get; set; }
        public int SSN { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public UserInformationDetailsDto()
        {
            SetRegistrationData();
            SetRegistrationDataLoginDetails();
        }

        private void SetRegistrationData()
        {
            FirstName = "John";
            LastName = "Doe";
            Address = "John's Address";
            City = "CityTest";
            State = "StateTest";
            ZipCode = "ZipCode";
            Phone = 1234567890;
            SSN = 0987654321;
        }

        private void SetRegistrationDataLoginDetails()
        {
            Username = "John.Doe";
            Password = "password123";
            ConfirmPassword = "password123";
        }
    }
}
