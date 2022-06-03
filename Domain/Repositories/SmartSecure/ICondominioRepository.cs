using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSecure.Domain.Models;
using SmartSecure.Domain.Models.SmartSecure;

namespace SmartSecure.Domain.Repositories
{
    public interface ICondominioRepository
    {
        Task<IEnumerable<Condominio>> ListAsync();
        Task AddAsync(Condominio condominio);
        Task<Condominio> FindById(int id);
        void Update(Condominio condominio);
        void Remove(Condominio condominio);
    }
}
