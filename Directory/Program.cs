using System;
using System.IO;

namespace DirectoryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdir = @"E:\2-CDAC\Module 8-DotNET\DotNET Lab\Practice\Sample Directory";

            if(!Directory.Exists(rootdir))
            {
                // To create Directory
                Directory.CreateDirectory(rootdir);
                Console.WriteLine("Directory Created");
            }else
            {
                //To delete Directory
                Directory.Delete(rootdir);
                Console.WriteLine("Directory Deleted");
            }
        }
    }
}