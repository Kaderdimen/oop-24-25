using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta10
{
    public class denemee
    {
     // class static ıse ıcındekı her sey statık olmalo ve manin kısmında nesne olamamlaı cunku nesnesı olusturulamaz
     //statik property tanımlama 

        public static int ID {  get; set; }

      //statik metot tanımlama 
      public static void yazdir()
        {
            Console.WriteLine("deneme yazdır metodu ");
        }

        //statik kurucu metot tanımlama 
        private string Ad {  get; set; }
        private string Soyad {  get; set; }
        private static int Yas {  get; set; }

        static denemee()
        {
            Yas = 20;
        }

        public denemee(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public void yazdir2()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(Yas);
        }
    }

;
}