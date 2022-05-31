using System;
using System.Collections.Generic;
using System.Text;

namespace GetPersonCountByCityOrState
{
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public double zip;
        public double phoneNumber;
        public string email;
        public Contact(string firstName, string lastName, string address, string city, string state, double zip, double phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Contact))
            {
                return false;
            }
            return (this.firstName == ((Contact)obj).firstName)
                && (this.lastName == ((Contact)obj).lastName);
        }
    }
}
