using System;
using System.Collections.Generic;

namespace Assignment03
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
            set => _quantity = value;
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