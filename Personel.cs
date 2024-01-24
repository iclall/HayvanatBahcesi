using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    internal class Personel:Insan
    {
        private string maas;
        private string unvan;
     
        public static void PersonelOlustur(int id)
        {

            Personel personel = new Personel();

            Console.WriteLine("\n-------\nIsim giriniz: ");
            personel.isim = Console.ReadLine();

            Console.WriteLine("Unvan giriniz: ");
            personel.unvan = Console.ReadLine();

            Console.WriteLine("Maas giriniz: ");
            personel.maas = Console.ReadLine();

            Console.WriteLine("Yas giriniz: ");
            personel.yas = Console.ReadLine();

            personel.id = id;

            HayvanatBahcesi.PersonelListesi.Add(personel);
            personel.InsanMesaji();
        }

        public override void InsanMesaji()
        {
            Console.WriteLine("--\nPersonel başarılı bir şekilde oluşturuldu.");
        }

        public static void PersonelOku()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("personeller :");
            foreach (var item in HayvanatBahcesi.PersonelListesi)
            {
                Console.WriteLine("\nid: " + item.id);
                Console.WriteLine("isim: " + item.isim);
                Console.WriteLine("unvan: " + item.unvan);
                Console.WriteLine("maas: " + item.maas);
                Console.WriteLine("yas: " + item.yas);

            }
        }


    }
}
