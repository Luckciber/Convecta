using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPropertyService
    {
        Task GetPropertyById();
        Task GetPropertyStates();
        Task GetPropertyTypes();
        Task GetPropertyTypesWithProperties();
    }
}
