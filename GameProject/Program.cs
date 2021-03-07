using GameProject.Entities;
using GameProject.Adapters;
using GameProject.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu oluşturma
            Gamer gamer1 = new Gamer();
            gamer1.Id = 10;
            gamer1.FirstName = "Utku";
            gamer1.LastName = "Gök";
            gamer1.NationalityId = 23123213127;
            gamer1.BirthYear = 1996;

            Gamer gamer2 = new Gamer();
            gamer2.Id = 20;
            gamer2.FirstName = "Ataberk";
            gamer2.LastName = "Kurumoğlu";
            gamer2.NationalityId = 42341131233;
            gamer2.BirthYear = 1998;

            //Oyuncu ekleme
            GamerManger gamerManger1 = new GamerManger(new MernisServiceAdapter());
            GamerManger gamerManger2 = new GamerManger(new MernisServiceAdapter());
            gamerManger1.Add(gamer1);
            gamerManger2.Delete(gamer2);
            gamerManger1.Update(gamer1);

            //Oyun oluşturma
            Game game1 = new Game();
            game1.GameId = 23;
            game1.GameName = "Valorant";
            game1.GamePrice = 199;

            Game game2 = new Game();
            game2.GameId = 41;
            game2.GameName = "Age of Mythology";
            game2.GamePrice = 99;

            //Oyun ekleme
            GameManager gameManager1 = new GameManager();
            GameManager gameManager2 = new GameManager();
            gameManager1.Add(game1);
            gameManager2.Delete(game2);
            gameManager1.Update(game1);

            //Kampanya oluşturma
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "%10 indirimli ürünler";
            campaign1.DiscountRate = 10;

            //Kampanya ekleme
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            campaignManager1.Delete(campaign1);
            campaignManager1.Update(campaign1);


            
        }
    }
}
