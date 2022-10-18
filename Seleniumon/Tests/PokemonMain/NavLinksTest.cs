using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seleniumon.Pages.PokemonMain;

namespace Seleniumon.Tests.PokemonMain
{
    internal class NavLinksTest
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }


        [Test]

        public void NavLinks()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            Assert.AreEqual(homePage.baseURL+"/pokedex/",homePage.pokedexLink.GetAttribute("href"));
            Assert.AreEqual(homePage.baseURL+"/pokemon-tcg/",homePage.tcgLink.GetAttribute("href"));
            Assert.AreEqual(homePage.baseURL+"/pokemon-video-games/",homePage.videoGameAppsLink.GetAttribute("href"));
            Assert.AreEqual(homePage.baseURL + "/pokemon-episodes/", homePage.tvLink.GetAttribute("href"));
            Assert.AreEqual(homePage.baseURL + "/play-pokemon/", homePage.playEventsLink.GetAttribute("href"));
            Assert.AreEqual(homePage.baseURL + "/pokemon-news/", homePage.newsLink.GetAttribute("href"));


        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
