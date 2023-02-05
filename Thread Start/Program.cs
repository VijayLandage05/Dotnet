using System;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static void getThreadInfo()
        {
            Console.WriteLine("Current thread is : " + Thread.CurrentThread.Name);
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            //Thread(ThreadStart) constructor with Static Method
            Thread t1 = new Thread(new ThreadStart(getThreadInfo));
            t1.Name = "Tread 1";
            t1.Start();
        }
    }
}