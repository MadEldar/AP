using System;
using System.Linq;

namespace Assignment05
{
    class Program
    {
        public static Foreigner[] ForeignerList = new Foreigner[0];
        public static Vietnamese[] VietnameseList = new Vietnamese[0];
        
        static void Main(string[] args)
        {
            Vietnamese hai = new Vietnamese(1, "Le Huy Hai", "01/10/2020", 73, "Vip");
            Foreigner mark = new Foreigner(2, "Mark Skilink", "01/10/2020", 68, "Canadian");
            Foreigner sarah = new Foreigner(3, "Sarah Mcguire", "01/10/2020", 103, "American");
            Foreigner arlene = new Foreigner(4, "Arlene", "01/10/2020", 84, "Australian");
            hai.GetInfo();
            mark.GetInfo();
            sarah.GetInfo();
            arlene.GetInfo();
            Foreigner.AverageBill();
            PrintAllBillByMonth("01");
            GetTotalQuantity();
        }

        private static void GetTotalQuantity()
        {
            Console.WriteLine("\nTong dinh muc tieu thu cua khach hang Viet nam: {0}",
                VietnameseList.Select(v=> v.Quantity).Sum());
            Console.WriteLine("\nTong dinh muc tieu thu cua khach hang nuoc ngoai: {0}",
                ForeignerList.Select(f=> f.Quantity).Sum());
        }

        private static void PrintAllBillByMonth(string month)
        {
            Console.WriteLine("\nDanh sach khach hang Viet nam");
            foreach (Vietnamese vietnamese in VietnameseList.Where(v => v.ReceiptDate.StartsWith(month)))
            {
                Console.WriteLine("Id: {0, -3} Name: {1, -15} Date: {2, 10} Quantity: {3, -5} Client type: {4}",
                    vietnamese.Id, vietnamese.Name, vietnamese.ReceiptDate, vietnamese.Quantity, vietnamese.ClientType);
            }
            
            Console.WriteLine("\nDanh sach khach hang nuoc ngoai: ");
            foreach (Foreigner foreigner in ForeignerList.Where(f => f.ReceiptDate.StartsWith(month)))
            {
                Console.WriteLine("Id: {0, -3} Name: {1, -15} Date: {2, 10} Quantity: {3, -5} Nationality: {4}",
                    foreigner.Id, foreigner.Name, foreigner.ReceiptDate, foreigner.Quantity, foreigner.Nationality);                
            }
        }
    }
}