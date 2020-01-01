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
            _id = id;
            _name = name;
            _city = city;
            _country = country;
            _grandTotal = CalculateGrandTotal();
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
            GrandTotal = 0;
            foreach (Product product in ProductList)
            {
                GrandTotal += product.Price * product.Quantity;
                Console.WriteLine(product.Price * product.Quantity);
            }
            GrandTotal += GrandTotal / (City == "HN" ? 100 : City == "HCM" ? 50 : 20); 
            Console.WriteLine(GrandTotal);
            
            return GrandTotal;
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
            get => _grandTotal;
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