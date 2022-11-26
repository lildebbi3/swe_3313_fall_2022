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
            string phoneNumber = textBoxPN.Text;
            string firstName = textBoxFN.Text;
            string lastName = textBoxLN.Text;
            if ((lastName=="")||(firstName==""))
            {

                CCwarningLabel.Visible = true;
            }
            else
            {
                CCwarningLabel.Visible = false;
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
                //formManagement must be changed to FormOrder when available
                FormFactory.Get<FormManagement>().Show();
            }

        }
    }
}
