using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class MortgageManager : ICreditManager
    {
        //konut kredisi
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
