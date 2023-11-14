using AngleSharp;
using System;

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

        public MainPage ScrapeMainPage(string url = Consts.MainPageUrl)
        {
            return new MainPage();
        }

        public Promotions ScrapePromotions(string url = Consts.PromotionsUrl)
        {
            return new Promotions();
        }

        public PredictionsLeaderboard ScrapePredictionsleaderboard(string url = "")//example: https://www.tapology.com/fightcenter/events/101867-ufc-fight-night/predictions-leaderboard
        {
            return new PredictionsLeaderboard();
        }

        public FightCenter ScrapeFightCenter(string url = Consts.FightCenterUrl)
        {
            return new FightCenter();
        }
    }
}