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
    public partial class FormPayment : Base.FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        public FormPayment(IAppSettings appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
        }

        private void paymentCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
