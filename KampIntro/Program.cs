using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // Do not repeat yourself = Kendini Tekrarlama
            // değer tutucu , alias
            string  KategoriEtiketi = "Kategorii" ;
            int ogrencısayısı = 3200 ;
                double faizOrani = 1.45 ;
            bool SistemeGirisYapmisMi = true;
            double DolarinDunkiDegeri = 7.35;
            double DolarBuGun = 7.25;

            if (DolarinDunkiDegeri>DolarBuGun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if(DolarinDunkiDegeri<DolarBuGun)
            {
                Console.WriteLine("Artış butonu göster");
            }
            else
            {
                Console.WriteLine("Değişen birşey yok ");
            }

            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine(" Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yap");
            }

            Console.WriteLine(KategoriEtiketi);
        }
    }
}
