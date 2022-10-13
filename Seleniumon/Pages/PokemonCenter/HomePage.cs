using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumon.Pages.PokemonCenter
{
    internal class HomePage
    {
        //URL for pokemon center (shop): https://www.pokemoncenter.com/
        private IWebDriver driver;
        public void Homepage(IWebDriver webDriver)
        {
            this.driver =  webDriver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.pokemoncenter.com/");
        }
    }
}
