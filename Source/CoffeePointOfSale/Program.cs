using CoffeePointOfSale.Forms;
using CoffeePointOfSale.Services.DrinkMenu;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoffeePointOfSale;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    public static List<Order> listOfAllOrders = new List<Order>();
    public static Order currentOrder;

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        SetupDisplay();

        SetupDependencyInjection();

        Start();
    }

    private static void Start()
    {
        ApplicationConfiguration.Initialize();
        var mainForm = ServiceProvider!.GetRequiredService<FormMain>();
        Application.Run(mainForm);
    }

    private static void SetupDisplay()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
    }

    private static void SetupDependencyInjection()
    {
        //https://stackoverflow.com/a/70476716
        //how to setup DI for Winforms
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        Startup.ConfigureFormFactory(ServiceProvider);
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => Startup.ConfigureServices(services));
    }

    public static void AddToOrders(Order order)
    {
        listOfAllOrders.Add(order);
    }

    public static void DisplayOrderToListBox(Order order, ListBox listbox)
    {
        listbox.Items.Clear();
        foreach (Drink drink in order.AllDrinks)
        {
            decimal tempPrice = drink.BasePrice; //create temp price variable
            listbox.Items.Add(drink); //add the drink to the display
            foreach (Customization c in drink.CustomizationList) //foreach customization on the drink
            {
                listbox.Items.Add("+" + c); //add the customization to the display
                tempPrice += c.Price; //adjust the temp price variable
            }
            if (tempPrice != drink.BasePrice) listbox.Items.Add($"\tItem total: {tempPrice}"); //if temp price variable has changed (if custmzation that changes price applied) display item total
        }
    }
}