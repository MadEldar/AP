using System;
using System.Threading;

namespace LabSession04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bomb b = new Bomb(120);
            b.CountDown();
            Bomb b2 = new Bomb(600);
            b2.CountDown();
        }
    }
}