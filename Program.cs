using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
        
            string[] musteri = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "atacan";
            musteri1.Soyadi = "erdoğan";
            musteri1.Yas = 25;
            musteri1.Id = 111;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "can";
            musteri2.Soyadi = "kaya";
            musteri2.Yas = 2;
            musteri2.Id = 12;

            MusteriManager x = new MusteriManager();
            x.Add(musteri1);

            x.Delete(musteri2);

            Musteri[] y = new Musteri[] { musteri1, musteri2 };

            x.List(y);

        
        }
    }
}
