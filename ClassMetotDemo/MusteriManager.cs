using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi");
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.DogumTarihi + " " + musteri.KimlikNumarasi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi");
            Console.WriteLine("Müşteri Listelendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.DogumTarihi + " " + musteri.KimlikNumarasi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi");
            Console.WriteLine("Müşteri Silindi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.DogumTarihi + " " + musteri.KimlikNumarasi);
        }
    }
}

