using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----REF Keyword-----");
            // ilk değer verilmiş ama;
            // metodun içerisinde değerin değişebilceğini düşünüyorsak ref keyword ünü kullanabiliriz
            int sayi1 = 30;
            int sayi2 = 50;
            var toplam = Toplama(ref  sayi1,sayi2);
            
            Console.WriteLine("ref keyword Toplam  : "+toplam);
            Console.WriteLine("ref keyword Sayi 1  : "+sayi1);
            Console.WriteLine("\n");

            Console.WriteLine("-----OUT Keyword-----");
            //out keyword ile ilk değer vermek zorunda değiliz ancak mutlaka değer metodun içerisinde
            // bir kere set edilmiş olması gerekiyor. Hatta ilk değerimiz geçersiz olacaktır.

            int sayi3 = 90;
            int sayi4 = 40;
            var toplam2 = Toplama2(out sayi3, sayi4);
            Console.WriteLine("out keyword Toplam  : " + toplam2);
            Console.WriteLine("out keyword Sayi 3  : " + sayi3);

            Console.ReadLine();
        }

        static int Toplama( ref int sayi1, int sayi2)
        {
             sayi1 = 10;
            return sayi1 + sayi2;
            
        }
        static int Toplama2(out int sayi3, int sayi4)
        {
            sayi3 = 80;
            return sayi3 + sayi4;

        }

    }
    
}
