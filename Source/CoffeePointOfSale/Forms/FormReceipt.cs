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
        private ICustomerService? _customerService;
        public FormReceipt(IAppSettings appSettings, ICustomerService? customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
            Customer tempCust = _customerService.Customers[Program.currentPhone];

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
            rpLabel.Text += $" New Balance: {tempCust.RewardPoints}";

            datetimeLabel.Text = $"Date and Time: {temp.TransactionTime}";
            guidLabel.Text = $"{tempCust.firstName}'s GUID: {tempCust.GUID}";
            _customerService = customerService;
        }

        private void RecceiptMainMenubtn_Click(object sender, EventArgs e)
        {
            Program.currentPhone = "anonymous";
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
