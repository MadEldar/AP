using System;
using Ap.LabSession02;

namespace LabSession02
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(
                1,
                "Moxpad X9",
                860000,
                2,
                "Internet",
                "Tai nghe Moxpad X9",
                new string[] {"moxpadx9.png", "moxpadx9.img", "moxpadx9.icon", "moxpadx9.svg"}
            );
            p.GetInfo();
            p.CheckStock();
            p.AddToGallery("moxpadx9.favicon");
            p.RemoveFromGallery();
            p.GetInfo();
        }
    }
}