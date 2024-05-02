using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class RegionsService : IRegionsService
    {
        private ApiService apiService;
        public RegionsService(ApiService apiService)
        {
            this.apiService = apiService;
        }
        public async Task GetRegions()
        {
            var response = await apiService.GetApiResponseAsync("regions");
        }

        public async Task GetRegionsWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("regions-with-properties");
        }
    }
}
