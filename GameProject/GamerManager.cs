using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{

    class GamerManager : IGamerService
    {
        //Bir manager sinifinin icerisinde baska bir manager sinifini kullanicak isen onu new leme
        //Asagidaki sekilde bir konstracter olustur

        IUserValidationService _userValidationService;

        //konstracterdan verdisigimiz uservalidation service (parantez icindeki yapi)
        //yukaridaki sekilde set oldu. 
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit oldu");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit oldu");
        }
    }
}
