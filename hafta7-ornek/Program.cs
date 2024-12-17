using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta7_ornek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin yüksekliğini girin: ");
            int yukseklik = int.Parse(Console.ReadLine());

            cizme ucgen = new cizme(yukseklik);
            ucgen.ciz();
            Console.ReadKey();
        }

    }
    
}
