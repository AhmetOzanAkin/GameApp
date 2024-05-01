using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign, Player player);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
