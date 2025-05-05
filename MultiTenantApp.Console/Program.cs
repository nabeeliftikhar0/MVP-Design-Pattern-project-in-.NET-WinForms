using System;
using System.Threading.Tasks;
using MultiTenantApp.Console.Model;
using MultiTenantApp.Console.Presenter;
using MultiTenantApp.Console.View;

namespace MultiTenantApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            System.Console.WriteLine("Multi-Tenant Application");
            System.Console.WriteLine("=======================");

            // Initialize components
            var view = new ConsoleTenantView();
            var apiService = new TenantApiService();
            var presenter = new TenantPresenter(view, apiService);

            // Run the application
            await presenter.LoadTenantDataAsync();

            System.Console.WriteLine("\nPress any key to exit...");
            System.Console.ReadKey();
        }
    }
}
