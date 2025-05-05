using System;
using System.Threading.Tasks;
using MultiTenantApp.Console.Model;
using MultiTenantApp.Console.View;

namespace MultiTenantApp.Console.Presenter
{
    public class TenantPresenter
    {
        private readonly ITenantView _view;
        private readonly ITenantApiService _apiService;

        public TenantPresenter(ITenantView view, ITenantApiService apiService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
        }

        public async Task LoadTenantDataAsync()
        {
            try
            {
                var tenantId = _view.GetTenantId();

                if (string.IsNullOrWhiteSpace(tenantId))
                {
                    _view.DisplayError("Tenant ID cannot be empty");
                    return;
                }

                var data = await _apiService.GetTenantDataAsync(tenantId);
                _view.DisplayData(data);
            }
            catch (Exception ex)
            {
                _view.DisplayError($"Failed to load tenant data: {ex.Message}");
            }
        }
    }
} 