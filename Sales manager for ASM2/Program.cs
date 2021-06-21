using System;

namespace Sales_manager_for_ASM2
{
    class Program
    {
        User[] List = new User[50];
        int n = 3;
        public void Nhap()
        {
            int choice = 1;
            int i = 0;
            while (choice != 0)
            {
                Console.WriteLine("          ---------------------------------");
                Console.WriteLine("         |          |Sales Manager|        |");
                Console.WriteLine("         |---------------------------------");
                Console.WriteLine("         |          1. Customer            |");
                Console.WriteLine("         |          2. Staff               |");
                Console.WriteLine("         |          3. Update by ID        |");
                Console.WriteLine("         |          4. Display             |");
                Console.WriteLine("         |          5. Delete              |");
                Console.WriteLine("         |          6. Exit                |");
                Console.WriteLine("         |                                 |");
                Console.WriteLine("         |_________________________________| ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Customer L = new Customer();
                        L.Nhap();
                        List[i] = new Customer();
                        List[i] = L;
                        i = i + 1;
                        break;
                    case 2:
                        Staff ST = new Staff();
                        ST.Nhap();
                        List[i] = new Staff();
                        List[i] = ST;
                        i = i + 1;
                        break;
                    case 3:
                    case 4:
                    case 5:
                    default: choice = 0; break;
                }
            }
            n = i;
        }
        public void In()
        {
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|List of Customer and Staff|");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("ID\tName\tAge\tMail\t\tPhone/Salary\tAddress/Location");
            for (int i = 0; i < n; i++)
                List[i].In();
            Console.WriteLine(" __________________________");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Nhap();
            P.In();
            Console.ReadLine();
        }
    }
}
