using System;
using System.Collections.Generic;

namespace Assignment05
{
    public class Vietnamese : Client
    {
        public string ClientType { get; set; }

        private static int[] price = {1000, 1200, 1500, 2000};

        private static int[] rate = {50, 50, 100, 0};

        public Vietnamese(int id, string name, string receiptDate, int quantity, string clientType)
            : base(id, name, receiptDate, quantity)
        {
            ClientType = clientType;
            Program.VietnameseList = new List<Vietnamese>( Program.VietnameseList ){this}.ToArray();
            CalculateBill();
        }

        public override void GetInfo()
        {
            Console.WriteLine("\nId: {0, -3} Name: {1, -15} Date: {2, 10} Quantity: {3, -5} Client type: {4}",
                Id, Name, ReceiptDate, Quantity, ClientType);
        }

        public override void CalculateBill()
        {
            int quantity = Quantity;
            Bill = 0;
            int i = 0;
            while (quantity > 0)
            {
                Bill += (quantity > rate[i]) ? rate[i] * price[i] : quantity * price[i];
                quantity -= (rate[i] != 0) ? rate[i] : quantity;
                i++;
            }
        }
    }
}