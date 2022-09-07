using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Muhammet";
            int yas = 36;


            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.kursEgitmen = "Engin Demirog";
            kurs1.İzlenmeOrani = 69;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.kursEgitmen = "Kerem";
            kurs2.İzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.kursEgitmen = "Berkay";
            kurs3.İzlenmeOrani = 80;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "C++";
            kurs4.kursEgitmen = " Murat ";
            kurs4.İzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.kursEgitmen);

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.kursEgitmen);
            }




        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string kursEgitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
