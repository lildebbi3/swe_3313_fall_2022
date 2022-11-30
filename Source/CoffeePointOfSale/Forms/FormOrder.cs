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
using System.Windows.Forms.VisualStyles;

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
        decimal orderSubtotal, tax, total;
        public int quantityofDrink = 1;
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

            //reset Program.currentOrder
            Customer temp = _customerService.Customers[Program.currentPhone];
            if (temp == null) temp = _customerService.Customers["anonymous"];
            Program.currentOrder = new Order(temp.GUID);



            payButton.Enabled = false;
            addDrinkBtn.Enabled = false;

            ResetForm();
        }

        private void ResetForm()
        {
            quantityofDrink = 1;

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
            addDrinkBtn.Enabled = true;
        }
        
        //populates the customizations listbox with the corresponding drink number
        private void populateCB()
        {
            //clears the listbox
            customizationListBox.Items.Clear();
            //gets the DrinkMenuList and sets the choosen drink by the userr
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];
            
            priceDrinkL.Text = drink.Name + ": " + drink.BasePrice;


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
            Program.useAnon = false;
            Program.currentPhone = "anonymous";
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        //decrease quantity of drink
        private void minusBtnQ_Click(object sender, EventArgs e)
        {
            if (quantityofDrink >= 2) quantityofDrink--; 
            qtyTxtbox.Text = $"Qty: \n{quantityofDrink}";
        }

        //increase quantity of drink
        private void plusBtnQ_Click(object sender, EventArgs e)
        {
            quantityofDrink++;
            qtyTxtbox.Text = $"Qty: \n{quantityofDrink}";
        }

        //go to payment form
        private void payButton_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }
   
        //this method should take the drink and its customizations and display it onto the orderItems textbox
        private void addDrinkBtn_Click(object sender, EventArgs e)
        {
            payButton.Enabled = true;

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[drinkType];
            bool[] customs = determineCustomizations();

            if (quantityofDrink == 1) orderItems.Items.Add(drink.ToString()); //if quantity is not 1 calls a different toString method
            else orderItems.Items.Add(drink.ToString(quantityofDrink));

            decimal tempPrice = drink.BasePrice; //temporary total price of an item

            List<Customization> tempCustomizations = new List<Customization>();
            //foreach possible customization on the drink
            for(var index = 0; index < drink.CustomizationList.Count; index++)
            {
                if (customs[index] == true) //if customization addded
                {
                    orderItems.Items.Add("+" + drink.CustomizationList[index].ToString()); //add customization to display
                    tempPrice += drink.CustomizationList[index].Price; //increase the temporary total price by the customization price
                    tempCustomizations.Add(drink.CustomizationList[index]);
                }
            }

            if (tempPrice != drink.BasePrice) //if tempPrice has changed (if customizations are added that change the price
            {
                if (quantityofDrink == 1) orderItems.Items.Add($"\tItem total: {tempPrice}"); //different displays for drink quantities
                else orderItems.Items.Add($"\tItem total: {tempPrice * quantityofDrink} (@{tempPrice} per)");
            }

            //calculate the prices
            CalculatePrices(tempPrice);


            //adds drink to the order
            Drink orderedDrink = new Drink(tempCustomizations)
            {
                Name = drink.Name,
                BasePrice = drink.BasePrice
            };
            Program.currentOrder.SubTotal = orderSubtotal;
            Program.currentOrder.Tax = tax;
            Program.currentOrder.Total = total;

            for (int a = 0; a < quantityofDrink; a++) Program.currentOrder.AllDrinks.Add(orderedDrink); //add the drink to the order q times

            ResetForm();
        }

        private void CalculatePrices(decimal tempPrice)
        {
            orderSubtotal += tempPrice * quantityofDrink;
            string subTotalText = $"{orderSubtotal}";
            subTotalText = Program.RemoveDecimalPlaces(subTotalText);
            subTotalLabel.Text = subTotalText;
            tax = orderSubtotal * _appSettings.Tax.Rate;
            string taxText = $"{tax}";
            taxText = Program.RemoveDecimalPlaces(taxText);
            salesTaxLabel.Text = taxText;
            total = tax + orderSubtotal;
            string totalText = $"{total}";
            totalText = Program.RemoveDecimalPlaces(totalText);
            totalLabel.Text = totalText;
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
