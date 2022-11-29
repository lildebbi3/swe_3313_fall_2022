using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        Drinks = _storageService.Read<Drinks>(); //load drinks from JSON file
        
    }
    public Drinks Drinks { get; init; }
}