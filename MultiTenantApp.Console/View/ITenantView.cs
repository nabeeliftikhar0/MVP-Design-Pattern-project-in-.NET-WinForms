using System.Collections.Generic;
using MultiTenantApp.Console.Model;

namespace MultiTenantApp.Console.View
{
    public interface ITenantView
    {
        string GetTenantId();
        void DisplayData(IEnumerable<TenantData> data);
        void DisplayError(string message);
    }
} 