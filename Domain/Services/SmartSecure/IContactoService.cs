using SmartSecure.Domain.Models;
using SmartSecure.Domain.Models.Accounts;
using SmartSecure.Domain.Services.SmartSecure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services
{
    public interface IContactoService
    {
        Task<IEnumerable<Contacto>> ListAsync();
        Task<IEnumerable<Contacto>> ListByUserIdAsync(int userId);
        Task<ContactoResponse> GetByIdAsync(int id);
        Task<ContactoResponse> SaveAsync(Contacto contacto);
        Task<ContactoResponse> UpdateAsync(int id, Contacto contacto);
        Task<ContactoResponse> DeleteAsync(int id);
    }
}
