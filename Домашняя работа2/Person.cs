using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа2
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
        public int MobileNumber { get; set; }

        public Person (string firstName, string lastName,Address address, int mobileNumber)
        {
            Firstname = firstName;
            Lastname = lastName;
            Address = address;  
            MobileNumber = mobileNumber;
       
        }
        public string GetPersonInformation()
        {

            return string.Format ("Firstname: {0}, Lastname: {1}, Address: {2}, MobileNumber: {3}",Firstname,Lastname,Address.GetAddressInformation(),MobileNumber);

        }


    }
}
