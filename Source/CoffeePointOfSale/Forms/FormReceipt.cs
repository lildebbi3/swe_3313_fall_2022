using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Customer;

namespace CoffeePointOfSale.Forms
{
    public partial class FormReceipt : Base.FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        public FormReceipt(IAppSettings appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;

            Order temp = Program.listOfAllOrders[Program.listOfAllOrders.Count - 1];
            Program.DisplayOrderToListBox(temp, recieptItems);
            subtotalLabel.Text = $"Sub-Total: ${Program.RemoveDecimalPlaces(temp.SubTotal)}";
            salestaxLabel.Text = $"Sales Tax: ${Program.RemoveDecimalPlaces(temp.Tax)}";
            totalLabel.Text = $"    Total: ${Program.RemoveDecimalPlaces(temp.Total)}";

            if (temp.Payment.IsCC)
            {
                ccLabel.Text = $"Payment Method: Card **** **** **** {temp.Payment.CardDetails}";
                rpLabel.Text = $"Rewards Earned: {temp.Payment.RewardsEarned}";
            }
            else
            {
                ccLabel.Text = "Payment Method: Rewards ";
                rpLabel.Text = $"Rewards Used: {temp.Payment.RewardsCost}";
            }
            rpLabel.Text += $" New Balance: {Program.currentCustomer.RewardPoints}";

            datetimeLabel.Text = $"Date and Time: {temp.TransactionTime}";
            guidLabel.Text = $"{Program.currentCustomer.firstName}'s GUID: {Program.currentCustomer.GUID}";
        }

        private void RecceiptMainMenubtn_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
