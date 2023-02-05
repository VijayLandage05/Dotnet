using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricCollectionList
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}