using SmartSecure.Domain.Models.Accounts;
using System.Collections.Generic;
using SmartSecure.Domain.Services.Communications;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services.Accounts
{
    public interface ICondominioService
    {
        Task<IEnumerable<UserProfile>> ListAsync();
        Task<ProfileResponse> FindById(int userProfileId);
        Task<ProfileResponse> SaveAsync(UserProfile profile);
        Task<ProfileResponse> UpdateAsync(int id, UserProfile profile);
        Task<ProfileResponse> DeleteAsync(int id);
    }
}
