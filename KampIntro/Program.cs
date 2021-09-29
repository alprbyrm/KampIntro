using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            //kategoriEtiketi = deger tutucu , alias 


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar Azaliyor butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Artiyor butonu");
            }

            else 
            {
                Console.WriteLine("Dolar esit butonu");
            }


            if (sistemeGirisYapmisMi == true)

            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
