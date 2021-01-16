using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";
            urun1.Id = 533456897;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 25;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Id = 456789314;

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urunlist in urunler)
            {
                Console.WriteLine(urunlist.Adi);
                Console.WriteLine(urunlist.Aciklama);
                Console.WriteLine(urunlist.Id);
                Console.WriteLine(urunlist.Fiyatı);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("--------Metotlar-----------");
            //instance - örnek 
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,56);
            Console.ReadKey();

        }
    }
}
