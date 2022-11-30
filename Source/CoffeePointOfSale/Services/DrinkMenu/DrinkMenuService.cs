using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using Newtonsoft.Json;
using System.Reflection;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;



    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        var drinkMenuList = LoadDrinkMenuFromJsonFile();
        DrinkMenuList = drinkMenuList.AsReadOnly();
    }

    public IReadOnlyList<Drink> DrinkMenuList
    {
        get; init;
    }
 
    private static List<Drink> LoadDrinkMenuFromJsonFile()
    {
        //load the drink list from the Data/DrinkMenu.json file
        var execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string jsonPath = Path.Combine(execDir ?? throw new InvalidOperationException(),
            "JsonStorage",
            "DrinkMenu.json");
        var json = File.ReadAllText(jsonPath);
        var drinkMenuList = JsonConvert.DeserializeObject<List<Drink>>(json);
        if (drinkMenuList == null || !drinkMenuList.Any())
            throw new Exception($"Drink Menu JSON not found or empty at {jsonPath}");

        return drinkMenuList;
    }

    
}