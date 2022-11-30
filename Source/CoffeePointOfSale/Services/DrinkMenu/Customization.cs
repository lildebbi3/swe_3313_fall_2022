using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class Customization
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Customization(String name) //public constructor to ensure no values left null
        {
            Name = name;
        }
        public string Url => Regex.Replace(Name.Trim(), "[^a-zA-Z0-9]", "-");

        public override string ToString()
        {
            string temp = $"{Name} - {Price}";
            return temp;
        }
        
        public string ToString(int quantity)
        {
            string temp = $"{Name} x{quantity} - {Price * quantity} (@{Price} per)";
            return temp;
        }
    }
}
