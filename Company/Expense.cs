using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Expense
    {
        protected int ID;
        public string date;
        public string paymentMethod;
        public string description;
        public Expense()
        {
            DefineName();
            Console.WriteLine($"Enter the ID of the order: ");
            ID =Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Enter the date of the order: ");
            date = Console.ReadLine();
            Console.WriteLine($"Enter the payment method of the order: ");
            paymentMethod =Console.ReadLine();
            Console.WriteLine($"Enter the description of the order: ");
            description =Console.ReadLine();
        }
        public Expense(int id, string Date, string MethodOfPayment, string desc)
        {
            DefineName();
            ID = id;
            date = Date;
            paymentMethod = MethodOfPayment;
            description = desc;
        }
        public virtual void print()
        {
            Console.WriteLine($"\t\tThe id is \" {ID} \"\n\t\tThe required date is: \" {date} \"\n"+
                $"\t\tThe payment method " +
                $" is: \" {paymentMethod} \"\n\t\tThe description  is: \" {description} \"\n");
        }
        public virtual void DefineName()
        {
            Console.WriteLine("We are on the Expense type.");
        }
    }
}

