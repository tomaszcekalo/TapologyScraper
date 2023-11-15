using AngleSharp;
using System;
using System.Threading.Tasks;

namespace TapologyScraper
{
    public interface ITapologyComScraper
    {
    }

    public class TapologyComScraper : ITapologyComScraper
    {
        private IConfiguration _config;
        private IBrowsingContext _context;

        public TapologyComScraper(IConfiguration configuration)
        {
            _config = configuration;
            _context = BrowsingContext.New(_config);
        }

        public TapologyComScraper()
            : this(Configuration.Default.WithDefaultLoader())
        {
        }

        public async Task<MainPage> ScrapeMainPage(string url = Consts.MainPageUrl)
        {
            var document = await _context.OpenAsync(url);
            return new MainPage();
        }

        public async Task<Promotions> ScrapePromotions(string url = Consts.PromotionsUrl)
        {
            var document = await _context.OpenAsync(url);
            return new Promotions();
        }

        public async Task<PredictionsLeaderboard> ScrapePredictionsLeaderboard(string url = "")//example: https://www.tapology.com/fightcenter/events/101867-ufc-fight-night/predictions-leaderboard
        {
            var document = await _context.OpenAsync(url);
            return new PredictionsLeaderboard();
        }

        public async Task<FightCenter> ScrapeFightCenter(string url = Consts.FightCenterUrl)
        {
            var document = await _context.OpenAsync(url);
            return new FightCenter();
        }
    }
}