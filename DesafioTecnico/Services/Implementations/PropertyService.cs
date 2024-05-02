using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class PropertyService : IPropertyService
    {
        private ApiService apiService;
        public PropertyService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task GetPropertyById()
        {
            var response = await apiService.GetApiResponseAsync("properties");
        }

        public async Task GetPropertyStates()
        {
            var response = await apiService.GetApiResponseAsync("property-states");
        }
        public async Task GetPropertyTypes()
        {
            var response = await apiService.GetApiResponseAsync("property-types");
        }
        public async Task GetPropertyTypesWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("property-types-with-properties");
        }
    }
}
