using System;
using System.Collections.Generic;
using System.Text;

namespace NoDuplicateEntry
{
    class AddressBook
    {
        //THE LIST STORES MULTIPLE CONTACTS
        public List<Contact> contactList = new List<Contact>();

        // SPECIFIES THE NAME OF THE ADDRESS BOOK
        public string addressBookName;

        public AddressBook(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }

        //ADDS A NEW CONTACT TO THE LIST "CONTACTLIST"
        public void AddNewContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name : ");
            contact.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.lastName = Console.ReadLine();

            if (contactList.Find(i => contact.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }

            Console.WriteLine("Enter Email : ");
            contact.email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.phoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Address : ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter Zip : ");
            contact.zip = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter State : ");
            contact.state = Console.ReadLine();

            contactList.Add(contact);            
        }

        public void SearchContactByName()
        {
            bool flag = true;
            Console.WriteLine("Enter the first name of contact you want to view");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of contact you want to view");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nDetails of " + firstName + " " + lastName + ":");
            foreach (var v in contactList)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("FullName: " + v.firstName + " " + v.lastName + "\nAddress: " + v.address + "\nCity: " + v.city + "\nState: " + v.state + "\nZip: " + v.zip + "\nPhoneNumber: " + v.phoneNumber + "\nEmail: " + v.email + "\n");
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Contact not found");
        }

        public void ViewAllContacts()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("\nFullName: " + contact.firstName + " " + contact.lastName + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZip: " + contact.zip + "\nPhoneNumber: " + contact.phoneNumber + "\nEmail: " + contact.email + "\n");
            }
        }
        
        //EDIT DETAILS OF AN EXISTING CONTACT USING NAME
        public void EditContact()
        {
            bool flag1 = true;
            Console.WriteLine("Enter first name of the contact to edit");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            foreach (var contact in contactList)
            {
                if (firstName == contact.firstName && lastName == contact.lastName)
                {
                    Console.WriteLine("\nTo edit contact details of " + firstName + " " + lastName + " enter:");
                    bool flag2 = true;
                    while (flag2)
                    {
                        Console.WriteLine("1-To update first name\n2-To update last name\n3-To update address\n4-To update city\n5-To update state\n6-To update zip\n7-To update phone number\n8-To update email\n9-To exit edit portal and save updates");
                        int updatePointer = Convert.ToInt32(Console.ReadLine());
                        if (updatePointer == 9)
                            break;
                        Console.WriteLine("Enter the new value");
                        var newValue = Console.ReadLine();
                        switch (updatePointer)
                        {
                            case 1:
                                contact.firstName = newValue;
                                break;
                            case 2:
                                contact.lastName = newValue;
                                break;
                            case 3:
                                contact.address = newValue;
                                break;
                            case 4:
                                contact.city = newValue;
                                break;
                            case 5:
                                contact.state = newValue;
                                break;
                            case 6:
                                contact.zip = Convert.ToDouble(newValue);
                                break;
                            case 7:
                                contact.phoneNumber = Convert.ToDouble(newValue);
                                break;
                            case 8:
                                contact.email = newValue;
                                break;
                            case 9:
                                flag2 = false;
                                break;
                        }
                        Console.WriteLine("Contact details updated successfully");
                        flag1 = false;
                    }
                }
            }
            if (flag1 == true)
                Console.WriteLine("Error:Contact not found");
        }

        //DELETE AN EXISTING CONTACT USING NAME
        public void DeleteContact()
        {
            bool flag = true;
            Console.WriteLine("Enter the first name of contact you want to delete");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of contact you want to delete");
            string lastName = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                if (firstName == contactList[i].firstName && lastName == contactList[i].lastName)
                {
                    /// REMOVES THE VALUE AT THE POSITION WHICH CONTAINS THE ENTERED NAME
                    contactList.RemoveAt(i);
                    Console.WriteLine("\nContact {0} {1} deleted successfully", firstName, lastName);
                    flag = false;
                }
            }
            if (flag == true)
                Console.WriteLine("Error:Contact not found");
        }
    }
}
