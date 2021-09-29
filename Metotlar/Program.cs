using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clean Code - Best Practıce
            //Metotlar tekrar tekrar kullanılabılırlıgı saglayan kod blokları

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[]
            { 
            };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 15;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] 
            { 
                product1,product2
            };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------Metodlar--------");

            //instance-- örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 20,10);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 158,99);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 230,485);





             

        }
    }
}
