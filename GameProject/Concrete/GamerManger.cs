using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManger : IGamerService
    {
        //constructor bloğu burası
        IUserValidationService _userValidationService;

        public GamerManger(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        //constuctor bloğu bitişi

        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Oyuncu kayıt edildi." + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Oyuncu başarılı bir şekilde silindi." + '\n');
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Oyuncu güncellendi." + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız! Güncelleme yapamazsınız.");
            }
            
        }
    }
}
