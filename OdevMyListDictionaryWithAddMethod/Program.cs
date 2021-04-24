using System;
using System.Collections.Generic;

namespace OdevMyListDictionaryWithAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> Cities = new Dictionary<int, string>();
            Cities.Add(34, "İstanbul");
            Cities.Add(41, "Kocaeli");
            Cities.Add(54, "Sakarya");

            Console.WriteLine(Cities[34]);
        }
    }
}
