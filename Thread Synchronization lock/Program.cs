using System;
using System.Threading;

namespace SyncLock
{
    class Program
    {
        public void getThreadInfo()
        {
            lock (this)
            {
                for(int i=1; i<5; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("i : " +i+ " " + "Thread Name : " + Thread.CurrentThread.Name);
            }
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Thread t1 = new Thread(new ThreadStart(obj.getThreadInfo));
            Thread t2 = new Thread(new ThreadStart(obj.getThreadInfo));

            t1.Name = "Thread 1";
            t1.Name = "Thread 2";

            t1.Start();
            t2.Start();
        }
    }
}