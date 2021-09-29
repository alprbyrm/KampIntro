using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "alper";
            int yas = 28;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Alper Bayram";
            kurs1.IzlenmeOrani = 93;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursEgitmeni = "Engin Demirog";
            kurs2.IzlenmeOrani = 56;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursEgitmeni = "Kerem Kaya";
            kurs3.IzlenmeOrani = 87;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
           
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
