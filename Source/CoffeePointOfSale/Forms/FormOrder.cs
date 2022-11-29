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
        private bool[] drinkSelected = new bool[]
        {
            false, //coffee     0
            false, //esspresso  1
            false, //latte      2
            false, //matcha     3
            false, //cappucino  4
            false, //water      5
            false  //tea        6
        }; //this is a utility array to track what kind of drink is selected

        public FormOrder(IAppSettings appSettings, ICustomerService customerService)
        {
            _appSettings = appSettings;
            _customerService = customerService;
            InitializeComponent();

            ResetForm(false);
            UpdateSelectedDrink(-1);
        }

        private void ResetForm(bool drinkCurrentlySelected = true) //reset the input sections of this form (does not affect the order list, subtotal, tax, total, or complete order button
        {
            QtyTxtbox.Text = "Qty: \n1";

            if (!drinkCurrentlySelected) //if no drink has been selected
            {
                //disable groups
                custmzGroup.Enabled = false;
                sizesGroup.Enabled = false;

                //disable individual buttons
                addDrinkBtn.Enabled = false;
            }
            else
            {
                //enable groups
                custmzGroup.Enabled = true;
                sizesGroup.Enabled = true;

                //enable individual buttons
                addDrinkBtn.Enabled = true;
            }

            //set default radio values
            regularRBtn.Checked = true;
            if (drinkSelected[5]) coldRBtn.Checked = true;
            else hotRBtn.Checked = true;

            //set default checkbox values
            nFMilkCB.Checked = wholeMilkCB.Checked = oatMilkCB.Checked = almondMilkCB.Checked = soyMilkCB.Checked = false;
            sugarCB.Checked = sNLCB.Checked = steviaCB.Checked = false;
            whippedCreamCB.Checked = chocolateSCB.Checked = foamCB.Checked = false;
        }

        //set the correct array slot to true for the given index
        //pass -1 to set all to false
        private void UpdateSelectedDrink(int indexForTrue)
        {
            for (int a = 0; a < drinkSelected.Length; a++)
            {
                drinkSelected[a] = false;
                if (a == indexForTrue) drinkSelected[a] = true;
            }
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

        //select coffee
        private void coffeeObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(0);
            ResetForm();
        }

        //select espresso
        private void espressoObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(1);
            ResetForm();
        }

        //select latte
        private void latteObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(2);
            ResetForm();
        }

        //select matcha
        private void mgtlObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(3);
            ResetForm();
        }

        //select cappuccino
        private void cappuccinoObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(4);
            ResetForm();
        }

        //select water
        private void waterObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(5);
            ResetForm();
        }

        //select tea
        private void teaObtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(6);
            ResetForm();
        }
    }
}
