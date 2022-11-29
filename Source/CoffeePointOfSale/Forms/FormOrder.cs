using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
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

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrder : Base.FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings, ICustomerService customerService)
        {
            _appSettings = appSettings;
            _customerService = customerService;
            InitializeComponent();

            ResetForm();
        }

        private void ResetForm(bool drinkSelected = false) //reset the input sections of this form (does not affect the order list, subtotal, tax, total, or complete order button
        {
            QtyTxtbox.Text = "Qty: \n1";

            if (!drinkSelected) //if no drink has been selected
            {
                //disable groups
                custmzGroup.Enabled = false;
                sizesGroup.Enabled = false;

                //disable individual buttons
                addDrinkBtn.Enabled = false;
            }

            //set default checked values
            regularRBtn.Checked = true;
            hotRBtn.Checked = true;
        }

        //demonstrating how to get the customer from the customer list 
        private void FormOrder_Load(object sender, EventArgs e)
        {
            coffeeLabel.Text = FormCustomerList.GetCustomer.ToString();
        }

        //return to main menu
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        //decrease quantity of drink
        private void minusBtnQ_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(QtyTxtbox.Lines[1]); //grab current quantity
            if (temp <= 2) //check for quantity of 2 or less
            {
                QtyTxtbox.Text = "Qty: \n1";
                return;
            }
            QtyTxtbox.Text = "Qty: \n" + (temp - 1); //decrease the quantity by 1 if not too low
        }

        //increase quantity of drink
        private void plusBtnQ_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(QtyTxtbox.Lines[1]); //grab current quantity
            QtyTxtbox.Text = "Qty: \n" + (temp + 1); //increase the quantity by 1
        }

        //go to payment form
        private void payButton_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }

        //deselect other sizes if this size is chosen
        private void smallRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (smallRBtn.Checked) regularRBtn.Checked = largeRBtn.Checked = false;
        }

        //deselect other sizes if this size is chosen
        private void regularRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (regularRBtn.Checked) smallRBtn.Checked = largeRBtn.Checked = false;
        }

        //deselect other sizes if this size is chosen
        private void largeRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (largeRBtn.Checked) smallRBtn.Checked = regularRBtn.Checked = false;
        }

        //deselect cold if hot is chosen
        private void hotRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (hotRBtn.Checked) coldRBtn.Checked = false;
        }

        //deselect hot if cold is chosen
        private void coldRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (coldRBtn.Checked) hotRBtn.Checked = false;
        }
    }
}
