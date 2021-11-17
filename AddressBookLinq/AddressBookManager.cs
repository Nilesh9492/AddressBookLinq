using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace AddressBookLinq
{
    class AddressBookManager
    {
        DataTable dataTable;
        public void CreateDataTable()
        {
            dataTable = new DataTable();

            DataColumn dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "FirstName";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "LastName";
            dataColumn.Caption = "Last Name";
            dataColumn.AutoIncrement = false;

            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "Address";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "City";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "State";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "Email";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(Int64);
            dataColumn.ColumnName = "PhoneNumber";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(Int64);
            dataColumn.ColumnName = "Zip";
            dataColumn.Caption = "Zip";
            dataColumn.AutoIncrement = false;
            dataTable.Columns.Add(dataColumn);

        }
        public int AddValues()
        {
            CreateDataTable();
            AddressBook DataManager = new AddressBook();
            AddressBook DataManager1 = new AddressBook();

            DataManager.firstName = "Nilesh";
            DataManager.lastName = "Bhamare";
            DataManager.phoneNumber = 9876543210;
            DataManager.emailId = "nil@gimail.com";
            DataManager.address = "hggfgh";
            DataManager.city = "dhl";
            DataManager.state = "mh";
            DataManager.zipCode = 423652;
            InsertintoDataTable(DataManager);

            DataManager1.firstName = "nil";
            DataManager1.lastName = "mm";
            DataManager1.phoneNumber = 9632587410;
            DataManager1.emailId = "fhf@gmail.com";
            DataManager1.address = "hgg";
            DataManager1.city = "mhhh";
            DataManager1.state = "mh";
            DataManager1.zipCode = 412365;
            InsertintoDataTable(DataManager1);

            DataManager1.firstName = "zxc";
            DataManager1.lastName = "fg";
            DataManager1.phoneNumber = 1236547890;
            DataManager1.emailId = "abc@gmail.com";
            DataManager1.address = "asdfg xyz";
            DataManager1.city = "qwe";
            DataManager1.state = "mh";
            DataManager1.zipCode = 789654;
            InsertintoDataTable(DataManager1);
            return dataTable.Rows.Count;
        }

        public void InsertintoDataTable(AddressBook contactDataManager)
        {
            DataRow dtRow = dataTable.NewRow();
            dtRow["FirstName"] = contactDataManager.firstName;
            dtRow["LastName"] = contactDataManager.lastName;
            dtRow["Address"] = contactDataManager.address;
            dtRow["City"] = contactDataManager.city;
            dtRow["State"] = contactDataManager.state;
            dtRow["Zip"] = contactDataManager.zipCode;
            dtRow["PhoneNumber"] = contactDataManager.phoneNumber;
            dtRow["Email"] = contactDataManager.emailId;
            dataTable.Rows.Add(dtRow);

        }
        public bool EditDataTableUsingName(string FirstName, string ColumnName)
        {
            AddValues();
            var modifiedList = (from Contact in dataTable.AsEnumerable() where Contact.Field<string>("FirstName") == FirstName select Contact).LastOrDefault();
            if (modifiedList != null)
            {
                modifiedList[ColumnName] = "Mahesh";
                View();
                return true;
            }
            return false;
        }
        public bool DeleteContactUsingName(string FirstName)
        {
            AddValues();
            var modifiedList = (from Contact in dataTable.AsEnumerable() where Contact.Field<string>("FirstName") == FirstName select Contact).FirstOrDefault();
            if (modifiedList != null)
            {
                modifiedList.Delete();
                Console.WriteLine("Contact list After Deleteion");
                View();
                return true;
            }
            return false;
        }
        public void View()
        {
            foreach (DataRow dtRows in dataTable.Rows)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}\n", dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
            }
        }
    }
}
