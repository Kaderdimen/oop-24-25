using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba
{
    public class araba  // classlar nesensı turetılınce bır anlam kazanır 
    {
        public string marka;
        public string model;
        public short uretimyili;
        public void bilgilerigoster()
        {
            Console.WriteLine($"model :{model}\nmarka : {marka} \nuretim yili: {uretimyili} ");
        }
    }


    public class Program // erisim belırteclerı public her yerde erisirsin,private kendisine ozgu tanımlı oldugu yerde ,protected koruma 
    {
        static void Main(string[] args)
        {
            araba a1 = new araba(); // new bır clastan dıger clas ıcın belllekte bır yer ayırıyo bastakı araba yerıne object de yazılabılır
            a1.marka = "toyota";
            a1.model = "corolla";
            a1.uretimyili = 2023;
            a1.bilgilerigoster();

            Console.ReadKey();
        }
    }
}
    // mor kupler metod oluyor  mavi didortgenler fiilt oluyor degısken donusumu 