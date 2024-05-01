using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class PlayerManager : BaseUserManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            this._playerCheckService = playerCheckService;
        }


        public override void Add(Player player)
        {
            if(_playerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
        public override void Update(Player player)
        {
            base.Update(player);
        }
        public override void Delete(Player player)
        {
            base.Delete(player);
        }

    }
}
