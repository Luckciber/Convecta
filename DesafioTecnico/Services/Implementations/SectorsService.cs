using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class SectorsService : ISectorsService
    {
        private ApiService apiService;
        public SectorsService(ApiService apiService)
        {
            this.apiService = apiService;
        }
        public async Task GetSectors()
        {
            var response = await apiService.GetApiResponseAsync("sectors");
        }

        public async Task GetSectorsWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("sectors-with-properties");
        }

    }
}
