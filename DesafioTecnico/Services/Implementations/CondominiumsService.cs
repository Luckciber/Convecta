using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CondominiumsService : ICondominiumsService
    {
        private ApiService apiService;
        public CondominiumsService(ApiService apiService)
        {
            this.apiService = apiService;
        }
        public async Task GetCondominiums()
        {
            var response = await apiService.GetApiResponseAsync("condominiums");
        }

        public async Task GetCondominiumsWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("condominiums-with-properties");
        }
    }
}
