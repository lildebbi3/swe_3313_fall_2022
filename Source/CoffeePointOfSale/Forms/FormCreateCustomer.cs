using CoffeePointOfSale.Configuration;
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
        private IAppSettings? _appSettings;
        public FormCreateCustomer(IAppSettings appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;

        }
        //fucked up don't touch until i figure it out, with love -mm
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //back button of the Create customer form that takes you to the main form
        private void backBtnCC_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
