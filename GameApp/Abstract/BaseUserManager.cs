using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public abstract class BaseUserManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Oyuncu Eklendi : " + player.FirstName);
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi : " + player.FirstName);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + player.FirstName );
        }
    }
}
