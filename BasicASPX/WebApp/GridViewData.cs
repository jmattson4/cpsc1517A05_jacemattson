using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class GridViewData
    {
        public string Fullname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FullOrPartime { get; set; }
        public string Jobs { get; set; }

        public GridViewData()
        {

        }

        public GridViewData(string fullName, string emailAddress, string phoneNumber, string fullOrPartTime, string jobs)
        {
            Fullname = fullName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            FullOrPartime = fullOrPartTime;
            Jobs = jobs;
        }
    }
}