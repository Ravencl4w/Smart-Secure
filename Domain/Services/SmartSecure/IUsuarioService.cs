using SmartSecure.Domain.Models.SmartSecure;
using SmartSecure.Domain.Services.SmartSecure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Services.SmartSecure
{
    public interface IUsurioService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest request);
        Task<IEnumerable<U>> ListAsync();
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
        Task<UserResponse> GetByIdAsync(int id);

        
    }
}
