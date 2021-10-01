using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        //Başvuru yönetimi

        //method injection
        //Yapılan başvuruyu loglamak istedik ınterface i ekledik
        //public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)

        //loglama işlemi 1 den fazla ise listede tutulur 
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        { 
            //Basvuran bilgileri degerlendirme

            //Bu kod çalısır ama yapılan
            //tüm başvuruları konut kredisi üzerinde hesaplar 
            //Bu kullanım yanlıştır
           /*
            MortgageManager mortgageManager = new MortgageManager();
            mortgageManager.Calculate();
           */


            //Referans tipi olarak Interface ekleriz
            //o referansın (creditManager) hesaplasını çalıştırırız
            creditManager.Calculate();
            //loggerService.Log();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
          
        }

        //Aynı veri türünde belli sayıda (o sayı belirsiz) bir veri grubu oluşturmamız lazım
        //ARRAY LİST KULLANILIR 
        //Veri türü olarak da ICreditManager seçilir
        public void KrediOnBilgilendirmesiYap(List<ICreditManager>krediler)
        {
            //foreach sayesinde listedeki tüm kredilerin Calculate fonksiyonu çalışır
            //Yukarıdaki hesaplada ise 1 tanesini hesaplar
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
