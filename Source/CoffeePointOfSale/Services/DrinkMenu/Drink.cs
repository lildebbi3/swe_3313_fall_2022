using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class Drink
    { 
        public string DrinkType { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<Customization> Customizations { get; set; } //list of all customizations applied to the drink

        public Drink(string name = "") //constructor to initialize Customizations and ensure no null values for DrinkType and Quantity
        {
            DrinkType = name;
            //Quantity = 1;
            Customizations = new List<Customization>();
        }

        public override string ToString()
        {
            string temp; //create the string
            if (Quantity == 1) temp = $"{DrinkType} - {Price}"; //if quantity of 1 dont display the quantity
            else temp = $"{DrinkType} x{Quantity} - {Price * Quantity} ({Price} each)"; //if quantity is more than 1 display the quantity and mark the price up
            foreach (Customization cust in Customizations) temp += $"\n\t+ {cust.ToString(Quantity)}"; //add each customization to the string
            return temp; //return the string
        }

        public void AddCustomization(Customization customization)
        {
            Customizations.Add(customization);
        }
    }
}
