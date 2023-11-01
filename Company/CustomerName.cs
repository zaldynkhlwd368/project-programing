using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company
{
    class CustomerName
    {
        private string FirstName;
        private string MiddleName;
        private string LastName;
        public string firstName { set; get; }
        public string lastName { set; get; }
        public CustomerName(string fN, string MN, string LN)
        {
            FirstName = fN;
            MiddleName = MN;
            LastName = LN;
            Welcome(FirstName, LastName);
        }
        public CustomerName()
        {
            Console.WriteLine("Enter the customer's first name: ");
           string fN = Console.ReadLine();
            Console.WriteLine("Enter the customer's middle name: ");
          string MN = Console.ReadLine();
            Console.WriteLine("Enter the customer's last name: ");
           string LN = Console.ReadLine();
            FirstName = fN;
            MiddleName = MN;
            LastName = LN;
            Welcome(FirstName,LastName);
        }

        public void print()
        {
            Console.WriteLine($"\t\tThe customer first name is \"{FirstName}\"\n\t\tThe customer middle name is \"{MiddleName}\"\n" +
                $"\t\tThe customer third name is \"{LastName}\"\n");
        }
        private void Welcome(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
            Console.WriteLine($"\t\tHello, {FirstName} {LastName}");
            Console.WriteLine("\t\tYou are now on \" NROH-k \" comany");
        }
    }
}
