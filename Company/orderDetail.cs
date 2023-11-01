using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class orderDetail:Order
    {
        private double specialPrice;
        public string startTime;
        public string endTime;
        public string sentTime;
        private double unitPrice;
        public double SpecialPrice
        {
            get { return specialPrice; }
            set
            {
                if(specialPrice<=0)
                {
                    specialPrice = 0;
                }
                else
                    specialPrice = value;
            }
        }
        public orderDetail() : base() 
        {
            Console.WriteLine("Enter the special price of the order detail:");
            specialPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the start time of the order detail:");
            startTime = Console.ReadLine();
            Console.WriteLine("Enter the dead time of the order detail:");
            endTime = Console.ReadLine();
            Console.WriteLine("Enter the sent time of the order detail:");
            sentTime = Console.ReadLine();
        }
        //public OrderDetail(int id, int spe, int start, int end, int sent, int Dis, string des, int qunt)
        //{

        //    orderdetId = id;
        //    specialprice = spe;
        //    satrtTime = start;
        //    endTime = end;
        //    sentTime = sent;
        //    Discount = Dis;
        //    description = des;
        //    quntity = qunt;
        //}
        public override void print()
        {
            base.print();
            Console.WriteLine($"\t\tThe special price of the order is:\" {specialPrice} \"\n\t\tThe start time of the" +
                $" order is:\" {startTime} \"\n" +
                $"\t\tThe endding time of submitting the order is:\" {endTime} \"\n\t\tThe time of senting the order is:\" {sentTime} \"\n" +
                $"\t\tThe unit price of the order is \" {unitPrice=CountQuantityAndDiscount()} \"");
               
        }
        public override double CountQuantityAndDiscount()
        {
            if(Discount== 0.03)
            {
                specialPrice *= Discount;
               return specialPrice * Quantity;
            }
            else if(Discount==0.09)
            {
                specialPrice *= Discount;
                return specialPrice * Quantity;
            }
            else if(Discount== 0.12)
            { 
              specialPrice *= Discount;
                return specialPrice * Quantity;
            }
            else if (Discount == 0.2)
            {
                specialPrice *= Discount;
                return specialPrice * Quantity;
            }
            else
            {
                specialPrice *= Discount;
                return specialPrice * Quantity;
            }
        }

    }
}
