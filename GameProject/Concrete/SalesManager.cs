using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + ", " + game.Name + " oyununu" + campaign.CampaignName + "  kampanyası ile" + campaign.CampaignRate + " indirimle alınmıştır.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusu için" + game.Name + " oyunu satın alınmıştır.");
        }

        internal void CampaignSales(Gamer gamer1, Game game1, Campaign campaign2)
        {
            throw new NotImplementedException();
        }
    }
}
