using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // diziler,iki boyutlu diziler,listeler,metodlar,params,lambda ogrenecegiz

            int[] dizi = { 1, 2, 3, 4, }; // suslu parantez kullanınca deger gırmeye gerek yok
            int[] dizi2 = new int[4];
            int[,] matris = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };   // kac vırgul varsa o kadar boutlu
            int[,,] cokboyutlu = { { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } } };

            //for (int i = 0; i < matris.GetLength(0); i++)  // 0 satır sayısını 1 stun sayısını verir getlenght
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matris[i, j] + "\t"); ;
            //    }
            //}




            //for (byte i = 0; i < dizi.Length; i++) // lenght boyut dizinim boyutunu alabiliriz
            //{
            //    dizi2[i] = Convert.ToByte(Console.ReadKey());
            //}

            //foreach (var i in dizi2) //
            //{
            //    // ctrl + d aynı satırı asagı ekler 

            //    Console.WriteLine(dizi2);

            //}


            List<string> isimler = new List<string>();
            isimler.Add("baris");
            isimler.Add("yaser");
            isimler.Add("diyar");
            isimler.Add("coskun");
            isimler.Remove("coskun"); // remove coskundan kac tane varsa hepsını sıler
            isimler.RemoveAt(0);
            isimler.Insert(0, "huseyin");
            Console.WriteLine(isimler.Contains("huseyin"));
            isimler.ForEach(x => Console.WriteLine(x));
            isimler.Sort();
            isimler.ForEach(x => Console.WriteLine(x));

            // isimler.BinarySearch();
            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }

            ekranayaz("baris");
            int toplam = toplama(3, 5);
            int toplam2 = toplama(3, 5, 7, 8, 9, 10);
            int[] dizi1 = { 1, 2, 3, 4 };
            int[] dizi3 = KareAl(dizi);
            foreach (int item in dizi2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(toplam);
            Console.WriteLine(toplam2);
            Console.WriteLine(topla(15, 35));
            Console.WriteLine(karehesabi(15));
            uyari("baris");
            Console.ReadKey();
        }

        // lamda fonksıyonlar
        static Func<int, int, int> topla = (sayi1, sayi2) => (sayi1 + sayi2);
        static Func<int, int> karehesabi = sayi1 => (sayi1 * sayi1);
        static Action<string> uyari = isim => Console.WriteLine(isim + "uyari");





        //parametre olarak dizi alıp deger donduren 
        static int[] KareAl(int[] dizi)
        {
            int[] dizi5 = new int[dizi.Length];
            for (int i = 0; i < dizi5.Length; i++)
            {
                dizi5[i] = dizi[i] * dizi[i];

            }
            return dizi5;
        }


        /// ////////////////////////////metodlar //////////////////////////////////////7


        //parametre almayan-geri deger dondurmeyen
        static void ekranayaz() // metod yazraken basına statcic ekle 
        {
            Console.WriteLine("merhaba");
        }

        //parametre alan-deger dondurmeyen
        static void ekranayaz(string isim)
        {
            Console.WriteLine("merhaba" + isim);
        }

        // parametreler alan-deger donduren
        static int toplama(params int[] degerler)
        {
            int toplam = 0;
            foreach (int item in degerler)
            {
                toplam += item;
            }
            return toplam;
        }

    }
}
