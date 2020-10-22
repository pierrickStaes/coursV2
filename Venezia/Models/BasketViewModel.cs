using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Models
{
    public class BasketViewModel
    {
        public decimal Total { get; set; }
        public Dictionary<Car, int> Cars { get; set; } = new Dictionary<Car, int>();
    }
}
