using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class Drinks
    {
        /// <summary>
        /// Private dictionary containing all of the drinks
        /// </summary>
        [JsonProperty("DrinkMenu")]
        private readonly Dictionary<string, Drink> _drinkDict = new();

        /// <summary>
        /// Returns a readonly list of all drinks.
        /// </summary>
        [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
        public IReadOnlyList<Drink> List => _drinkDict.Select(c => c.Value).OrderBy(c => c.DrinkType).ToList();

    }
}
