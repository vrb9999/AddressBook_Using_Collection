using System;
using System.Collections.Generic;
using System.Text;

namespace NoDuplicateEntry
{
    class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public double zip { get; set; }
        public double phoneNumber { get; set; }
        public string email { get; set; }

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
