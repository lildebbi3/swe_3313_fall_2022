using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    public FormMain(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
    }

    //btn takes user to management form
    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().Show();
    }

    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    //btn takes user to customer list form
    private void OnClickBtnCustomerListing(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }

    //btn takes user to order form
    private void button1_Click(object sender, EventArgs e)
    {
        Program.useAnon = true;
        Hide();
        FormFactory.Get<FormOrder>().Show();
    }
}