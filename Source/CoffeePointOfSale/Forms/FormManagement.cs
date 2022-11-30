using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private IAppSettings _appSettings;
    private ICsvExtract _csvExtract;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService, ICsvExtract CsvExtract) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        _csvExtract = CsvExtract;
        
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    /// <summary>
    /// Remove this from your project... here to show you how to get the customer list
    /// </summary>
   

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
       
    }

    private void GenerateCSVbtn_Click(object sender, EventArgs e)
    {
        // Creating file path
        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
        var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

        // Creating list of customers and csv extract lines
        var transactions = new List<Transaction>();
        var customerList = _customerService.Customers.List;

        for (int i = 0; i < customerList.Count; i++)
        {
            for (int j = 0; j < customerList[i].Orders.Count; j++)
            {
                Transaction transaction = new Transaction();
                transaction.customerPhone = customerList[i].Phone;
                transaction.transactionDateTime = customerList[i].Orders[j].TransactionTime;
                transaction.subtotal = 0;
                transaction.drinks = new List<Drink>();
               
                for (int q = 0; q < customerList[i].Orders[j].AllDrinks.Count; q++) 
                {
                    Drink tempDrink = new Drink();
                    tempDrink.Name = customerList[i].Orders[j].AllDrinks[q].Name;
                    decimal tempPrice = customerList[i].Orders[j].AllDrinks[q].BasePrice;
                    foreach (Customization c in customerList[i].Orders[j].AllDrinks[q].CustomizationList) 
                    { 
                        tempPrice += c.Price;
                        tempDrink.Customizations.Add(c.Name);

                    }
                    transaction.subtotal += tempPrice;
                    tempDrink.TotalPrice = tempPrice;

                    transaction.drinks.Add(tempDrink);
                    if (q != 0) transaction.orderDescription += " | ";
                    transaction.orderDescription += $"{tempDrink}";

                }
                transaction.tax = customerList[i].Orders[j].Tax;
                transaction.total = customerList[i].Orders[j].Total;
                if (customerList[i].Orders[j].Payment == null || customerList[i].Orders[j].Payment.IsCC)
                {
                    transaction.payment = "card";
                    transaction.rewardsPointsRedeemed = 0;
                }
                else
                {
                    transaction.payment = "rewards";
                    transaction.rewardsPointsRedeemed = customerList[i].Orders[j].Payment.RewardsCost;
                }



                    transactions.Add(transaction);

                
            }
        }

        _csvExtract.WriteCsvFile(transactions, csvPathAndFilename);

        try
        {
            var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
            {
                WorkingDirectory = outputDirectory,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
        }
    }

    public class Transaction
    {

        public string customerPhone { get; set; }
        public DateTime? transactionDateTime { get; set; }
        public decimal subtotal { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public string payment { get; set; }
        public int rewardsPointsRedeemed { get; set; }
        public string orderDescription { get; set; }
        public List<Drink> drinks { get; set; }

    }

    public class Drink
    {

        public string? Name { get; set; }
        public decimal TotalPrice { get; set; }
        public List<string> Customizations { get; set; } = new();

        public override string ToString()
        {
            var drink = $"{TotalPrice:C} {Name}";
            if (Customizations.Count > 0)
            {
                drink += ", " + string.Join(", ", Customizations);
            }

            return drink;
        }
    }

}