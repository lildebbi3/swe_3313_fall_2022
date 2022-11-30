using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using CreditCardValidator;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : Base.FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        private readonly ICustomerService _customerService;
        private bool validExp;

        public FormPayment(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;

            //for every drink in the order
            Program.DisplayOrderToListBox(Program.currentOrder, orderItems);

            subtotalLabel.Text = $"Sub-Total: ${Program.currentOrder.SubTotal}";
            salestaxLabel.Text = $"Sales Tax: ${Program.currentOrder.Tax}";
            totalLabel.Text = $"    Total: ${Program.currentOrder.Total}";

            Program.currentOrder.Payment = new Order.PaymentMethod(); //create new payment for the order

            int tempRC = 0, tempRE = 0;
            if (!Program.useAnon)
            {
                //calculate the cost to pay with rewards points
                decimal tempRewardsCost = Program.currentOrder.Total * _appSettings.Rewards.PointsPerDollar;
                decimal dif1 = tempRewardsCost % 1;
                tempRC = (int)(tempRewardsCost + dif1);
                Program.currentOrder.Payment.RewardsCost = tempRC;

                //calculate the points earned if payed with cc
                decimal tempRewardsEarned = Program.currentOrder.Total * _appSettings.Rewards.PointsPerDollar;
                decimal dif2 = tempRewardsEarned % 1;
                tempRE = (int)(tempRewardsEarned - dif2);
                Program.currentOrder.Payment.RewardsEarned = tempRE;

                //set displays
                rpCostLabel.Text = $"Rewards Cost: {tempRC}";
                rpToEarnLabel.Text = $"Rewards to Earn: {tempRE}";

                currentRPLabel.Text = $"{Program.currentOrder.CurrentCustomer.firstName}'s Points: {Program.currentOrder.CurrentCustomer.RewardPoints}";
                if (Program.currentOrder.CurrentCustomer.RewardPoints >= tempRC) RewardPaymentBtn.Enabled = true;
            }
            else
            {
                currentRPLabel.Text = "Anonymous customer";
                rpCostLabel.Text = "cannot use or earn";
                rpToEarnLabel.Text = "rewards points";
                RewardPaymentBtn.Text = "Unavailable";
            }
        }

        //cancel payment button, takes you back to main menu
        private void paymentCancelBtn_Click(object sender, EventArgs e)
        {
            Program.useAnon = false;
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void CCPaymentBtn_Click(object sender, EventArgs e)
        {
            CCwarningLabel.Visible = false;
            //gets textbox data of card and details
            string cardNum = ccNumTxtbox.Text;
            string expDate = ExpDateTxtbox.Text;
            string cvv = cvvTxtbox.Text;
            //checks if anyone of them are empty
            if (cardNum == "" || cvv == "" || expDate == "") cardNum = "1"; //must have a card number to read and won't take empty variable  
            CreditCardDetector detector = new CreditCardDetector(cardNum);

            //determines if valid CVV entered
            bool validCVV = true;
            if (cvv.Length == 3)
            {
                foreach (Char c in cvv)
                {
                    if (!Char.IsDigit(c))
                    {
                        validCVV = false;
                        break;
                    }
                }
            }

            //determines if valid expiration date entered
            validExp = CheckForValidExp(expDate);

            //if card is valid
            if (detector.IsValid() && validCVV && validExp)
            {
                Order temp = Program.currentOrder;
                temp.Payment.IsCC = true;
                temp.Payment.RewardsCost = 0;
                temp.Payment.CardDetails = cardNum.Substring(12);

                temp.TransactionTime = DateTime.Now;

                if (!Program.useAnon)
                {
                    temp.CurrentCustomer.RewardPoints += temp.Payment.RewardsEarned;
                    _customerService.Write();
                }


                Program.useAnon = false;
                Program.AddToOrders(temp); //add the current temporary order to the list of completed orders
                Close();
                FormFactory.Get<FormReceipt>().Show();
            }
            else CCwarningLabel.Visible = true; //if not vaild displays message 
        }

        //ensure card is not expired
        private bool CheckForValidExp(string expDate)
        {
            int m = -1, y = -1;
            if (expDate.Length < 4 || expDate.Length > 5) return false; //check for too small or too big
            else if (expDate.Length == 5 && expDate.Contains('/')) //check for contains slash
            {
                string[] my = expDate.Split('/'); //split on the slash
                foreach (char c in my[0]) //foreach char in month
                {
                    if (!Char.IsDigit(c)) return false; //check for anything other than digits
                }
                foreach (char c in my[1]) //foreach char in year
                {
                    if (!Char.IsDigit(c)) return false; //check for anything other than digits
                }
                m = Convert.ToInt32(my[0]);
                y = Convert.ToInt32(my[1]);
            }
            else if (expDate.Length == 4) //check for no slash
            {
                foreach (char c in expDate) //foreach char in exp
                {
                    if (!Char.IsDigit(c)) return false; //check for anything other than digits
                }
                m = Convert.ToInt32(expDate.Substring(0, 2));
                y = Convert.ToInt32(expDate.Substring(2));

            }
            if (m < 1 || m > 12) return false; //check for too big or too small month

            int currentY = DateAndTime.Year(DateTime.Now); //get current year
            currentY -= 2000; //get last 2 digits of year (change to 3000 in year 3000)

            if (y < currentY) return false; //if given year is smaller than current year invalid
            else if (y == currentY) //if given year is this year
            {
                int currentM = DateAndTime.Month(DateAndTime.Now); //get current month
                if (m >= currentM) return false; //if given month is smaller than or equal to current month invalid
            }

            //if made it to the end without returning invalid return valid
            return true;
        }

        private void RewardPaymentBtn_Click(object sender, EventArgs e)
        {
            //verification for this button is done before the user ever clicks on it,
            //it is disabled if the user does not have enough points or is anonymous
            Order temp = Program.currentOrder;
            temp.Payment.IsCC = false;
            temp.Payment.RewardsEarned = 0;

            temp.TransactionTime = DateTime.Now;

            temp.CurrentCustomer.RewardPoints -= temp.Payment.RewardsCost;
            _customerService.Write();

            Program.useAnon = false;
            Program.AddToOrders(temp);
            Close();
            FormFactory.Get<FormReceipt>().Show();
        }
    }
}
