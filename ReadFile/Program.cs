using System;
using System.IO;

namespace ReadFile
{
    class Example
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Vijay Landage\OneDrive\Desktop\Module End Test -OOPs with Java-2_files\inputt.txt";
            string [] lines;

            //check if file exists
            if(File.Exists(filepath))
            {
                lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }else
            {
                Console.WriteLine("File does not exixts");
            }
        }
    }
}