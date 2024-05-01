using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class CurrenciesModel
    {
        public long IdCurrency { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
