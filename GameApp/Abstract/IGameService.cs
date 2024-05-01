using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Sell(Game game, Player player, Campaign campaign);

    }
}
