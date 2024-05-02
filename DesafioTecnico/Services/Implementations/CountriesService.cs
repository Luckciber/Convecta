using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CountriesService : ICountriesService
    {
        private ApiService apiService;
        public CountriesService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task GetCountries(){
            var response = await apiService.GetApiResponseAsync("countries");
        }

        public async Task GetCountriesWithProperties()
        {
            var response = await apiService.GetApiResponseAsync("countries-with-properties");
        }


    }
}
