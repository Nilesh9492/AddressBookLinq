﻿using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookManager addressBookManager = new AddressBookManager();
            //addressBookManager.CreateDataTable();
            addressBookManager.DeleteContactUsingName("zxc");
            addressBookManager.View();
        }
    }
}
