using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string baseUrl = "https://api-cnvct.azure-api.net/web/v1/info/";
        private readonly string subscriptionKey = "a79ccc326ad64ca999ed5cc5c5e4a07e";
        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
        }

        public async Task<string> GetApiResponseAsync(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw ex;
            }
        }
    }
}
