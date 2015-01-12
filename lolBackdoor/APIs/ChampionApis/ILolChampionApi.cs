using System.Collections.Generic;
using LolBackdoor.Data.StaticData;

namespace LolBackdoor.APIs.ChampionApis
{
    public interface ILolChampionApi : ILolApi
    {
        List<LolChampion> GetAllChampions();
        LolChampion GetChampion(int id);
    }
}
