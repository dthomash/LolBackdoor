using System;
using LolBackdoor.APIs.ChampionApis;
using LolBackdoor.APIs.GameApis;
using LolBackdoor.APIs.LeagueApis;
using LolBackdoor.APIs.LolStaticDataApis;
using LolBackdoor.APIs.LolStatusApis;
using LolBackdoor.APIs.MatchApis;
using LolBackdoor.APIs.MatchHistoryApis;
using LolBackdoor.APIs.StatsApis;
using LolBackdoor.APIs.SummonerApis;
using LolBackdoor.APIs.TeamApis;

namespace LolBackdoor.APIs
{
    public class LolApiReflectionHelper
    {
        private const string ChampionApiBaseClassName = "LolBackdoor.APIs.LolChampion.LolChampion";
        private const string GameApiBaseClassName = "LolBackdoor.APIs.Game.Game";
        private const string LeagueApiBaseClassName = "LolBackdoor.APIs.League.League";
        private const string LolStaticDataApiBaseClassName = "LolBackdoor.APIs.LolStaticData.LolStaticData";
        private const string LolStatusApiBaseClassName = "LolBackdoor.APIs.LolStatus.LolStatus";
        private const string MatchApiBaseClassName = "LolBackdoor.APIs.Match.Match";
        private const string MatchHistoryApiBaseClassName = "LolBackdoor.APIs.MatchHistory.MatchHistory";
        private const string StatsApiBaseClassName = "LolBackdoor.APIs.Stats.Stats";
        private const string SummonerApiBaseClassName = "LolBackdoor.APIs.Summoner.Summoner";
        private const string TeamApiBaseClassName = "LolBackdoor.APIs.Team.Team";


        public static ILolChampionApi GetLolChampionApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolChampionApi) GetLolApi(ChampionApiBaseClassName + sanitizedVer);
        }

        public static ILolGameApi GetGameApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolGameApi)GetLolApi(GameApiBaseClassName + sanitizedVer);
        }

        public static ILolLeagueApi GetLeagueApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolLeagueApi)GetLolApi(LeagueApiBaseClassName + sanitizedVer);
        }

        public static ILolStaticDataApi GetStaticDataApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolStaticDataApi)GetLolApi(LolStaticDataApiBaseClassName + sanitizedVer);
        }

        public static ILolStatusApi GetStatusApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolStatusApi)GetLolApi(LolStatusApiBaseClassName + sanitizedVer);
        }

        public static ILolMatchApi GetMatchApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolMatchApi)GetLolApi(MatchApiBaseClassName + sanitizedVer);
        }

        public static ILolMatchHistoryApi GetMatchHistoryApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolMatchHistoryApi)GetLolApi(MatchHistoryApiBaseClassName + sanitizedVer);
        }

        public static ILolStatsApi GetStatsApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolStatsApi)GetLolApi(StatsApiBaseClassName + sanitizedVer);
        }

        public static ILolSummonerApi GetSummonerApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolSummonerApi)GetLolApi(SummonerApiBaseClassName + sanitizedVer);
        }

        public static ILolTeamApi GetTeamApi(string version)
        {
            var sanitizedVer = SanitizeVersionNumber(version);
            return (ILolTeamApi)GetLolApi(TeamApiBaseClassName + sanitizedVer);
        }

        private static string SanitizeVersionNumber(string versionNumber)
        {
            return versionNumber.Replace(".", "_");
        }

        private static ILolApi GetLolApi(string apiFullyQualifiedClassName)
        {
            Type apiType = Type.GetType(apiFullyQualifiedClassName);
            return apiType.GetConstructors()[0].Invoke(new object[] { }) as ILolApi;
        }
    }
}
