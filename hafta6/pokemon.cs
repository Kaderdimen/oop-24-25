using System;
using System.Security.Cryptography.X509Certificates;
namespace hafta6
{
    public class pokemon
    {
        public string Isim {  get; set; } // get deger ata set degerı cek bu ıkısı de metod iclerını acıp kod yazıcaz get set acılmadıgı surece degısken 
        public string Tur {  get; set; } // tur saldırı turlerını verecek oyunun
        // kısayol :propertıf tanımlayacagın zaman prop yaz tab kısmına bas  PROFFUL YAZARSAN propa yazarsan
        public string Saldirituru {  get; set; }
        public int Sadirigucu {  get; set; }
        public int Savunmagucu {  get; set; }
         public int Saglik {  get; set; }
        public int Enerjipuani {  get; set; }

        // parametresiz kurucu metod ctor +tab
        public pokemon()
        {
            
        }

        // public erisim belırtecıdır donus tıpı yoktur 

        // parametreli kurucu metod 
        public pokemon(string isim,string tur,string saldirituru,int saldirigucu,int savunmagucu,int saglik,int enerjipuani)
        {
            Isim = isim;
            Tur = tur;
            Saldirituru = saldirituru;
            Sadirigucu = saldirigucu;
            Savunmagucu = savunmagucu;
            Saglik = saglik;
            Enerjipuani = enerjipuani;

        }

        public void Saldir(pokemon rakip)
        {
            if(Enerjipuani>=10)
            {
                int hasar = Sadirigucu - rakip.Savunmagucu;
                if(Saldirituru== "yildirim oku" && rakip.Tur=="su")
                {
                    hasar *= 2;
                }
                hasar =(hasar<=0) ? 0 : hasar;
                Enerjipuani -= 10;
               
                Console.WriteLine($"{Isim},{rakip.Isim} pokemonuna {hasar} hasar  verdi");
                rakip.Hasaral(hasar);
               
            }
            else
            {
                Console.WriteLine($"{Isim},yeterli enerjiye sahip degil . Enerji puanı :{Enerjipuani}");
            }

           
        }

        public void Hasaral(int hasar)
        {
            Saglik -= hasar;
            if(Saglik<=0)
            {
                Saglik = 0;
                Console.WriteLine($"{Isim},maglup oldu !");
            }
            else
            {
                Console.WriteLine($"{Isim}'kalan sagligi: {Saglik}");
            }

        }

        public void Yenilen ()
        {
            Enerjipuani += 10;
            Console.WriteLine($"{Isim} yenilendi... enerji puani: {Enerjipuani}");
        }
        



    }
}
