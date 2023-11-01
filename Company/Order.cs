using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
     
    abstract class Order
    {
        protected int orderId;
        private int quantity;
        private double discount;
        public string type { set; get; }
        public string notes { set; get; }
        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if (discount <= 0)
                {

                    discount = 0;
                }
                else if (discount == 0.03 || discount == 0.09 || discount == 0.12 || discount == 0.2 || discount == 0.23) 
                {
                    discount = value;
                }
                else
                {
                    discount = 0;
                }
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity <= 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }
        public Order()
        {
            checkType();
            Console.WriteLine("Enter the customer's order id:");
            orderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the notes of the order");
            notes = Console.ReadLine();
        }

        private string TypeOfOrder()
        {
            Console.WriteLine("What kind of order you want to order:\nEnter the right number for the type.\n1- Web design.\n2- Programming.\n3- Database.");
            int choiseOfType = Convert.ToInt32( Console.ReadLine());
            switch(choiseOfType)
            {
                case 1:
                    return "Web design";
                case 2:
                    return "Programming";
                case 3:
                    return "Database";
                default:
                    return "No type";
            }
        }
        private void checkType()
        {
            int i = 0;
            type = TypeOfOrder();

            while (type == "No type")
            {
                    type=TypeOfOrder();
                i++;
            } 
           CheckQuantity();

        }
        private void CheckQuantity()
        {
            Console.WriteLine($"How much quantity do you want of the order of \" {type} \".\n");
            quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity >= 1 || quantity < 3)
                discount = 0.03;
            else if (quantity >= 3 || quantity < 6)
                discount = 0.09;
            else if (quantity >= 6 || quantity < 10)
                discount = 0.12;
            else if (quantity >= 10 || quantity < 15)
                discount = 0.2;
            else if (quantity == 0)
                discount = 0;
            else
                discount = 0.23;
        }
        public virtual void print()
        {
            Console.WriteLine($"\t\tThe order id is \" {orderId}\"\n\t\tThe order's notes are \" {notes}\"\n\t\tThe quantity of the asked orders are:\" {quantity} \"\n" +
                $"\t\tThe discount of The customer's orders is:" +
                $"\" {discount} \"");
        }
        abstract public double CountQuantityAndDiscount();
        
    }
}
