using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumon.Pages.PokemonCenter
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver webdriver)
        {
            this.driver = webdriver;
        }

        public string pokeCenterBaseURL = " https://www.pokemoncenter.com/";
        //Begin Nav Bar items
        public IWebElement newReleasesButton => driver.FindElement(By.Id("new-releases"));

        public IWebElement plushButton => driver.FindElement(By.Id("plush"));
        public IWebElement figuresPinsButton => driver.FindElement(By.Id("figures-pins"));
        public IWebElement tcgButton => driver.FindElement(By.Id("trading-card-game"));
        public IWebElement clothingButton => driver.FindElement(By.Id("clothing"));
        public IWebElement homeItemsButton => driver.FindElement(By.Id("home-office"));
        public IWebElement videoGameButton => driver.FindElement(By.Id("video-game"));

        //limited time, remove after October 31st
        public IWebElement halloweenButton => driver.FindElement(By.Id("halloween"));

        //End Nav Bar items

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(pokeCenterBaseURL);
        }
    }
}
