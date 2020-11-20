using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM.Model
{
   public class Address
    {
        string city;
        string zip;
        string street;
        string country;

        public Address(string city, string zip, string street, string country)
        {
            this.City = city;
            this.Zip = zip;
            this.Street = street;
            this.Country = country;
        }

        public string City
        {
            get => city;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("City cannot be empty.");
                }
                city = value; 
            }
        }
        public string Zip { get => zip; set => zip = value; }
        public string Street { get => street; set => street = value; }
        public string Country { get => country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Country cannot be empty.");
                }
                country = value;
            }
        }
    }
}
