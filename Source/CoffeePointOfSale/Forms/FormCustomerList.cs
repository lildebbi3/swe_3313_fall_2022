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
       

        //displays customer data
        private void DisplayCustomers()
        {
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
                customerListTxtbox.AppendText($"{customerIdx + 1}.{customer}{Environment.NewLine}");
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Size = new Size(25,25);
                btn.Location = new Point(customerListTxtbox.ClientSize.Width - btn.Width, -1);
                btn.Cursor = Cursors.Default;
                //adds the functionality to the button
                btn.Click += new EventHandler(orderbtn);
                customerListTxtbox.Controls.Add(btn);
                
            }

        }

        //order button to the customer
        private void orderbtn (object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().ShowDialog();
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
