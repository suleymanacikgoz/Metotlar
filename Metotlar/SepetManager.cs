using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {


        public  void Ekle(Urun urun)
        {

            Console.WriteLine("sepete eklendi :  " + urun.Adi);

        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokadedi)

        {

            Console.WriteLine("sepete eklendi :  " + urunadi);


        }

    }
}
