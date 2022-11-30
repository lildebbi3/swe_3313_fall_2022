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
using System.Text.RegularExpressions;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCreateCustomer : Base.FormNoCloseBase
    {
        private ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormCreateCustomer(IAppSettings appSettings, ICustomerService customerService): base(appSettings)
        {
            InitializeComponent();
            _customerService = customerService;
            _appSettings = appSettings;

        }
        //fucked up don't touch until i figure it out, with love -mm
        private void label5_Click(object sender, EventArgs e)
        { }

        //back button of the Create customer form that takes you to the main form
        private void backBtnCC_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

     
        //validates and adds customer to DB
        //does not do that yet, it adds to the customer dictionary but not the json
        private void button1_Click(object sender, EventArgs e)
        {
            //gets the values from the text boxes and places them in variables
            string phoneNumber = textBoxPN.Text;
            string firstName = textBoxFN.Text;
            string lastName = textBoxLN.Text;
            int nameCharCount = firstName.Count() + lastName.Count();
            //checks if lastname and firstname are empty, if they are then displays message
            if (nameCharCount<9)
            {

                CCwarningLabel.Visible = true;
            }
            else if(PhoneNumber.IsPhoneNbr(phoneNumber))
            {
                CCwarningLabel.Visible = false;
                //creates a customer object with values
                var newCust = new Customer()
                {
                    firstName = firstName,
                    lastName = lastName,
                    Phone = phoneNumber,
                    RewardPoints = 0
                };
                //finds if customer already exists, if not then adds customer to DB
                if (_customerService.Customers[newCust.Phone] == null)
                {
                    _customerService.Customers.Add(newCust);
                    _customerService.Write();
                }
                Close();
                FormFactory.Get<FormOrder>().Show();
            }

        }
    }
    //class to check if a number is a phone number
    public static class PhoneNumber
    {
        // Regular expression used to validate a phone number.
        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        //method to call to identify if a number is a phone number
        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }
    }
}
