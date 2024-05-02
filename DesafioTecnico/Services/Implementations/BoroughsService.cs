using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class BoroughsService : IBoroughsService
    {
        private ApiService apiService;
        public BoroughsService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task GetBoroughs()
        {
            var response = await apiService.GetApiResponseAsync("boroughs");
        }

        public async Task GetBoroughsWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("boroughs-with-properties");
        }

    }
}
