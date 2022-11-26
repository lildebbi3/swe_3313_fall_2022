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
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        public FormCustomerList()
        {
            InitializeComponent();
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
