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
using System.IO;
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
        public int drinkType;
        decimal drinksubtotal;
        decimal drinktotal;
        decimal drinktax;
        public int quantityofDrink = 0;
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

            ResetForm();
        }

        private void ResetForm()
        {
            if (drinkSelected[0])
            {
                latteBtn.PerformClick();
                return;
            }
            if (drinkSelected[1])
            {
                icedLatteBtn.PerformClick();
                return;
            }
            if (drinkSelected[2])
            {
                matchaGreenBtn.PerformClick();
                return;
            }
            if (drinkSelected[3])
            {
                coffeeBtn.PerformClick();
                return;
            }
            if (drinkSelected[4])
            {
                waterBtn.PerformClick();
                return;
            }
            if (drinkSelected[5])
            {
                espressoBtn.PerformClick();
                return;
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
        
        //populates the customizations listbox with the corresponding drink number
        private void populateCB()
        {
            //clears the listbox
            customizationListBox.Items.Clear();
            //gets the DrinkMenuList and sets the choosen drink by the userr
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];
             
            //loops over the customizations adding them to the listbox
            for (var index=0; index < drink.CustomizationList.Count; index++)
            {
                var customization = drink.CustomizationList[index];
                customizationListBox.Items.Add(customization.ToString());

            }
        }

        //gets the checked boxes of customizations by the drink and returns a bool array of the checked boxes
        private bool[] determineCustomizations()
        {
            //gets the DrinkMenuList and sets the choosen drink by the userr
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];

            //sets up the calculations
            bool[] checkedBoxes = new bool [drink.CustomizationList.Count];
          
            //loops through the boxes detecting if they are checked.
            for(int customNum=0; customNum< customizationListBox.Items.Count;customNum++)
            {
                if(customizationListBox.GetItemChecked(customNum))
                {
                    checkedBoxes[customNum] = true;
                }
                else
                {
                    checkedBoxes[customNum] = false;
                }
            }
            return checkedBoxes;

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
            int temp = Convert.ToInt32(qtyTxtbox.Lines[1]);
            if (temp >= 2)
            {
                temp--;
                quantityofDrink--;
            }
            qtyTxtbox.Text = $"Qty: \n{temp}";
        }

        //increase quantity of drink
        private void plusBtnQ_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(qtyTxtbox.Lines[1]);
            temp++;
            quantityofDrink++;
            qtyTxtbox.Text = $"Qty: \n{temp}";
        }

        //populate checkbox for customizations
       

        //go to payment form
        private void payButton_Click(object sender, EventArgs e)
        {
            //Program.inProgressOrder = 
            Close();
            FormFactory.Get<FormPayment>().Show();
        }
   
        //this method should take the drink and its customizations and display it onto the orderItems textbox
        private void addDrinkBtn_Click(object sender, EventArgs e)
        {
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];
            bool[] customs = determineCustomizations();
            getDrinkCost(drink, customs);

            orderItems.AppendText(drink.ToString());
            
            for(var index = 0; index < drink.CustomizationList.Count; index++)
            {
                if (customs[index] == true)
                {
                    orderItems.AppendText(drink.CustomizationList[index].ToString());
                   
                }
            }
            subTotalLabel.Text=(drinksubtotal.ToString());
            salesTaxLabel.Text = ( drinktax.ToString());
            totalLabel.Text=(drinktotal.ToString());
            


            ResetForm();
        }

        private void getDrinkCost(Drink drink, bool[] customs)
        {
           
            decimal subtotal = Convert.ToDecimal(subTotalLabel.Text);
            decimal tax = _appSettings.Tax.Rate;
            decimal total = Convert.ToDecimal(totalLabel.Text);

            subtotal += drink.BasePrice;
            for (var index = 0; index < drink.CustomizationList.Count; index++)
            {
                if (customs[index] == true)
                {
                    subtotal += drink.CustomizationList[index].Price;
                    total += (subtotal * tax) + subtotal;
                }
            }

            drinktotal = total;
            drinksubtotal = subtotal;
            drinktax = (total * tax);

        }



        //latte button is clicked
        private void latteBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 0;
            populateCB();
            UpdateSelectedDrink(0);
            latteBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = espressoBtn.BackColor = defaultButtonColor;
        }

        //iced latte button is clicked
        private void icedLatteBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 1;
            populateCB();
            UpdateSelectedDrink(1);
            icedLatteBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = espressoBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
        }

        //iced matcha green tea latte button is clicked
        private void matchaGreenBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 2;
            populateCB();
            UpdateSelectedDrink(2);
            matchaGreenBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = espressoBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
        }

        //coffee button is clicked
        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 3;
            populateCB();
            UpdateSelectedDrink(3);
            coffeeBtn.BackColor = selectedColor;
            waterBtn.BackColor = espressoBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
        }

        //iced water button is clicked
        private void waterBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 4;
            populateCB();
            UpdateSelectedDrink(4);
            waterBtn.BackColor = selectedColor;
            espressoBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
        }

        //espresso button is clicked
        private void espressoBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Text = "Qty: \n1";
            drinkType = 5;
            populateCB();
            UpdateSelectedDrink(5);
            espressoBtn.BackColor = selectedColor;
            waterBtn.BackColor = coffeeBtn.BackColor = matchaGreenBtn.BackColor = icedLatteBtn.BackColor = latteBtn.BackColor = defaultButtonColor;
        }
    }
}
