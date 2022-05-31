using System;

namespace SearchPersonAcrossMultipleAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM");
            MainMenuOperation();
        }
        public static void MainMenuOperation()
        {
            AddressBookList addressBookList = new AddressBookList();
            bool flag1 = true;
            while (flag1)
            {
                string currentAddressBookName = "";
                Console.WriteLine("\nEnter:\n1-To add a new address Book\n2-To access list of address book\n3-To access an existing address book\n4-Search person in city or state\n5-To exit");
                int options1 = Convert.ToInt32(Console.ReadLine());
                switch (options1)
                {
                    case 1:
                        addressBookList.AddNewAddressBook();
                        break;
                    case 2:
                        addressBookList.ListOfAddressBook();
                        break;
                    case 3:
                        currentAddressBookName = addressBookList.ExistingAddressBook();
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        addressBookList.SearchPersonInCityOrState(firstName, lastName);
                        break;
                    case 5:
                        flag1 = false;
                        break;
                }
                if (currentAddressBookName != "")
                {
                    bool flag2 = true;
                    while (flag2)
                    {
                        Console.WriteLine("\nCurrent address book:" + currentAddressBookName);
                        Console.WriteLine("Enter:\n1-To add a new contact\n2-To edit an existing contact\n3-To search for an existing contact\n4-To delete a contact\n5-To display all contacts in the address book\n6-To return to main menu");
                        int options2 = Convert.ToInt32(Console.ReadLine());
                        switch (options2)
                        {
                            case 1:
                                addressBookList.addressBookListDictionary[currentAddressBookName].AddNewContact();
                                break;
                            case 2:
                                addressBookList.addressBookListDictionary[currentAddressBookName].EditContact();
                                break;
                            case 3:
                                addressBookList.addressBookListDictionary[currentAddressBookName].SearchContactByName();
                                break;
                            case 4:
                                addressBookList.addressBookListDictionary[currentAddressBookName].DeleteContact();
                                break;
                            case 5:
                                addressBookList.addressBookListDictionary[currentAddressBookName].ViewAllContacts();
                                break;
                            case 6:
                                flag2 = false;
                                break;
                        }
                    }
                }
            }
        }
    }
}
