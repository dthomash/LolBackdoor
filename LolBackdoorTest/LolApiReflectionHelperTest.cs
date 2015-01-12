using LolBackdoor.APIs;
using LolBackdoor.APIs.ChampionApis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LolBackdoorTest
{
    [TestClass]
    public class LolApiReflectionHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILolChampionApi championApi = LolApiReflectionHelper.GetLolChampionApi("1.2");
            Assert.IsNotNull(championApi);
        }
    }
}
