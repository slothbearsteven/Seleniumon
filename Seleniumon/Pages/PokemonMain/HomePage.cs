using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumon.Pages.PokemonMain
{
    internal class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        public string baseURL = "https://www.pokemon.com/us";

        //nav bar content start
        public IWebElement pokedexLink => driver.FindElement(By.XPath("/html/body/nav/div[2]/ul/li[2]/a"));
        public IWebElement videoGameAppsLink => driver.FindElement(By.XPath("/html/body/nav/div[2]/ul/li[3]/a"));
        public IWebElement tcgLink => driver.FindElement(By.XPath("/html/body/nav/div[2]/ul/li[4]/a[1]"));

        //nav bar content end

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
    }
}
