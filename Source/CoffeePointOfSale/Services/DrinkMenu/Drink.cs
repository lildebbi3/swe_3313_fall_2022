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
        private List<Customization> _customizations;
       
        public string? Name { get; set; }
        public decimal BasePrice { get; set; }

        public Drink(List<Customization> customizations)
        {
            _customizations = customizations;
        }
        public List<Customization> CustomizationList {
            get => _customizations;
            set => _customizations = value ?? new List<Customization>(); 
        } //list of all customizations applied to the drink

        /*
        public Drink(string name = "") //constructor to initialize Customizations and ensure no null values for DrinkType and Quantity
        {
            Name = name;
            //Quantity = 1;
            CustomizationList = new List<Customization>();
        }*/

        public override string ToString()
        {
         return $"{Name} {BasePrice}";
        }

        public void AddCustomization(Customization customization)
        {
            CustomizationList.Add(customization);
        }
    }
}
