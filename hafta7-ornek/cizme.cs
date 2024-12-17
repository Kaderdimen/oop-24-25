using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta7_ornek
{
    internal class cizme
    {
        public int Yukseklik { get; set; }
        public cizme(int yukseklik) 
        {
            Yukseklik=yukseklik;
        }

        public void ciz()
        {
            int yukseklik=int.Parse(Console.ReadLine());
            for (int i = 1; i <= yukseklik; i++)
            {
                
                for (int j = 1; j<=i; j++)
                {
                    if (j == 1 || j == i || i == yukseklik)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Üçgenin yüksekliğini girin: ");
//        int yukseklik = int.Parse(Console.ReadLine());

//        Ucgen ucgen = new Ucgen(yukseklik);
//        ucgen.Ciz();
//    }
//}

//class Ucgen
//{
//    private int yukseklik;

//    public Ucgen(int y)
//    {
//        yukseklik = y; // this kullanılmadan yükseklik atanıyor.
//    }

//    public void Ciz()
//    {
//        for (int i = 1; i <= yukseklik; i++)
//        {
//            // Boşlukları yazdır
//            for (int j = 1; j <= yukseklik - i; j++)
//            {
//                Console.Write(" ");
//            }
//            // Yıldızları yazdır
//            for (int k = 1; k <= (2 * i - 1); k++)
//            {
//                if (k == 1 || k == (2 * i - 1) || i == yukseklik)
//                {
//                    Console.Write("*");
//                }
//                else
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}


