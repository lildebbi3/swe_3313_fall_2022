using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
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
        private IDrinkMenuService _drinkMenuService;
        private bool[] drinkSelected = new bool[]
        {
            false, //latte          0
            false, //iced latte     1
            false, //matcha latte   2
            false, //coffe          3
            false, //water          4
            false  //espresso       5
        }; //this is a utility array to track what kind of drink is selected
        private Order currentOrder;
        private Drink currentDrink;

        public FormOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService)
        {
            currentOrder = new Order();
            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            InitializeComponent();

            ResetForm(drinkCurrentlySelected:false);
        }

        private void ResetForm(string drinkType = "", bool drinkCurrentlySelected = true) //reset the input sections of this form (does not affect the order list, subtotal, tax, total, or complete order button
        {
            orderItems.Items.Clear();
            foreach (Drink drink in currentOrder.AllDrinks) orderItems.Items.Add(drink);
            QtyTxtbox.Text = "Qty: \n1";

            //set default listbox values
            customizationListBox.ClearSelected();

            if (!drinkCurrentlySelected) //if no drink has been selected
            {
                currentDrink = new Drink();
                addDrinkBtn.Enabled = false;
                UpdateSelectedDrink(-1);
            }
            else
            {
                addDrinkBtn.Enabled = true;
                currentDrink = new Drink(drinkType);
            }
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

        private void addDrinkBtn_Click(object sender, EventArgs e)
        {
            currentDrink.Quantity = Convert.ToInt32(QtyTxtbox.Lines[1]);
            currentOrder.Add(currentDrink);
            ResetForm(drinkCurrentlySelected:false);
        }

        //latte button is clicked
        private void latteBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(0);
            ResetForm("Latte");
        }

        //iced latte button is clicked
        private void icedLatteBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(1);
            ResetForm("Iced Latte");
        }

        //iced matcha green tea latte button is clicked
        private void matchaGreenBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(2);
            ResetForm("Iced Matcha Green Tea Latte");
        }

        //coffee button is clicked
        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(3);
            ResetForm("Coffee");
        }

        //iced water button is clicked
        private void waterBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(4);
            ResetForm("Iced Water");
        }

        //espresso button is clicked
        private void espressoBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(5);
            ResetForm("Espresso");
        }
    }
}
