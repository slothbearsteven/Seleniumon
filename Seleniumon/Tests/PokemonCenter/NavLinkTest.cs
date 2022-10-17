using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seleniumon.Pages.PokemonCenter;

namespace Seleniumon.Tests.PokemonCenter
{
    internal class NavLinkTest
    { private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }


        [Test]


        //due to security reasons, Selenium tests cannot be used except for once per day on pokecenter site :(
        public void NavLinks()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Assert each nav buttons href leads to proper page 
            Assert.AreEqual(homePage.pokeCenterBaseURL+"/category/new-releases", homePage.newReleasesButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL + "/category/plush", homePage.plushButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL + "/category/figures-and-pins", homePage.figuresPinsButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL+ "/category/trading-card-game", homePage.tcgButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL+ "/category/clothing", homePage.clothingButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL+ "/category/home-and-office", homePage.homeItemsButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL + "/category/video-game", homePage.videoGameButton.GetAttribute("href"));
            Assert.AreEqual(homePage.pokeCenterBaseURL + "/category/halloween", homePage.halloweenButton.GetAttribute("href"));
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}
