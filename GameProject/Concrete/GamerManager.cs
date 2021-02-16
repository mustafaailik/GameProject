using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Kaydı tamamlandı.");
            }
            else
            {
                Console.WriteLine("kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "oyuncu silme başarılı ");
            }
            else
            {
                Console.WriteLine("oyuncu silme başarısız. ");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Oyuncu güncellendi. ");
            }
            else
            {
                Console.WriteLine("oyucu güncelleme başarısız.");
            }
        }
    }
}
