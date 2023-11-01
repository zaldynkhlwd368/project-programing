using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company
{
    class Customer
    {
       private int customerId;
        private string company;
        private string address;
        public string country;
        public string[] phone;
        private string email;
        CustomerName name; //{ set; get; }
        public string Company { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        private void EnterPhone()
        {
            Console.WriteLine("How many phones do the customer have:");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            phone = new string[phoneNumber];
            for (int i = 0; i<phone.Length ;i++ )
            {
                Console.WriteLine("Enter phone number "+ (i+1));
                phone[i] = Console.ReadLine();
            }
        }
        public Customer()
        {
            name = new CustomerName();
            Console.WriteLine("Enter the customer id, please:");
            
            customerId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the company that customer comes from, please:");
            company = Console.ReadLine();
            Console.WriteLine("Enter the address of the customer , please:");
            address = Console.ReadLine();
            Console.WriteLine("Enter the email of the customer , please:");
            email = Console.ReadLine();
            Console.WriteLine("Enter the country of the customer , please:");
            country = Console.ReadLine();
            EnterPhone();
        }
    public Customer(int cusId, string company, string address, string email, string country, string fN, string MN, string LN)
    {
          name = new CustomerName(fN, MN, LN);
          customerId = cusId;
          this.company = company;
          this.address = address;
          this.email = email;
          this.country = country;
          EnterPhone();
     }
   public void print()
        {
            name.print();
            Console.WriteLine($"\t\tThe customer id is \" {customerId} \"\n\t\tThe company name is \" {company} \"\n\t\tThe address is \" {address} \"\n" +
                $"\t\tThe email is \" {email} \"\nThe country is \" {country} \"\n");
            Console.WriteLine("\t\tThe phones of the customer are:");
            printPhone(phone);

        }
     private void printPhone( /*params*/ string[] phone )
        {
            foreach (string n in phone)
            {
                Console.WriteLine("\t\t"+n);
            }
        }
    }
}

