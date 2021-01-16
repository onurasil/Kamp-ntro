using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //burada kurs string ve int gibi bir değişkendir
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Onur Asil";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ayça çelenk";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "deli kız";
            kurs3.IzlenmeOrani = 72;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen+" = " + kurs.IzlenmeOrani+"%");
               
            }

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
        }
      

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }
}
