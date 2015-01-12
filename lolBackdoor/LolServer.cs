using LolBackdoor.APIs.ChampionApis;
using LolBackdoor.APIs.GameApis;
using System.Collections.Generic;
using LolBackdoor.APIs.LeagueApis;
using LolBackdoor.APIs.LolStaticDataApis;
using LolBackdoor.APIs.LolStatusApis;
using LolBackdoor.APIs.MatchApis;
using LolBackdoor.APIs.MatchHistoryApis;
using LolBackdoor.APIs.StatsApis;
using LolBackdoor.APIs.SummonerApis;
using LolBackdoor.APIs.TeamApis;

namespace LolBackdoor
{
    public enum LolRegion
    {
        BR,
        EUW,
        EUNE,
        KR,
        LAN,
        LAS,
        NA,
        OCE,
        RU,
        TR
    }

    public class LolServer
    {
        private static Dictionary<LolRegion, LolServer> servers;

        /// <summary>
        ///     Yolo
        /// </summary>
        public ILolChampionApi Champion { get; private set; }
        public ILolGameApi Game { get; private set; }
        public ILolLeagueApi League { get; private set; }
        public ILolStaticDataApi LolStaticData { get; private set; }
        public ILolStatusApi Status { get; private set; }
        public ILolMatchApi Match { get; private set; }
        public ILolMatchHistoryApi MatchHistory { get; private set; }
        public ILolStatsApi Stats { get; private set; }
        public ILolSummonerApi Summoner { get; private set; }
        public ILolTeamApi Team { get; private set; }

        private LolServer() { }

        public static LolServer GetServer(LolRegion region)
        {
            LolServer server;
            if (servers.TryGetValue(region, out server) && server != null)
            {
                return server;
            }
            else
            {
                server = NewServer(region);
                servers.Add(region, server);
                return server;
            }
        }

        public static LolServer NewServer(LolRegion region)
        {
            var server = new LolServer();
            var apiVersions = ServerApiConfigHelper.getServerApiVersions(region);

            

            return server;
        }

        
    }
}
