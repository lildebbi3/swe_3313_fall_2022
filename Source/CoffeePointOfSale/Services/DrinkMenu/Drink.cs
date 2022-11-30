using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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

       

        public override string ToString()
        {
            string temp = $"{Name} - {BasePrice}";
            return temp;
        }

        public string ToString(int quantity)
        {
            string temp = $"{Name} x{quantity} - {BasePrice * quantity} (@{BasePrice} per)";
            return temp;
        }

        public void AddCustomization(Customization customization)
        {
            CustomizationList.Add(customization);
        }
    }
}
