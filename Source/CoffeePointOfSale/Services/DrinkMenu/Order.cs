using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    internal class Order
    {
        public Customer.Customer CurrentCustomer { get; set; }
        public List<Drink> AllDrinks { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public PaymentMethod Payment { get; set; }
        public DateAndTime TransactionTime { get; set; }


        public Order() //constructor to initialize the list
        {
            AllDrinks = new List<Drink>();
        }

        //add a drink to the order
        public void Add(Drink drink)
        {
            AllDrinks.Add(drink);
        }

        public override string ToString()
        {
            string temp = ""; //declare string
            int itemNum = 1; //declare item number for display
            foreach (Drink drink in AllDrinks) //for each drink in the list
            {
                if (itemNum > 1) temp += $"\n{itemNum}-{drink}"; //if item number is greater than 1 add \n
                else temp += $"{itemNum}-{drink}";
                itemNum++; //increase item number
            }
            return temp; //return string
        }


        //included paymentmethod class
        internal class PaymentMethod
        {
            public bool IsCC { get; set; } //true if used credit card, false if used rewards points
            public string? cardDetails { get; set; } //the card number, can be null since can use rewards points
            public int RewardsEarned { get; set; } //number of rewards points earned
            public int RewardsCost { get; set; } //number of rewards points it would cost to pay with points
        }
    }
}
