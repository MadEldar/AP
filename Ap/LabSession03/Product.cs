using System;

namespace LabSession03
{
    public class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private int _quantity;
        private string _image;
        private string _desc;
        private string[] _gallery = new string[10];

        private static event Notififcation Event;

        public Product(int id, string name, int price, int quantity, string image, string desc, string[] gallery)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Image = image;
            Desc = desc;
            Gallery = gallery;
        }

        public void GetInfo()
        {
            Console.WriteLine("{0, -3} {1, -20} {2, -30} {3, -10} {4, -3} {5, -1}",
                Id, Name, Desc, Price, Quantity, Image);
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (Event == null)
                {
                    Event += DisplayMessage;
                }

                if (value > Quantity)
                {
                    Event("So luong san pham tang len " + (value - Quantity) + " san pham, len thanh " + value);
                }
                else if (value < Quantity)
                {
                    Event("So luong san pham giam di " + (Quantity - value) + " san pham, xuong con " + value);
                }
                else
                {
                    Event("So luong san pham khong doi tai " + Quantity + " san pham");
                }
                
                _quantity = value;
            }
        }

        public string Image
        {
            get => _image;
            set => _image = value;
        }

        public string Desc
        {
            get => _desc;
            set => _desc = value;
        }

        public string[] Gallery
        {
            get => _gallery;
            set => _gallery = value;
        }
    }
}