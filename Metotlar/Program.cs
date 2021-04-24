using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { "Elma", "Karpuz" };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            //deneme github
            Console.WriteLine("deniyorum git hub");
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("-------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut","Yeşil",22,50);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 2992,96);
            sepetManager.Ekle2("Elma", "Sarı", 252,26);
        }
    }
}
