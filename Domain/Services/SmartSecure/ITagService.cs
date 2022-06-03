using SmartSecure.Domain.Models;
using SmartSecure.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> ListAsync();
        Task<IEnumerable<Tag>> ListByUserIdAsync(int userId);
        Task<IEnumerable<Tag>> ListByTagIdAsync(int tafId);

    }
}
