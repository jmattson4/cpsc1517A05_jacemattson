using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class UserRegData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public UserRegData()
        {

        }
        public UserRegData(string firstName, string lastName, string userName, string emailAddress,
                                    string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}