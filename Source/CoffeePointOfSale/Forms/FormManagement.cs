using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
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
    private void DemonstrateGettingCustomerList()
    {
        var customerList = _customerService.Customers.List;
        for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
        {
            var customer = customerList[customerIdx];
            txtDeleteThis.AppendText($"{customerIdx+1}.{customer}{Environment.NewLine}");
        }
    }

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
        DemonstrateGettingCustomerList();
    }

    private void GenerateCSVbtn_Click(object sender, EventArgs e)
    {
        // Creating file path
        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
        var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

        // Creating list of customers and csv extract lines
        var csvExtractLines = new List<csvExtractLine>();
        var customerList = _customerService.Customers.List;

        for (int i = 0; i < customerList.Count; i++)
        {
            for (int j = 0; j < customerList[i].Orders.Count; j++)
            {
                
                    csvExtractLine csvExtract = new csvExtractLine
                    {
                        customerPhone = customerList[i].Phone,
                        transactionDate = customerList[i].Orders[j].TransactionTime,
                        rewardPoints = customerList[i].RewardPoints,
                        //OrderDescription = string.Join(" | ", customerList[i].Orders[j].AllDrinks),
                        subtotal = customerList[i].Orders[j].SubTotal,
                        tax = customerList[i].Orders[j].Tax,
                        total = customerList[i].Orders[j].Total,

                    };

                    csvExtractLines.Add(csvExtract);
                
            }
        }

        _csvExtract.WriteCsvFile(csvExtractLines, csvPathAndFilename);

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

    public class csvExtractLine
    {

        
        public string customerPhone { get; set; }
        public DateTime? transactionDate { get; set; }

        public string OrderDescription { get; set; }
        public int rewardPoints { get; set; }
        public decimal subtotal { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }


    }
    public class Drink
    {
        public string? Name { get; set; }
        public decimal BasePrice { get; set; }
        public List<string> Customizations { get; set; } = new();

        public override string ToString()
        {
            var drink = $"{Name} {BasePrice:C}";
            if (Customizations.Count > 0)
            {
                drink += " " + string.Join(", ", Customizations);
            }

            return drink;
        }
    }

}