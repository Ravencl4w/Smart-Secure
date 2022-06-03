using SmartSecure.Domain.Models;
using SmartSecure.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services
{
    public interface IPersonaService 
    {
        Task<IEnumerable<Persona>> ListAsync();
        Task<IEnumerable<Persona>> AnalizarPersona(int userId);
        
    }
}
