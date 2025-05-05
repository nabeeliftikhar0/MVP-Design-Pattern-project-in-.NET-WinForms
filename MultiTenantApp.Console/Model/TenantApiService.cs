using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultiTenantApp.Console.Model
{
    public class TenantApiService : ITenantApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com";

        public TenantApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<TenantData>> GetTenantDataAsync(string tenantId)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Remove("X-Tenant-ID");
                _httpClient.DefaultRequestHeaders.Add("X-Tenant-ID", tenantId);

                var response = await _httpClient.GetAsync($"{BaseUrl}/posts");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<TenantData>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<TenantData>();

                return data;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error fetching tenant data: {ex.Message}");
                throw;
            }
        }
    }
} 