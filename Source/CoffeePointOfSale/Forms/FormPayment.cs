using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using CreditCardValidator;
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

        private void CCPaymentBtn_Click(object sender, EventArgs e)
        {
            CCwarningLabel.Visible = false;
            //gets textbox data of card and details
            string cardNum = ccNumTxtbox.Text;
            string expDate = ExpDateTxtbox.Text;
            string cvv = cvvTxtbox.Text;
            //checks if anyone of them are empty
            if (cardNum == "" || cvv == "" || expDate == "")
            {
                //must have a card number to read and won't take empty variable 
                cardNum = "1";
            }
            CreditCardDetector detector = new CreditCardDetector(cardNum);
            //checks if card is valid
            if (detector.IsValid())
            {
                Close();
                FormFactory.Get<FormReceipt>().Show();
            }
            else
            {
                //if not vaild displays message
                CCwarningLabel.Visible = true;
            }
            
           
        }
    }
}
