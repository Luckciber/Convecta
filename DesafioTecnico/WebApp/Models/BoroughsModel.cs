using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class BoroughsModel
    {
        public long IdBorough { get; set; }
        public string Name { get; set; }
        public long IdRegion { get; set; }
    }
}
