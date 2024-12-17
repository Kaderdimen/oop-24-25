using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_11
{
    public class hafta11
    {

        int ornek = 0;
        public hafta11(int _ornek) // kurucu - yapıcı -consturctor
        {
            ornek = _ornek;
            Console.WriteLine(ornek + " kurucu metot calıstı");

        }
        // yıkıcı metodlar default olarak PROTECTED erısım belırtecıne sahıp 
         ~hafta11() //yıkıcı-destruct
        {
            // actıgın dosya varsa kapatabılırsın ,erısımını kesebılırsın,verı tababnında baglantın acıksa kapatabılırsın
            Console.WriteLine(ornek + " yıkıcı metot calıstı");
        }
    }
}
