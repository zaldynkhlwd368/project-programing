using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Payments : Expense
    {
        private int checkNo;
        private int amount;
        public string bankName;
        public string CheckDate;
       // private const string nameOfClass = "Payment";
        public int CheckNo
        {
            get
            {
                return checkNo;
            }
            set
            {
                if (checkNo <= 0)
                {
                    checkNo = 0;
                }
                else
                    checkNo = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (amount <= 0)
                {
                    amount = 0;
                }
                else
                    amount = value;
            }
        }
        public override void DefineName()
        {
            Console.WriteLine("You are done with EXPENSES.\nNow Please,enter some information about the payments of the order:");
            Console.WriteLine("  -------------------------------------------------   ");
        }
        public Payments() :base()
        {
            Console.WriteLine($"Enter the check number of the order: ");
            checkNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the check date of the order: ");
            CheckDate = Console.ReadLine();
            Console.WriteLine($"Enter the amount of the order: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the bank name to where the payments of the order was paid to : ");
            bankName = Console.ReadLine();
        }
        public Payments(int id, string Date, string MethodOfPayment, string desc, int checkNum, string checkDate, string bankName, int amount) : base(id, Date, MethodOfPayment, desc)
        {
            checkNo = checkNum;
            this.bankName = bankName;
            this.amount = amount;
            this.CheckDate = checkDate;
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"\t\tThe check number of the payments is: \" {checkNo} \"\n\t\tThe check date of the payments is: \" {CheckDate} \"\n" +
                $"\t\tThe amount of the payments is: \" {amount} \"\n\t\tThe bank name to where the payments were paid is: \" {bankName} \"\n ");
        }
    }
}
