using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {

        public virtual void Add(Campaign campaign, Player player)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaign.Name + "Kampanya sadece size özel : " + player.FirstName);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
