using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler  "+urun.Id+"  kodlu ürününüz olan: "+urun.Adi+"  sepetinize eklenmiştir");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler  " +urunAdi);
        }
    }
}
