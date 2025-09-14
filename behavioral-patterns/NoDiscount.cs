using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral_patterns
{
    public class NoDiscount : IDiscountStrategy
    {
        public string name => "No discount apply";
        public decimal Apply(decimal subtotal) => subtotal;
    }
}
