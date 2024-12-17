using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hafta_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  yıkıcı metot
            //// new anahtar turuyle olusturdugumuZ hersey heap bolgesınde tutulur
            //hafta11 d1 = new hafta11(1);
            //new hafta11(2);
            //Console.WriteLine("bellek = " + GC.GetTotalMemory(false));
            //// gettotalmemory : bellektekı toplam alanı getırır 
            //// getgeneration :nesneının hangı nesılde (generation) oldugunu getırır
            //Console.WriteLine("d1 = GEN " + GC.GetGeneration(d1));
            //GC.Collect(); // garbage colleectoru manuel cagırmaya yarar 

            //Console.WriteLine("d1 = GEN " + GC.GetGeneration(d1));
            //Console.WriteLine("bellek = " + GC.GetTotalMemory(false));

            //Console.ReadKey();
            #endregion 

            // try : kodu dene , catch: varsa hata burda yakala , finally : catch ten cıktıktan sonra ıslem yap
            try
            {
                //int a = 5;
                //int b = 0;
                //int c = (a / b);
                int[] dizi = new int[5];
                dizi[5] = 1;
                int a, b;
                Console.Write("A = ");
                a=int.Parse(Console.ReadLine());

                Console.Write("B = ");
                b = int.Parse(Console.ReadLine());
                int c = a / b;

            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            finally
            {
                Console.WriteLine(" fınally calıstı ");
            }

            Console.ReadKey();
            
            

        }
    }
}
