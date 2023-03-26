using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа2
{
    internal class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public int AppartmentNumber { get; set; }
        public int PostCode { get; set; }

        public Address( string country, string city, string street, string homenumber, int appartmentNumber, int postcode )
        {

            Country = country;
            City = city;
            Street = street;
            HomeNumber = homenumber;
            AppartmentNumber = appartmentNumber;
            PostCode = postcode;
        }
        public string GetAddressInformation()
        {
            return string.Format ("Country:{0}, City: {1}, Street:{2}, Homenumber: {3}, Appartment: {4}, Posctcode: {5}", Country, City, Street, HomeNumber, AppartmentNumber, PostCode);

 

        }

    }

    
}
