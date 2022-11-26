using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.CsvExtract
{
    public interface ICsvExtract
    {
        string ConvertToCsv<TModel>(IEnumerable<TModel> listToConvert);

        void WriteCsvFile<TModel>(IEnumerable<TModel> listToConvert, string fullPath);
    }

}
