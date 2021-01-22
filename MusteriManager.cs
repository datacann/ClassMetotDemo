using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        


        public void Add (Musteri musteri1)
        {
                   Console.WriteLine("hoşgeldiniz" + " " + "sayin" + " " + musteri1.Adi + " " + musteri1.Soyadi);
        }

        public void Delete(Musteri musteri1)
        {           
            Console.WriteLine("sayin" + " " + musteri1.Adi + " " + musteri1.Soyadi + " " + "kaydiniz basariyle silinmistir.");
        }

        public void List(Musteri[] musteriler)
        {

            foreach(Musteri List in musteriler)

            {

                Console.WriteLine( List.Adi + " " +  List.Soyadi + " " +  List.Yas + " " + List.Id);
            }





        }

    }
}
