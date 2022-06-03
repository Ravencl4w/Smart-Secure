using SmartSecure.Domain.Models.SmartSecure;
using System.Collections.Generic;
using SmartSecure.Domain.Services.SmartSecure;
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
