using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";
            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 35;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1,urun2};
            //type safe tip güvenli soldaki Urun int gibi classı gösteriyor (varda yazsan olur) 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("-------Metotlar-------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil",16,6);
            sepetManager.Ekle2("Elma", "Armut", 14,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 33,35);

        }
    }
}



// Dont repeat yourself - DRY - Clean Code - Best Practice En iyi uygulama teknıklerı
