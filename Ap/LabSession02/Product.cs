using System;
using System.Collections.Generic;

namespace Ap.LabSession02
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

        public Product()
        {
            Console.WriteLine("Nhap id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap gia:");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so luong:");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap link anh:");
            Image = Console.ReadLine();
            Console.WriteLine("Nhap mieu ta:");
            Desc = Console.ReadLine();
            Console.WriteLine("Tao gallery anh: ");
        }

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
            Console.WriteLine("{0, -5} {1, -10} {2, -20} {3, -10} {4, -4} {5, -15}",
                Id, Name, Desc, Price, Quantity, Image);
            Console.WriteLine("Gallery:");
            for (int i = 0; i < Gallery.Length; i++)
            {
                Console.WriteLine("          {0, -2} {1, -30}", i + 1, Gallery[i]);
            }
            Console.WriteLine();
        }

        public void CheckStock()
        {
            if (Quantity > 0)
            {
                Console.WriteLine("In stock");
            }
            else
            {
                Console.WriteLine("Out of stock");
            }

            Console.WriteLine();
        }

        public void AddToGallery(string image)
        {
            if (Gallery.Length < 10)
            {
                List<string> galleryList = new List<string>(Gallery);
                galleryList.Add(image);
                Gallery = galleryList.ToArray();
            }
            else
            {
                Console.WriteLine("Gallery anh da day, vui long xoa anh truoc khi tiep tuc.\n");
            }
        }

        public void RemoveFromGallery()
        {
            Console.WriteLine("Gallery:");
            for (int i = 0; i < Gallery.Length; i++)
            {
                Console.WriteLine("{0, -2} {1, -30}", i + 1, Gallery[i]);
            }
            Console.WriteLine("Remove image at:\n");
            List<string> galleryList = new List<string>(Gallery);
            galleryList.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
            Gallery = galleryList.ToArray();
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