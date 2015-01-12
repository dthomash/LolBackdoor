using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolBackdoor
{
    

    public class LolBackdoor
    {
        public LolServer GetServer(LolRegion region)
        {
            return LolServer.GetServer(region);
        }
    }
}
