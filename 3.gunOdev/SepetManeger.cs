using System;
using System.Collections.Generic;
using System.Text;

namespace _3.gunOdev
{
    class SepetManeger
    {

        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Kaydı Yapıldı : " + musteri.MusteriAdi);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteri Kaydı Silindi : " + musteri.MusteriId);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteriler Listelendi : " + musteri.MusteriTcNo);
            Console.WriteLine("---------------------------------");

        }



    }
}
