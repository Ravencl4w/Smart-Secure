using SmartSecure.Domain.Models.Accounts;
using System.Collections.Generic;
using SmartSecure.Domain.Services.Communications;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services.Accounts
{
    public interface ICondominioService
    {
        Task<IEnumerable<Condominio>> ListAsync();
        Task<Condominio> FindById(int Condominio);
        Task<Condominio> SaveAsync(Condominio condominio);
        Task<Condominio> UpdateAsync(int id, Condominio condominio);
        Task<Condominio> DeleteAsync(int id);
    }
}
