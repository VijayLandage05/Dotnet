using System;
using System.IO;

namespace LogicalDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                // will print drives available in system 
                Console.WriteLine(drive);
            }
        }
    }
}