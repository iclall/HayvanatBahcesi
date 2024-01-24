using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    internal class Memeli: Hayvan
    {

        public static void MemeliOlustur(int id)
        {
            Memeli memeli = new Memeli();

            Console.WriteLine("\n-------\nIsim giriniz: ");
            memeli.isim = Console.ReadLine();

            Console.WriteLine("Kafes Numarası: ");
            memeli.kafes_numarasi = Console.ReadLine();

            Console.WriteLine("Yas giriniz: ");
            memeli.yas = Console.ReadLine();


            memeli.id = id;

            HayvanatBahcesi.MemeliListesi.Add(memeli);
        }

        public static void MemeliOku()
        {
            Console.WriteLine("---------------------------------");
           
            Console.WriteLine("memeliler:");
            foreach (var item in HayvanatBahcesi.MemeliListesi)
            {
                
                Console.WriteLine("Id: " + item.id);
                Console.WriteLine("Isim: " + item.isim);
                Console.WriteLine("Kafes numarası: " + item.kafes_numarasi);
                Console.WriteLine("Yas: " + item.yas);

                Console.WriteLine("Ayak sayısı:");
                item.AyakSayisi();
            }
        }

        public override void AyakSayisi()
        {
            Console.WriteLine("4 ayaklıdır");
        }
    }
}
