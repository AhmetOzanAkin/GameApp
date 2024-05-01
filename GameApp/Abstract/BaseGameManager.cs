using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public abstract class BaseGameManager : IGameService
    {

        public virtual void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public virtual void Sell(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine("Oyun Satıldı. Oyunu Alan kişi : " + player.FirstName + "Kampanya Oranı : " + campaign.DiscountRate);
        }
    }
}
