using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem with Linq");
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            addressBookOperations.AddColumns();
            addressBookOperations.InsertContacts();
            addressBookOperations.Display();
            //Console.WriteLine("\n");
            //addressBookOperations.EditContactUsingFirstName();
            //addressBookOperations.EditContactUsingLastName();
            //addressBookOperations.DeleteContactUsingName();            
            //addressBookOperations.RetrieveByCity();
            //addressBookOperations.RetrieveByState();
            //addressBookOperations.GetCountByCity();
            //addressBookOperations.GetCountByState();
            //addressBookOperations.ArrangeAlphabeticallyForAGivenCity();
            addressBookOperations.GetCountByType();
        }
    }
}
