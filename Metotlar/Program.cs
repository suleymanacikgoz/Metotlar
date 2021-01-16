using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (var i in urunler)
            {
                Console.WriteLine(i.Adi + " (" + i.Fiyati + "TL) " + "-" + i.Aciklama);

            }
            Console.WriteLine("-------------------Metotlar------------------");

            //encapsulation




            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,15);
            sepetManager.Ekle2("elma", "yeşil elma", 12,34);
            sepetManager.Ekle2("karpuz", "yeşil karpuz", 12,48);


        }
    }
}


// dont repeat yourself