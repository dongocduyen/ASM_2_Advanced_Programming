using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_manager_for_ASM2
{
    public class Staff : User
    {
        public string Salary;
        public string Location;
        public Staff() : base() { }
        public Staff(string name, string Id, int age, string mail, string salary, string location) : base(Id, name,  age, mail)
        {
            Salary = salary;
            Location = location;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Enter Salary:");
            Salary = Console.ReadLine();
            Console.WriteLine("Enter Location:");
            Location = Console.ReadLine();
        }

        public override void In()
        {
            base.In();
            Console.WriteLine("{0}\t{1}", Salary, Location);
            
        }
    }
}

