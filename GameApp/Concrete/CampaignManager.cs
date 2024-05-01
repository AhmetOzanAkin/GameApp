using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class CampaignManager : BaseCampaignManager
    {
        private IPlayerCheckService _playerCheckService;
        public CampaignManager(IPlayerCheckService playerCheckService)
        {
            this._playerCheckService = playerCheckService;
        }

      
        public override void Add(Campaign campaign, Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player) )
            { 
                base.Add(campaign,player);
            }
            else
            {
                throw new Exception("Not a valid campaign");
            }
           
        }
        public override void Delete(Campaign campaign)
        {
            base.Delete(campaign);
        }
        public override void Update(Campaign campaign)
        {
            base.Update(campaign);
        }
    }
}
