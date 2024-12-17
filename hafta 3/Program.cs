using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parse sadece string ıcın kullan  
            //object obj = 5;
            //double b1 = 5;
            //double b2 = 10;
            //string s1 = b1.ToString();
            //string s2 = b2.ToString();

            //Console.WriteLine(s1 + "+" + s2 + "=" + (s1 + s2));

            string ad = "kader ";
            string soyad = "dimen";
            Console.Write(ad );
            Console.WriteLine(soyad);

            float boy ;
            float kilo ;

            //Console.WriteLine( "kilo" + "=" + kilo);
            //Console.WriteLine( "boy" + "=" + boy);
            Console.Write("Kiloyu gir : ");
            kilo = float.Parse(Console.ReadLine());
            Console.Write("Boyu gir : ");
            boy = float.Parse(Console.ReadLine());
            float vki = kilo / (float)Math.Pow(boy, 2);
            Console.WriteLine("vki =" + vki);

            if (vki <= 18.5)
            {
                Console.WriteLine(" zayiftir.");
            }
            else if (vki > 18.5 && vki <= 24.9)
            {
                Console.WriteLine(" normaldir.");
            }
            else if (vki >= 25 && vki <= 29.9)
            {
                Console.WriteLine(" fazla kilolu.");
            }
            else if (vki >= 30 && vki <= 34.9)
            {
                Console.WriteLine("Obez");
            }
            Console.ReadLine();
        }
    }
}
