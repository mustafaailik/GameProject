using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "öznur";
            gamer1.LastName = "krsy";
            gamer1.NationalityId = "12345";
            gamer1.DateOfBirth = 1998;

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "GTA";
            game1.Price = 50;

            Game game2 = new Game { Id = 2, Name = "Outlast", Price = 100 };

            Campaign campaign1 = new Campaign();
            campaign1.Id = 10;
            campaign1.CampaignName = "Şubat Kampanyası";
            campaign1.CampaignRate = 30;

            Campaign campaign2 = new Campaign { Id = 11, CampaignName = "Yeni yıl kampanyası", CampaignRate = 50 };


            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer1);
            

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Delete(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);
            gameManager.Update(game2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(gamer1, game1, campaign2);
        }
    }
}
