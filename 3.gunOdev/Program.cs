using System;

namespace _3.gunOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();

            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyAdi = "Bakır";
            musteri1.MusteriTcNo = "43434343";
            musteri1.MusteriId = 343;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAdi = "Mahmut";
            musteri2.MusteriSoyAdi = "Çetin";
            musteri2.MusteriTcNo = "343434";
            musteri2.MusteriId = 54545;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriAdi = "Beril";
            musteri3.MusteriSoyAdi = "Nazlı";
            musteri3.MusteriTcNo = "435454";
            musteri3.MusteriId = 43434;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı = " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı = " + musteri.MusteriSoyAdi);
                Console.WriteLine("Müşteri Tc Kimlik NUmarası = " + musteri.MusteriTcNo);
                Console.WriteLine("Müşteri Id Numarası = " + musteri.MusteriId);
                Console.WriteLine();
                Console.WriteLine("----------DiğerMüsteri--------");
                Console.WriteLine();
            }

            Console.WriteLine("-----------Metotlar----------");
            Console.WriteLine();
            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(musteri1);
            sepetManeger.Ekle(musteri2);
            sepetManeger.Ekle(musteri3);










        }
    }
}
