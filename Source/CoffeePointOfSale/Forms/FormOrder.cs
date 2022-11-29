using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
        
        private Color defaultButtonColor, selectedColor;

        public FormOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService)
        {

            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            InitializeComponent();

            //get colors for buttons
            defaultButtonColor = latteBtn.BackColor; //this gets the color that all the buttons are normally
            selectedColor = coffeeBtn.BackColor; //this is the color the coffe button is set to in the editor, the values are 128, 128, 0 (idk how to set color directly from the value without having one that is changed in the editor)
            coffeeBtn.BackColor = defaultButtonColor; //set the coffee button to the normal color before the user ever sees the selected color

            //ResetForm(drinkCurrentlySelected:false);
        }

        /*private void ResetForm(string drinkType = "", bool drinkCurrentlySelected = true) //reset the input sections of this form (does not affect the order list, subtotal, tax, total, or complete order button
        {
            orderItems.Items.Clear();
            //foreach (Drink drink in currentOrder.AllDrinks) orderItems.Items.Add(drink);
           // QtyTxtbox.Text = "Qty: \n1";
            //subTotal.Text = $"Sub-Total:\t${currentOrder.SubTotal}";
            //salesTax.Text = $"Sales Tax:\t${currentOrder.Tax}";
            //total.Text = $"Total:\t${currentOrder.Total}";

            //set default listbox values
            customizationListBox.ClearSelected();

            if (!drinkCurrentlySelected) //if no drink has been selected
            {
                latteBtn.BackColor = icedLatteBtn.BackColor = matchaGreenBtn.BackColor = coffeeBtn.BackColor = waterBtn.BackColor = espressoBtn.BackColor = defaultButtonColor;
                ///currentDrink = new Drink();
                addDrinkBtn.Enabled = false;
                UpdateSelectedDrink(-1);
            }
            else
            {
                addDrinkBtn.Enabled = true;
               // currentDrink = new Drink(drinkType); 
                var drinkList = _drinkMenuService.DrinkMenuList;
                //MessageBox.Show("This is for debugging\nDrinklist size is " + drinkList.Count);
                for (var drinkIndex = 0; drinkIndex < drinkList.Count; drinkIndex++)
                {
                    var drink = drinkList[drinkIndex];
                    MessageBox.Show("Drink type is " + drink.Name);
                    if (drink.Name == drinkType)
                    {
                        foreach (Customization c in drink.CustomizationList) customizationListBox.Items.Add(c);
                    }
                }
            }
        }*/

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
           
            //coffeeLabel.Text = FormCustomerList.GetCustomer.ToString();
        }
        
        private void populateCB(int drinkType)
        {
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];

            
            for(var index=0; index < drink.CustomizationList.Count; index++)
            {
                var customization = drink.CustomizationList[index];
                customizationListBox.Items.Add(customization.ToString());

            }
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
          //decrease the quantity by 1 if not too low
        }

        //increase quantity of drink
        private void plusBtnQ_Click(object sender, EventArgs e)
        {
           
        }

        //populate checkbox for customizations
       

        //go to payment form
        private void payButton_Click(object sender, EventArgs e)
        {
            
            Close();
            FormFactory.Get<FormPayment>().Show();
        }

        private void addDrinkBtn_Click(object sender, EventArgs e)
        {
           
           
            //ResetForm(drinkCurrentlySelected:false);
        }

        //latte button is clicked
        private void latteBtn_Click(object sender, EventArgs e)
        {
            populateCB(0);
            //var drink = _drinkMenuService.DrinkMenuList[0];
           /* var order = new Order()
            {
                CurrentCustomer = FormCustomerList.GetCustomer,
                Tax = (drink.BasePrice * _appSettings.Tax.Rate),
                Total = ((drink.BasePrice * _appSettings.Tax.Rate) + (drink.BasePrice))
            };*/
            UpdateSelectedDrink(0);
            latteBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = espressoBtn.BackColor = defaultButtonColor;
            //ResetForm("Latte");
        }

        //iced latte button is clicked
        private void icedLatteBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(1);
            icedLatteBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = espressoBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
            //ResetForm("Iced Latte");
        }

        //iced matcha green tea latte button is clicked
        private void matchaGreenBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(2);
            matchaGreenBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = espressoBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
            //ResetForm("Iced Matcha Green Tea Latte");
        }

        //coffee button is clicked
        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(3);
            coffeeBtn.BackColor = selectedColor;
            waterBtn.BackColor = espressoBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
            //ResetForm("Coffee");
        }

        //iced water button is clicked
        private void waterBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(4);
            waterBtn.BackColor = selectedColor;
            espressoBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
            //ResetForm("Iced Water");
        }

        //espresso button is clicked
        private void espressoBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedDrink(5);
            espressoBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
            //ResetForm("Espresso");
        }
    }
}
