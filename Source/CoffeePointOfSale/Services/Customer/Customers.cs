using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customers
{
    /// <summary>
    /// Private dictionary containing all of the customers. Lookup via phone.
    /// </summary>
    [JsonProperty("Customers")]
    private readonly Dictionary<string, Customer> _customerDict = new();

    /// <summary>
    /// Returns a readonly list of all customers.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<Customer> List =>
        _customerDict.Select(c => c.Value)
            .OrderBy(c => c.lastName)
            .OrderBy(c => c.IsAnonymous ? 0 : 1)
            .ToList();

    /// <summary>
    /// Indexer to return a specific customer by phone.
    /// </summary>
    /// <param name="phone"></param>
    /// <returns>Returns a customer if phone was found. Returns null otherwise. Does not throw.</returns>
    public Customer? this[string phone]
    {
        get
        {
            phone = (phone ?? "").Trim(); //ensures phone is not null and has no leading or trailing spaces
            return _customerDict.ContainsKey(phone) ? _customerDict[phone] : null;
        }
    }

    /// <summary>
    /// Indexer to return a specific customer by GUID.
    /// </summary>
    /// <param name="GUID"></param>
    /// <returns>Returns a customer if GUID was found. Returns null otherwise. Does not throw.</returns>
    public Customer? this[string enterNull, string GUID]
    {
        get
        {
            GUID = (GUID ?? "").Trim(); //ensures the GUID is not null and has no leading or trailing spaces
            return _customerDict.ContainsKey(GUID) ? _customerDict[GUID] : null;
        }
    }

    /// <summary>
    /// Adds a new customer to the customer dictionary.
    /// </summary>
    /// <param name="customer"></param>
    /// <returns>True if added. False if not added (phone already present in list). Does not throw.</returns>
    public bool Add(Customer customer) 
    {
        if (this[customer.Phone] != null) return false;
        _customerDict.Add(customer.Phone, customer);
        return true;
    }
}