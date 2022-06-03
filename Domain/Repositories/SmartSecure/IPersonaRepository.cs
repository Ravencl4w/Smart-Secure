using SmartSecure.Domain.Models;
using SmartSecure.Domain.Models.SmartSecure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Repositories
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> ListAsync();
        Task AddAsync(Persona persona);
        Task<Persona> FindById(int id);
        void Update(Persona persona);
        void Remove(Persona persona);
    }
}
