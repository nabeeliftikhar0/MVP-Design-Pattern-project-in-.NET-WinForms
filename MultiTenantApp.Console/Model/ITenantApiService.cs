using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiTenantApp.Console.Model
{
    public interface ITenantApiService
    {
        Task<IEnumerable<TenantData>> GetTenantDataAsync(string tenantId);
    }
} 