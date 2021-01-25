using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.KimlikNumarasi = 1111111;
            musteri1.Adi = "Deniz";
            musteri1.Soyadi = "Besli";
            musteri1.DogumTarihi = "Agustos";

            Musteri musteri2 = new Musteri();
            musteri2.KimlikNumarasi = 22222222;
            musteri2.Adi = "Burak";
            musteri2.Soyadi = "Besli";
            musteri2.DogumTarihi = "Mayıs";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
                Console.WriteLine(musteri.KimlikNumarasi + " " + musteri.Adi + " " + musteri.DogumTarihi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
        }
    }
}
