using SmartSecure.Domain.Models.SmartSecure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Repositories.SmartSecure
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> ListAsync();
        Task AddAsync(Tag tag);
        Task<Tag> FindById(int id);
        void Update(Tag tag);
        void Remove(Tag tag);
    }
}
