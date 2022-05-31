using System;
using System.Collections.Generic;
using System.Text;

namespace SearchPersonAcrossMultipleAddressBook
{
    class AddressBookList
    {
        public Dictionary<string, AddressBook> addressBookListDictionary = new Dictionary<string, AddressBook>();
        //ADDS A NEW ADDRESS BOOK WITH UNIQUE NAME TO THE SYSTEM
        public void AddNewAddressBook()
        {
            Console.WriteLine("Enter the name of address book:");
            string addressBookName = Console.ReadLine();
            AddressBook addressBook = new AddressBook(addressBookName);
            // HANDLES THE EXCEPTION WHEN THE USER TRIES TO ENTER DUPLICATE ADDRESS BOOK NAME
            try
            {
                addressBookListDictionary.Add(addressBookName, addressBook);
                Console.WriteLine("\nAddress Book " + addressBookName + " added successfully");
            }
            catch (Exception)
            {
                Console.WriteLine("Address Book {0} already exists, please access it or add a new address book with different name!", addressBookName);
            }
        }
        /// CHECKS FOR AN EXISTING ADDRESS BOOK IN THE SYSTEM
        public string ExistingAddressBook()
        {
            Console.WriteLine("Enter the Address Book name");
            string addressBookName = Console.ReadLine();
            string result = "";
            bool flag = true;
            foreach (var kvp in addressBookListDictionary)
            {
                if (kvp.Key == addressBookName)
                {
                    result = addressBookName;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("No Address Book with name " + addressBookName + " found\nPlease create a new address book");
            }
            return result;
        }
        public void ListOfAddressBook()
        {
            Console.WriteLine("List of Address Book");
            foreach (KeyValuePair<string, AddressBook> listOfAddressBook in addressBookListDictionary)
            {
                Console.WriteLine(listOfAddressBook.Key);
            }
        }
        public void SearchPersonInCityOrState(string firstName, string lastName)
        {
            foreach (var addressBookEntry in addressBookListDictionary)
            {
                List<Contact> PersonInCitiesOrStates = addressBookEntry.Value.contactList.FindAll(i => (i.firstName == firstName) && (i.lastName == lastName));
                foreach (Contact person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.firstName} {person.lastName} is in {person.city} {person.state}");
                }
            }
        }
    }
}
