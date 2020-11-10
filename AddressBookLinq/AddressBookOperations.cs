using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

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
    }
}
