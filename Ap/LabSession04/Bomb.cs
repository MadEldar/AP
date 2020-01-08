using System;
using System.Threading;

namespace LabSession04
{
    public class Bomb
    {
        public Bomb(int timer)
        {
            Timer = timer;
        }

        public int Timer { get; set; }

        public void CountDown()
        {
            new Thread(() => TimerThread(this)).Start();
        }

        private static void TimerThread(Bomb b)
        {
            try
            {
                for (int i = b.Timer; i >= 0; i--)
                {
                    Console.WriteLine("{0}:{1}", i/60, i%60);
                    Thread.Sleep(100);
                }
                b.Detonate();
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Detonate()
        {
            Console.WriteLine("The bomb goes BOOM.");
        }
    }
}
