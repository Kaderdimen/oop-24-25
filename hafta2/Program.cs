using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tam sayi veri tipleri
            byte b = 255; //byte->0-255
            Console.WriteLine(b); //->cout<<endl;
            //console.write(b); // -> cout
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            short s = 0; //shorts-> 2 byte
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            int i = 0; // int-> 4 byte 
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long l = 0;
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            ////////////////////////////////////

            char c = 'a';
            Console.WriteLine(c);
            ///////////////////////////////////
            ///ondalıklı sayı verı tıplerı
            double d = 2.55;
            float f = 2.65f;
            decimal g = 2.65m; // decimal g=2.65M; seklınde de yazılır 

            /////////////////////////////////////////
            Console.WriteLine("Decimal: " + g);
            Console.WriteLine("Double: {0}, Float: {1}, Decimal: {2}", d, f, g);
            Console.WriteLine($"Double: {d}, Float: {f}, Decimal: {g}");
            //----------------------------------------------

            // int sayi= Convert.ToINT32(Console.ReadLine());
            // double sayi2=double.Parse(Console.ReadLine());
            double sayi3 = double.Parse(Console.ReadLine());
            int sayi4 = (int)sayi3;
            //int sayi= Console.Read(): //_> girilen rakamın ASCII karsılıgını alır 
            Console.ReadKey(); // -> konsol penceresını bır tusa basana ladar ekranda tutar 




            // ctrl+k+d duzenleme yapmak ıcın 
            // kontrol+f tusu degistirmek ıstedıgın kelımeyı her yerden degıstırme
            // ıkı yerı degıstırmek ıcın alt tusu + degistirecegın yer
            // cw tab Console.WritLine()

        }
    }
}
