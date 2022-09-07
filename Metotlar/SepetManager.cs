using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax yazım şekli sanırım
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi  :  "+ urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama, double fiyati, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

             

    }
}
