using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //gamermanageri new ledigimizde bir UservalidationServis istedigini yaziyor 
            //dogrulama sinifinin hangi sinif oldugunu=new UserValidationManager diyerek belirtiyoruz

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1,
                BirthYear = 1993, 
                FirstName = "Alper", 
                LastName = "Bayram",
                IdentityNumber=12345
                
            });
        }
    }
}
