using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class ContestEntryData
    {
        private string _StreetAddress2;
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddressOne { get; set; }
        public string StreetAddressTwo
        {
            get
            {
                return _StreetAddress2;
            }
            set
            {
                _StreetAddress2 = string.IsNullOrEmpty(value) ? null : value;
            }
        }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }

        //default constructor 
        public ContestEntryData()
        {

        }
        //greedy constructor
        public ContestEntryData(string firstName, string lastName, string streetAddressOne, 
                                string streetAddressTwo, string city, string province, 
                                string postalCode, string email)
        {

            FirstName = firstName;
            LastName = lastName;
            StreetAddressOne = streetAddressOne;
            StreetAddressTwo = streetAddressTwo;
            City = city;
            Province = province;
            PostalCode = postalCode;
            Email = email;
        }
    }
}