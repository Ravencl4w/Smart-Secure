using GoingTo_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Repositories.Geographic
{
    public interface ICountryCurrencyRepository
    {
        Task<IEnumerable<CountryCurrency>> ListAsync();
        Task<IEnumerable<CountryCurrency>> ListByCountryAsync(int countryId);
        Task<IEnumerable<CountryCurrency>> ListByCurrencyAsync(int currencyId);
        Task<CountryCurrency> FindByCountryIdAndCurrencyId(int countryId, int currencyId);
        Task AddAsync(CountryCurrency countryCurrency);
        void Remove(CountryCurrency countryCurrency);
        Task AssignCountryCurrency(int countryId, int currencyId);
        void UnassignCountryCurrency(int countryId, int currencyId);
    }
}
