using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class GameManager : BaseGameManager
    {
        IPlayerCheckService _playerCheckService;
        public GameManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Game game)
        {
            base.Add(game);
        }
        public override void Sell(Game game, Player player, Campaign campaign)
        {
            if(_playerCheckService.CheckIfRealPlayer(player))
            {
                base.Sell(game, player, campaign);
            }else
            {
                throw new Exception("Not a valid Sell ");
            }
        }
    }
}
