using System;
using System.IO;

namespace WriteFile
{
    class Example
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Vijay Landage\OneDrive\Desktop\Module End Test -OOPs with Java-2_files\input.txt";
            string lines = "Welcome to the file location";

            if(File.Exists(filepath))
            {
                File.WriteAllText(filepath, lines);
                Console.WriteLine("Writing into file completed");                
            }else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}