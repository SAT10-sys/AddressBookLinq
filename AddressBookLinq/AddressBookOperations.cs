using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace AddressBookLinq
{
    public class AddressBookOperations
    {
        public DataTable addressBook = new DataTable();
        //method to add columns in address book table
        public void AddColumns()
        {
            addressBook.Columns.Add("FirstName", typeof(string));
            addressBook.Columns.Add("LastName", typeof(string));
            addressBook.Columns.Add("Address", typeof(string));
            addressBook.Columns.Add("City", typeof(string));
            addressBook.Columns.Add("State", typeof(string));
            addressBook.Columns.Add("ZipCode", typeof(string));
            addressBook.Columns.Add("PhoneNumber", typeof(string));
            addressBook.Columns.Add("EmailID", typeof(string));
        }
        //insert contacts into table
        public void InsertContacts()
        {
            addressBook.Rows.Add("James", "Hetfield", "DownTown", "San Francisco", "California", "123456", "1234567890", "jh34@gmail.com");
            addressBook.Rows.Add("Cliff", "Burton", "Manhattan", "New York City", "New York", "234567", "2345678901", "cbtr5@gmail.com");
            addressBook.Rows.Add("Mike", "Shinoda", "Newark", "New York City", "New York", "345678", "3456789012", "ms34r@yahoo.com");
            addressBook.Rows.Add("Saul", "Hudson", "Chamartin", "Madrid", "Madrid Province", "456789", "4567890123", "shrt5@gmail.com");
            addressBook.Rows.Add("Pep", "Guardiola", "Camp Nou", "Barcelona", "Catalonia", "567890", "5678901234", "pg56yt@gmail.com");
            addressBook.Rows.Add("Sourav", "Ganguly", "Behala", "Kolkata", "West Bengal", "678901", "6789012345", "sgtr54@gmail.com");
            addressBook.Rows.Add("Anthony", "Kiedis", "Queens", "New York City", "New York", "789012", "7890123456", "aku65@yahoo.com");
            addressBook.Rows.Add("Walter", "White", "Colma", "San Francisco", "California", "890123", "8901234567", "wwr45@gmail.com");
            addressBook.Rows.Add("Steve", "Clarke", "Rajarhat", "Kolkata", "West Bengal", "901234", "9012345678", "scgt4@yahoo.com");
            addressBook.Rows.Add("Sachin", "Tendulkar", "Bandra", "Mumbai", "Maharashtra", "908765", "9087654321", "srt200@yahoo.com");
        }
        //display the table
        public void Display()
        {
            foreach(DataColumn column in addressBook.Columns)
                Console.Write(column.ToString().PadRight(20));
            foreach(DataRow row in addressBook.Rows)
            {
                Console.WriteLine();
                foreach(DataColumn column in addressBook.Columns)
                    Console.Write(row[column].ToString().PadRight(20));
            }
        }
        //edit contact using first name
        public void EditContactUsingFirstName()
        {
            string firstName = "Saul";
            var contactToUpdate = addressBook.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(firstName)).FirstOrDefault();
            if(contactToUpdate!=null)
            {
                contactToUpdate.SetField("Address", "Rosas");
                contactToUpdate.SetField("EmailID", "shg21@yahoo.com");
                Console.WriteLine("\n Address and EmailID of {0} edited successfully",firstName);
                Display();
            }
            else
                Console.WriteLine("Invalid entry");
        }
        //edit contact using last name
        public void EditContactUsingLastName()
        {
            string lastName = "White";
            var contactToUpdate = addressBook.AsEnumerable().Where(x => x.Field<string>("LastName").Equals(lastName)).FirstOrDefault();
            if(contactToUpdate!=null)
            {
                contactToUpdate.SetField("PhoneNumber", "8017642387");
                Console.WriteLine("\n Phone Number of {0} edited successfully",lastName);
                Display();
            }
            else
                Console.WriteLine("Invalid entry");
        }
        //delete contact using name
        public void DeleteContactUsingName()
        {
            string name = "Steve";
            var contactToDelete = addressBook.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if(contactToDelete!=null)
            {
                contactToDelete.Delete();
                Console.WriteLine("\n Contact with name {0} deleted",name);
                Display();
            }
        }
        //retrieve contact by city
        public void RetrieveByCity()
        {
            string city = "New York City";
            var contactsToFind = addressBook.AsEnumerable().Where(x => x.Field<string>("City") == city);
            Console.WriteLine("\n Contact(s) belonging to {0} city in the address book",city);          
            foreach (DataRow row in contactsToFind)
            {
                foreach(DataColumn column in addressBook.Columns)
                    Console.Write(row[column].ToString().PadRight(20));
                Console.Write("\n");
            }
        }
        //retrieve contact by state
        public void RetrieveByState()
        {
            string state = "West Bengal";
            var contactsToFind = addressBook.AsEnumerable().Where(x => x.Field<string>("State") == state);
            Console.WriteLine("\n Contact(s) belonging to {0} state in the address book", state);      
            foreach (DataRow row in contactsToFind)
            {
                foreach (DataColumn column in addressBook.Columns)
                    Console.Write(row[column].ToString().PadRight(20));
                Console.Write("\n");
            }
        }
    }
}
