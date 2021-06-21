using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_manager_for_ASM2
{
    public class User
    {
        public string ID;
        public string Name;
        public int Age;
        public string Mail;

        public User() { }
        public User(string name, string Id, int age,  string mail)
        {
            Name = name;
            ID = Id;
            Age = age;
            Mail = mail;
        }
        public virtual void In()
        {
            Console.Write("{0}\t{1}\t{2}\t{3}\t", ID, Name, Age, Mail);
        }
       
        public virtual void Nhap()
        {
            Console.WriteLine("Enter ID: ");
            ID = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mail: ");
            Mail = Console.ReadLine();
        }
    }
}
