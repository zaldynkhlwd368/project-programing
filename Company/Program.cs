using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomingMessage();
            Customer customer = new Customer();
           // customer.print();
           // Customer customer2 = new Customer(1, "prosite", "sana'a hail street", "Noor@gmail.com", "Yemen", "Noor", "Khalid", "Al-Mashreqi");
           // customer2.print();
            TypesOfServices();
            if (DoYouWantToOrder() == true)
            {
                Order[] or = new Order[1];
                or[0] = new orderDetail();
                //or[1]= new orderDetail();
                or[0].print();
                //Expense e1 = new Expense(1, "12/23/2023", "ATM", "it is good");
                //e1.print();
                Expense e2 = new Expense();
                e2.print();
                Payments p2 = new Payments();
                p2.print();
                //Payments p1 = new Payments(1, "12/23/2023", "ATM", "it is good", 2, "12/56/2020", "Cooky", 2000);
                //p1.print();
            }
            else
            {
                Console.WriteLine("You are out of \" NROH-K \"");
            }
            Console.ReadLine();
        }
       
        static void WelcomingMessage()
        {
            Console.WriteLine("WELLCOME to \" NROH-K \" company\n");
        }
        static void TypesOfServices()
        {
            Console.WriteLine("The types of the orders which we provide are:\n1- Web design.\n2- Programming.\n3- Database.");
        }
        static bool DoYouWantToOrder()
        {
            bool choice = false;
            string answer;
            Console.WriteLine("Do you want to order.\nPlease enter\" yes\" as an answer for yes and enter\" no \" as an answer for no.");
            answer = Console.ReadLine();
            if (answer != null && answer.ToUpper() == "YES")
            {
                choice = true;
                return choice;
            }
            else
            {
                return choice;

            }
        }

    }
}
