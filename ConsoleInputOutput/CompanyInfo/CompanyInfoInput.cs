using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInfo
{
    class CompanyInfoInput
    {
        static void Main()
        {
            Console.Write("Company name:");
            string cName = Console.ReadLine();
            Console.Write("Company address:");
            string address = Console.ReadLine();
            Console.Write("Phone number:");
            string cPhone = Console.ReadLine();
            Console.Write("Fax number:");
            string fax = Console.ReadLine();
            Console.Write("Web site:");
            string site = Console.ReadLine();
            Console.Write("Manager first name:");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name:");
            string lastName = Console.ReadLine();
            Console.Write("Manager age:");
            string age =Console.ReadLine();
            Console.Write("Manager phone:");
            string phone = Console.ReadLine();

            Console.WriteLine(cName);
            Console.WriteLine("Address: {0}",address);
            Console.WriteLine("Tel. {0}", cPhone);
            Console.WriteLine(fax);
            Console.WriteLine("Web site: {0}",site);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,phone);

        }

    }
}
