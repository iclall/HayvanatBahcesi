using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    
    internal class Ziyaretci: Insan
    {
        private string ziyaret_tarihi;
        private string egitim_durumu;
        

        public static void ZiyaretciOlustur(int id)
        {
          Ziyaretci ziyaretci = new Ziyaretci();

            Console.WriteLine("\n-------\nIsim giriniz: ");
            ziyaretci.isim = Console.ReadLine();

            Console.WriteLine("Yas giriniz: ");
            ziyaretci.yas = Console.ReadLine();

            Console.WriteLine("Ziyaret tarihi giriniz: ");
            ziyaretci.ziyaret_tarihi = Console.ReadLine();

            Console.WriteLine("Ogrenci mi \n e|h: ");
            ziyaretci.egitim_durumu = Console.ReadLine();
            if (ziyaretci.egitim_durumu == "e")
                Console.WriteLine("Öğrenci indirimini unutmayınız");

            ziyaretci.id = id;

            HayvanatBahcesi.ZiyaretciListesi.Add(ziyaretci);

            ziyaretci.InsanMesaji();

        }

        public override void InsanMesaji()
        {
            Console.WriteLine("--\nZiyaretci başarılı bir şekilde oluşturuldu.");
        }

        public static void ZiyaretciOku()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("ziyaretciler:");
            foreach (var item in HayvanatBahcesi.ZiyaretciListesi)
            {
                Console.WriteLine("\nid: " + item.id);
                Console.WriteLine("isim: " + item.isim);
                Console.WriteLine("yas: " + item.yas);
                Console.WriteLine("maas: " + item.ziyaret_tarihi);
                Console.WriteLine("ogrenci mi: " + item.egitim_durumu);

            }



        }
    }
}
