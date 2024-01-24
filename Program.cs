namespace Vize_211450002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personel_sayisi = 0, ziyaretci_sayisi = 0, hayvan_sayisi = 0;
            string gecici_deger;

            HayvanatBahcesi hayvanatBahcesi = new HayvanatBahcesi();
            hayvanatBahcesi.isim = "Karatay";
            Console.WriteLine(hayvanatBahcesi.isim + " Hayvanat Bahçesine Hoşgeldiniz");
            Console.WriteLine("----------------------------");


            do
            {
                Console.WriteLine("\n------\nNe girisi yapmak istersiniz: \na)Insan\nb)Hayvan ");
                gecici_deger = Console.ReadLine();
                if (gecici_deger == "a")
                {
                    Console.WriteLine("\n--Ne girisi yapmak istersiniz: \np)Personel\nz)Ziyaretci");
                    gecici_deger=Console.ReadLine();

                    if (gecici_deger == "p")
                    {
                        personel_sayisi +=1 ;
                        Personel.PersonelOlustur(personel_sayisi);
                    }
                    else if (gecici_deger == "z")
                    {
                        ziyaretci_sayisi += 1;
                        Ziyaretci.ZiyaretciOlustur(ziyaretci_sayisi);
                    }
                    else
                        Console.WriteLine("Geçerli bir harf giriniz.");
                }
                else if (gecici_deger == "b")
                {
                   
                   Console.WriteLine("\n--Ne girisi yapmak isteniz: \nm)Memeli\nk)Kus");
                    gecici_deger = Console.ReadLine();
                    if (gecici_deger == "m")
                    {
                        hayvan_sayisi += 1;
                        Memeli.MemeliOlustur(hayvan_sayisi);
                    }
                    else if(gecici_deger == "k")
                    {
                        hayvan_sayisi += 1;
                        Kus.KusOlustur(hayvan_sayisi);
                    }
                    else
                        Console.WriteLine("Gecerli bir harf giriniz.");

                }
                else
                    Console.WriteLine("Gecerli bir harf giriniz.");
                Console.WriteLine("\n-----------------------------------\n Giriş yapmaya devam etmek istiyor musunuz? \n e|h:");
                gecici_deger = Console.ReadLine();
            } while (gecici_deger == "e");



            do
            {
                Console.WriteLine("\n----------------------------------------------------\n\n------\n Neredeki bilgileri görmek istersiniz: \na)İnsan\nb)Hayvan\nc)Bütün girişler");
                gecici_deger=Console.ReadLine();
                if(gecici_deger == "c")
                {
                    Personel.PersonelOku();
                    Ziyaretci.ZiyaretciOku();
                    Memeli.MemeliOku();
                    Kus.KusOku();
                    break;

                }
                else if ( gecici_deger == "a")
                {
                    Console.WriteLine("\n--Neredeki bilgileri görmek istersiniz:\np)Personel\nz)ziyaretci");
                    gecici_deger = Console.ReadLine();
                    if (gecici_deger == "p")
                    {
                        Personel.PersonelOku();
                    }
                    else if ((gecici_deger == "z"))
                    {
                        Ziyaretci.ZiyaretciOku();
                    }
                    else
                        Console.WriteLine("Gecerli bir harf giriniz.");
                }
                else if(gecici_deger =="b")
                {
                    Console.WriteLine("\n--Neredeki bilgileri görmek istersiniz: \nm)Memeli \nk)Kus");
                    gecici_deger=Console.ReadLine();
                     if (gecici_deger == "m")
                     {

                        Memeli.MemeliOku();

                     }
                     else if (gecici_deger == "k")
                     {
                         Kus.KusOku();
                     }
                     else
                         Console.WriteLine("Gecerli bir harf giriniz.");
                }
                Console.WriteLine("\n-----------------------------------\n Görüntülemeye devam etmek istiyor musunuz? \n e|h:");
                gecici_deger=Console.ReadLine();
            }
            while (gecici_deger=="e");        
        }
    }
}