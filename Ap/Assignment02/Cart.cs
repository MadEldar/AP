using System;
using System.Collections.Generic;

namespace Assignment03
{
    public class Cart
    {
        private int _id;
        private string _name;
        private int _grandTotal;
        private Product[] _productList = new Product[0];
        private string _city;
        private string _country;

        public Cart(int id, string name, string city, string country)
        {
            Id = id;
            Name = name;
            City = city;
            Country = country;
            GrandTotal = CalculateGrandTotal();
        }

        public void GetInfo()
        {
            Console.WriteLine("{0, -3} {1, -20} {2, -10} {3, 1}", Id, Name, City, Country);
            Console.WriteLine("Products list:");
            foreach (Product product in ProductList)
            {
                product.GetInfo();
            }
            Console.WriteLine("Grand total of products: {0, 1}\n", GrandTotal);
        }

        public void AddToCart(Product product)
        {
            ProductList = new List<Product>(ProductList) {product}.ToArray();
        }

        public void RemoveFromCart()
        {
            Console.WriteLine("Products in cart:");
            foreach (Product product in ProductList)
            {
                product.GetInfo();
            }
            Console.WriteLine("Remove product by Id:\n");
            int idToRemove = Convert.ToInt32(Console.ReadLine());
            List<Product> products = new List<Product>(ProductList);
            products.RemoveAll(product => product.Id == idToRemove);
            ProductList = products.ToArray();
        }

        public int CalculateGrandTotal()
        {
            _grandTotal = 0;
            foreach (Product product in ProductList)
            {
                _grandTotal += product.Price * product.Quantity;
            }
            _grandTotal += _grandTotal / (City == "HN" ? 100 : City == "HCM" ? 50 : 20); 
            
            return _grandTotal;
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

        public int GrandTotal
        {
            get => CalculateGrandTotal();
            set => _grandTotal = value;
        }

        public Product[] ProductList
        {
            get => _productList;
            set => _productList = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }
    }
}