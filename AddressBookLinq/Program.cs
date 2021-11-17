using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookManager addressBookManager = new AddressBookManager();
            //addressBookManager.CreateDataTable();
            //addressBookManager.DeleteContactUsingName("zxc");
            //addressBookManager.View();
            //addressBookManager.RetrievePerson("dhl","mh");
            //addressBookManager.CountByCityState();
            addressBookManager.Sort("dhl");
        }
    }
}
