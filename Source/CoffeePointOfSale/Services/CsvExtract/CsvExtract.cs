using CsvHelper;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Text;
namespace CoffeePointOfSale.Services.CsvExtract
{
    public class CsvExtract : ICsvExtract
    {
       public void WriteCsvFile<TModel>(IEnumerable<TModel> listToConvert, string fullPath)
        {
            using var writer = new StreamWriter(fullPath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture); 
            csv.WriteRecords(listToConvert);
        }

        public string ConvertToCsv<TModel>(IEnumerable<TModel> listToConvert)
        {
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(listToConvert);

            return Encoding.UTF8.GetString(stream.ToArray());
        }
        /// <summary>
        /// Add service to DI container - normally done in an extension method, but this way for simplicity
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddSingleton<ICsvExtract, CsvExtract>();
        }
    }

}
