using SmartSecure.Domain.Models.SmartSecure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Repositories.SmartSecure
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ListAsync();
        Task AddAsync(Usuario usuario);
        Task<Usuario> FindById(int id);
        void Update(Usuario usuario);
        void Remove(Usuario usuario);
    }
}
