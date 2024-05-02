using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CurrenciesService: ICurrenciesService
    {
        private ApiService apiService;
        public CurrenciesService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task GetCurrencies()
        {
            var response = await apiService.GetApiResponseAsync("currencies");
        }
    }
}
