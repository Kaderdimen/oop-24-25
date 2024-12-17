using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_13
{
    public class Program

    {
        enum menu
        {
            ekle = 1,
            sil,
            listele,
            ortalamanot,
            cikis

        }
        static List<(string, int)> ogrenciler = new List<(string, int)>();
        static void Main(string[] args)

        {

            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(101, "berivan gultepe");
            ogrenciler.Add(102, "ayse gul");
            ogrenciler.Add(103, "fatma ucar");

            Console.WriteLine($"101 nolu ogrenci :{ogrenciler[101]}");
            foreach(var ogrenci in ogrenciler)
            {
                Console.WriteLine($"numara:{ogrenci.Key} adi: {ogrenci.Value}");
            }

            if(ogrenciler.ContainsKey(104))
            {
                Console.WriteLine($"102 nolu ogrenci : {ogrenciler[102]}");
            }
            else
            {
                Console.WriteLine("ogrenci bulunamadı ");
            }


            while (true)
            {
                foreach (var item in Enum.GetValues(typeof(menu)))
                {
                    Console.WriteLine($"{(int)item}:\t{item}");
                }
                Console.WriteLine();
                int secim = int.Parse(Console.ReadLine());
                menu secenek = (menu)secim;
                switch (secenek)
                {
                    case menu.ekle:
                        ekle();
                        break;
                    case menu.ortalamanot:
                        ortalamanot();
                        break;
                    case menu.sil:
                        sil();
                        break;
                    case menu.listele:
                        break;
                        listele();
                    case menu.cikis:
                        Console.WriteLine();
                        return;
                    

                }
            }
            // generıc dınamık bır dızı. 
            // aray lıstte tur belırtmıyorsun ıcıne ne atarsan onu alır performans olarak dusuk 

            //ArrayList arrList = new ArrayList();
            //arrList.Add("kader");
            //arrList.Add(3.14);
            //arrList.Add(true);
            //arrList.Add(10);
            //arrList.Insert(2,"deneme");
            //arrList.Remove("deneme");
            //arrList.RemoveAt(2);
            //arrList.InsertRange(2,arrList);
            //arrList.Reverse();

            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}

            ////List<(string,float)> personel = new List<(string,float)>();
            ////personel.Add(("kader ", 0000));
            ////personel.Add(("ali ", 1900));
            ////personel.Add(("fatih ", 1700));
            ////foreach (var per in personel)
            ////{
            ////    Console.WriteLine($"Adi: {per.Item1}\n Maasi: {per.Item2}");
            ////}

           
        }

        private static void ekle()
        {
            Console.WriteLine("adinizi giriniz: ");
            string ad= Console.ReadLine();
            Console.WriteLine("notunuzu giriniz: ");
            int not =int.Parse(Console.ReadLine());
            ogrenciler.Add((ad,not));
            Console.WriteLine("ogrenci eklendi ");

        }

        private static void sil()
        {
            Console.WriteLine("silinecek ogrencin adını gırtınız: ");
            string ad= Console.ReadLine();  
            ogrenciler.RemoveAll(o =>o.Item1 == ad);
            Console.WriteLine("ogrenci silindi");
        }

        private static void listele()
        {
            Console.WriteLine("tum ogrenciler");
            foreach(var item in ogrenciler)
            {
                Console.WriteLine($"{item.Item1}\t {item.Item2}");

            }
        }

        private static void ortalamanot()
        {
            double ortalamanot = (ogrenciler.Count > 0) ? ogrenciler.Average(o => o.Item2) : 0;
            Console.WriteLine($"not ortalaması: {ortalamanot}");

        }

    }
}
