using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    internal class Kus: Hayvan
    {
        private string kanat_uzunlugu;

        public static void KusOlustur(int id)
        {
            Kus kus = new Kus();

            Console.WriteLine("\n-------\nIsim giriniz: ");
            kus.isim = Console.ReadLine();

            Console.WriteLine("Kafes Numarası: ");
            kus.kafes_numarasi = Console.ReadLine();

            Console.WriteLine("Yas giriniz: ");
            kus.yas = Console.ReadLine();

            Console.WriteLine("Kanat uzunluğu giriniz: ");
            kus.kanat_uzunlugu = Console.ReadLine();


            kus.id = id;

            HayvanatBahcesi.KusListesi.Add(kus);
        }

        public static void KusOku()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("kuslar:");
            foreach (var item in HayvanatBahcesi.KusListesi)
            {
               
                Console.WriteLine("Id: " + item.id);
                Console.WriteLine("Isim: " + item.isim);
                Console.WriteLine("Kafes numarası: " + item.kafes_numarasi);
                Console.WriteLine("Yas: " + item.yas);
                Console.WriteLine("Kanat uzunkugu: "+item.kanat_uzunlugu);

                Console.WriteLine("Ayak sayısı:");
                item.AyakSayisi();
            }
        }


        public override void AyakSayisi()
        {
            Console.WriteLine("2 ayaklıdır");
        }
    }
}
