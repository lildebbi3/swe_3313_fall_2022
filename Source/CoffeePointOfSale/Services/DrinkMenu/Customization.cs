using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class Customization
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Customization() //public constructor to ensure no values left null
        {
            Name = "";
            Price = 0;
        }

        public string ToString(int quantity)
        {
            if (Price > 0) return $"{Name} +{Price*quantity}"; //if positive price return this
            return $"{Name} -{Price*quantity}"; //if negative price return this
        }
    }
}
