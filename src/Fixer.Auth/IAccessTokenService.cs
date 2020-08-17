using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.Auth
{
    public interface IAccessTokenService
    {
        Task<bool> IsCurrentActiveToken();
        Task DeactivateCurrentAsync(string userId);
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(string userId, string token);
    }
}
