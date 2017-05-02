using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string adress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + adress);
            Console.WriteLine("Tel. " + phoneNumber);
            if (faxNumber != "")
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            else
            {
                Console.WriteLine("Fax: (no fax)");
            }
            Console.WriteLine("Web site: " + website);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
        }
    }
}
