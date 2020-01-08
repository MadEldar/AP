using System;
using System.Threading;

namespace Assignment04
{
    public class Number
    {
        public int Value { get; set; }
        
        public int Timer { get; set; }
        
        public bool Found { get; set; }

        public Number(int value)
        {
            Value = value;
            Timer = 0;
            Found = false;
        }

        public void FindFibonacci()
        {
            new Thread(() =>
            {
                int prev = 0, next = 1;
                while (next < Value)
                {
                    Console.WriteLine(next);
                    int swap = next;
                    next += prev;
                    prev = swap;
                    Thread.Sleep(100);
                }
                Found = true;
                Console.WriteLine(
                    "So Fibonacci gan nhat voi {0} la {1}",
                    Value,
                    next + prev < Value * 2 ? next : prev);
            }).Start();
        }

        public void TimeCounter()
        {
            new Thread(() =>
            {
                while (!Found)
                {
                    Timer += 100;
                    Console.WriteLine(Timer);
                    Thread.Sleep(100);                    
                }
                Console.WriteLine("Mat {0} giay de tim so Fibonacci gan nhat", Convert.ToDouble(Timer/1000));
                Timer = 0;
            }).Start();
        }
    }
}