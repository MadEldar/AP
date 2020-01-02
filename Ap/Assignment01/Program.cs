using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 so tu nhien: ");
            Number n = new Number(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(n.GetNearestFib());
        }
    }
}