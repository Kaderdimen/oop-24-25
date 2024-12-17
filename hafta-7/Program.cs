using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hafta_7
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            saat s1 = new saat();
            s1.zamanigoster();

            saat s2 = new saat(12,23,23);
            s2.zamanigoster();

            
         
        }
    }
}
