using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Onur");

            Console.WriteLine(isimler.Length);

            isimler.Add("Feyza");

            Console.WriteLine(isimler.Length);

            Console.WriteLine("Hello World!");
        }
    }
}
