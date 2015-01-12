using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolBackdoor.Data.ServerData;

namespace LolBackdoor.APIs.LolStatusApis
{
    public interface ILolStatusApi : ILolApi
    {
        List<LolShard> GetAllShards();
        LolShard GetThisServersShard();
    }
}
