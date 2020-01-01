using System;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart(1, "Hai\'s cart", "HN", "Vietnam");
            cart.AddToCart(new Product(1, "Moxpad X3", 450000, 1, "Internet",
                "Tai nghe Moxpad X3", new string[] {"moxpadx3.png"}));
            cart.AddToCart(new Product(2, "Moxpad X6", 700000, 3, "Internet",
                "Tai nghe Moxpad X6", new string[] {"moxpadx6.png"}));
            cart.AddToCart(new Product(3, "Moxpad X9", 860000, 2, "Internet",
                "Tai nghe Moxpad X9", new string[] {"moxpadx9.png"}));
            cart.AddToCart(new Product(4, "Marshall Mode", 2700000, 1, "Internet",
                "Tai nghe Marshall Mode den", new string[] {"marshallmode.png"}));
            cart.RemoveFromCart();
            Console.WriteLine("Grand total of products is {0, 1}\n", cart.GrandTotal);
            cart.GetInfo();
        }
    }
}