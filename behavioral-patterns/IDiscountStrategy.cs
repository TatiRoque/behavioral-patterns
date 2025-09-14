using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral_patterns
{
    public interface IDiscountStrategy
    {
        decimal Apply (decimal subtotal);
        string name { get; }
    }
}
