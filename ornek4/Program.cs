using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanici_adi;
            string sifre;
            Console.Write("kullanici adini gir : ");
            kullanici_adi = Console.ReadLine(); // string kullanınca parseye gerek yok
            Console.Write("sifreyi gir : ");
            sifre = Console.ReadLine();
            int i = 0;
            while(i<3)
            {
                Console.Write("adiniz: ");
                string adiniz = Console.ReadLine();

                Console.Write("sifreniz: ");
                string sifrem = Console.ReadLine();

                Console.WriteLine();
                i++;

            }

            if (i==3)
            {
                Console.Write(" hakkiniz bitmistir. ");
            }

            
        }
        
    }
    
}
