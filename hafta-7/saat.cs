using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_7
{
    
    public class saat
    {
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        public saat()
        {
            
        }
        public saat(int saat, int dakika, int saniye)
        {
            Saat = saat;
            Dakika = dakika;
            Saniye = saniye;

        }
        
        public void zamanigoster()
        {
            Console.WriteLine($"{Saat}:{Dakika}:{Saniye} ");
        }
        

    }
}
