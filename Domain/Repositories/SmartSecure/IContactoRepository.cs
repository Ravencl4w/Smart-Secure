using SmartSecure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Repositories
{
    public interface IContactoRepository
    {
        Task<IEnumerable<Contacto>> ListAsync();
        Task AddAsync(Contacto contacto);
        Task<Contacto> FindById(int id);
        void Update(Contacto contacto);
        void Remove(Contacto contacto);
    }
}
