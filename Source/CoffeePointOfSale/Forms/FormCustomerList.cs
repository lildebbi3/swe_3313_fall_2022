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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        //redneck way of getting the customer
       public static Customer GetCustomer
        {
            get; set;
        }
        

        //displays customer data
        private void DisplayCustomers()
        {
            //variable to increase location points by each new line
            int e = 1;
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                //adds customer data phone, first and last names
                var customer = customerList[customerIdx];
                customerListTxtbox.AppendText($"{customerIdx + 1}.{customer}{Environment.NewLine}");

                //adds order button
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Size = new Size(175, 50);
                btn.Location = new Point(customerListTxtbox.ClientSize.Width - btn.Width, e);
                e += 55;
                btn.Cursor = Cursors.Default;
                btn.Text = "Order";
                //adds the functionality to the button
                btn.Click += new EventHandler(orderbtn);
                //method that sends the cutomer the user selected to the order form and goes there
                void orderbtn(object sender, EventArgs e)
                {
                    FormCustomerList.GetCustomer = customer;
                    Hide();
                    FormFactory.Get<FormOrder>().ShowDialog();
                }
                //adds the button
                customerListTxtbox.Controls.Add(btn);
                
            }

        }
      

        //on load of the form it calls the method to display customers 
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
          
        }
        private void OnClickBtnCustomerListing(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().ShowDialog();
        }

        //btn that takes user to create customer form
        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormCreateCustomer>().Show();
        }

        
    }
}
