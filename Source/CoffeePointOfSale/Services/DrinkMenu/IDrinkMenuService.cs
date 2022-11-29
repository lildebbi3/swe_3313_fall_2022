namespace CoffeePointOfSale.Services.DrinkMenu;

public interface IDrinkMenuService 
{
    public IReadOnlyList<Drink> DrinkMenuList { get; init; }

}