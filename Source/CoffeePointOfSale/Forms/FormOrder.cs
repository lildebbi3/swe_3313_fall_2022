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
    public partial class FormOrder : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings)
        {
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        //main menu button
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //pay with credit card button

        private void payWCCBtn_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }

        //pay with rewards button
        private void payWReward_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }
    }
}
