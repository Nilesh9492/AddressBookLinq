using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

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
    }
}
