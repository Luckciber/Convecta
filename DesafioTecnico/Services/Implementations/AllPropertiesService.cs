using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class AllPropertiesService : IAllPropertiesService
    {
        private ApiService apiService;
        public AllPropertiesService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task GetAllProperties()
        {
            var response = await apiService.GetApiResponseAsync("properties");
        }
    }
}
