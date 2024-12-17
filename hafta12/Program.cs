using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hafta12
{
    enum gunler
    {
      //enum bellı baslı tamsayıları string seklınde yazmaya yarıyor ,kolaylık saglıuyor enumlar deger turudur , deger turu tanımlıyor gıbı kullanılır 
      // onden bır deger atamadıgın surece dızı gıbı sıralıyor 
     // namespacenın hemen altında class ıcınde degıl
     //ayrı ayrı ısım vermek zorunda degılım 

        Pazartesi,Sali,Çarsamba,Persembe,Cuma,Cumartesi,Pazar
    }

    //enumu farklı tur ıle kullanma
    enum aylar:byte
    { // sıralı gıtmesı ıcın sadece ocak ayına 1 yazman yeterlı 
        // enum aylar :byte yazarsan artık byte turunden alır ama bırsey yazmazsan ınt turunden alır 
        ocak=1,
        subat=2,
        mart=3
    }

    enum seviye
    {
        dusuk,
        orta,
        yuksek
    }

    enum islemler
    {
        ekle=1,
        sil,
        guncelle,
        listele,
        cikis

    }

    enum aylar2
    {
        ocak=1,
        subat,
        mart,
         nisan,
         mayis,
         haziran,
         temmuz,
         agostos,
         eylul,
         ekim,
         kasim,
         aralik
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //enum degerıne erısım
            gunler gunler = gunler.Pazartesi;
            string strgunler = gunler.ToString();// stringe cevırmek ıcın kullanılır 

            Console.WriteLine("bugun : " + gunler);
            Console.WriteLine("tamsayi  : " + (int)gunler);
            //enum degerıne atama
            gunler yarin = (gunler)1;
            Console.WriteLine(yarin);
            Console.ReadKey();

            /////////////////////////

            seviye s1 = seviye.orta;
            switch (s1)
            {
                case seviye.dusuk:
                    Console.WriteLine("seviye : dusuk ");
                    break;
                case seviye.orta:
                    Console.WriteLine("seviye : orta ");
                    break;
                case seviye.yuksek:
                    Console.WriteLine("seviye : yuksek ");
                    break;
                default:
                    break;
            }

            // enumlar ıcınde tek tek gezınme ıslemı  yanı tum enum degegerlerını lısteleme 
            foreach (gunler gun in Enum.GetValues(typeof(gunler)))
            {
                Console.WriteLine($"{(int)gun} : {gun}");
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{(int)i} : {(gunler)i}");
            }
            Console.ReadKey();



            foreach (islemler islem in Enum.GetValues(typeof(islemler)))
            {
                Console.WriteLine($"{(int)islem} : {islem}");
            }
            Console.WriteLine("yapmak ıstedıgınız ıslemı secınız:");
            int deger = int.Parse(Console.ReadLine());
            islemler yeniislem = (islemler)deger;


            switch (yeniislem)
            {
                case islemler.ekle:
                    Console.WriteLine(" istediginiz seyi ekleyınız:");
                    break;

                case islemler.sil:
                    Console.WriteLine(" silinecek seyı lutfen siliniz: ");
                    break;

                case islemler.guncelle:
                    Console.WriteLine(" istedıgınız seyı guncelleyınız: ");
                    break;

                case islemler.listele:
                    Console.WriteLine(" lutfen lısteleyınnız: ");
                    break;

                case islemler.cikis:
                    Console.WriteLine(" cıkıs: ");
                    break;
                default:
                    break;
            }
            foreach (aylar2 ay in Enum.GetValues(typeof(aylar2)))
            {
                Console.WriteLine($"{(int)ay} : {ay}");
            }
            Console.Write("sayi girin: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            aylar2 aylar =  (aylar2)sayi;
            switch(aylar) 
            {
                case aylar2.aralik:
                case aylar2.ocak:
                case aylar2.subat:
                    Console.WriteLine($"kiş  {aylar}");
                    break;

                case aylar2.mart:
                case aylar2.nisan:
                case aylar2.mayis:
                    Console.WriteLine($"ilkbahar  {aylar}");
                    break;

                case aylar2.haziran:
                case aylar2.temmuz:
                case aylar2.agostos:
                    Console.WriteLine($"yaz  {aylar}");
                    break;

                case aylar2.eylul:
                case aylar2.ekim:
                case aylar2.kasim:
                    Console.WriteLine($"sonbahar  {aylar}");
                    break;
            }
             
          
            



        }
    }
}

// sparis adında class class adı sparıs bunun da idd ınt , urunadı string sıparıs durumu yanı 3 property enum ıcınde ıse hazırlanıyor ,kargoya verıldı,teslım edıldı,ıptal edıldı sekşomde , bıde lıste yap sıparıs ekle ,sıarıs goruntule,sıparısdurumu guncelle ,cıkıs bu da enum plabıkır
