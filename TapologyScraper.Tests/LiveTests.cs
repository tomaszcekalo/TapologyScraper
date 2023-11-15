namespace TapologyScraper.Tests
{
    [TestClass]
    public class LiveTests
    {
        private TapologyComScraper _testedSystem = new TapologyComScraper();

        [TestMethod]
        public async Task TesScrapeMainPage()
        {
            var result = await _testedSystem.ScrapeMainPage();
        }

        [TestMethod]
        public async Task TestScrapePromotions()
        {
            var result = await _testedSystem.ScrapePromotions();
        }

        [TestMethod]
        public async Task TestScrapePredictionsleaderboard()
        {
            var result = await _testedSystem.ScrapePredictionsLeaderboard();
        }

        [TestMethod]
        public async Task TestScrapeFightCenter()
        {
            var result = await _testedSystem.ScrapeFightCenter();
        }
    }
}