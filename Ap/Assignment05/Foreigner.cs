using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment05
{
    public class Foreigner : Client
    {
        public string Nationality { get; set; }
        private static int price = 2000;

        public Foreigner(int id, string name, string receiptDate, int quantity, string nationality) : base(id, name, receiptDate, quantity)
        {
            Nationality = nationality;
            Bill = Quantity * price;
            Program.ForeignerList = new List<Foreigner>( Program.ForeignerList ){this}.ToArray();
            CalculateBill();
        }

        public override void GetInfo()
        {
            Console.WriteLine("\nId: {0, -3} Name: {1, -15} Date: {2, 10} Quantity: {3, -5} Nationality: {4}",
                Id, Name, ReceiptDate, Quantity, Nationality);   
        }

        public override void CalculateBill()
        {
            Bill = Quantity * price;
        }

        public static void AverageBill()
        {
            Console.WriteLine(
                "\nTrung binh thanh tien cua khach hang nuoc ngoai la: {0}",
                Program.ForeignerList.Select(o => o.Bill).ToArray().Average()
            );
        }
    }
}