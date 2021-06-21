using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_manager_for_ASM2
{
    public class Customer : User
    {
        public string Phone;
        public string Address;
        public Customer() : base() { }
        public Customer(string name, string Id, int age, string mail, string phone, string address) : base(Id, name, age, mail)
        {
            Phone = phone;
            Address = address;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Enter Phone: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
        }

        public override void In()
        {
            base.In();
            Console.WriteLine("\t{0}\t{1}", Phone, Address);
        }
    }
}
