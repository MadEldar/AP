﻿using System;

namespace LabSession03
{
    public delegate void Notififcation(string str);
    
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Moxpad X3", 450000, 1, "Internet",
                "Tai nghe Moxpad X3", new string[] {"moxpadx3.png"});
            Product p2 = new Product(2, "Moxpad X6", 700000, 3, "Internet",
                "Tai nghe Moxpad X6", new string[] {"moxpadx6.png"});
            Product p3 = new Product(3, "Moxpad X9", 860000, 2, "Internet",
                "Tai nghe Moxpad X9", new string[] {"moxpadx9.png"});
            Product p4 = new Product(4, "Marshall Mode", 2700000, 1, "Internet",
                "Tai nghe Marshall Mode den", new string[] {"marshallmode.png"});
            p1.Quantity = 2;
            p2.Quantity = 0;
            p2.Quantity = 4;
            Cart cart = new Cart(1, "Hai\'s cart", "HN", "Vietnam");
            cart.AddToCart(p1);
            cart.AddToCart(p2);
            cart.AddToCart(p3);
            cart.AddToCart(p4);
            cart.RemoveFromCart();
            Console.WriteLine("Grand total of products is {0, 1}\n", cart.GrandTotal);
            cart.GetInfo();
        }
    }
}