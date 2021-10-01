using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ınterfacelerde implement eden  class ın referans nosunu taşır
            //1-2-3 aynı iş yapar


            PersonalCreditManager personalCreditManager = new PersonalCreditManager();
            //personalCreditManager.Calculate();

            ICreditManager personalCreditManager1 = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();
            ICreditManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();

            ApplicationManager applicationManager = new ApplicationManager();
            /*
            applicationManager.BasvuruYap(personalCreditManager1);
            applicationManager.BasvuruYap(vehicleCreditManager);
            */

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            //yukarıdaki new leme alternatifi olarak alttaki new(33) leme yapılabilir.
            //ApplicationManager applicationManager = new ApplicationManager();  bu satır yukarda var görmek icin aldım
            //applicationManager.BasvuruYap(mortgageManager,new DatabaseLoggerService() );

            applicationManager.BasvuruYap(personalCreditManager1, new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService(),new FileLoggerService()});
            // yukarının alternatifi liste yapıp öyle verilebilir
/*
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(),new DatabaseLoggerService(),new FileLoggerService()};
            applicationManager.BasvuruYap(personalCreditManager1,loggers);
*/
            ICreditManager esnafKredisiManager = new EsnafKredisiManager();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //applicationManager.BasvuruYap(esnafKredisiManager, smsLoggerService);



            List<ICreditManager> krediler = new List<ICreditManager>() 
            //Listeye eklemeler yapıyoruz
            {
                personalCreditManager,vehicleCreditManager
            };

            //applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
