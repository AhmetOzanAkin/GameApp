using GameApp.Abstract;
using GameApp.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityIdenty), player.FirstName.ToUpper(), player.LastName.ToUpper(),
               player.DateOfBirth);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
