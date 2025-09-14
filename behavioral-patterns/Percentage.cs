using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral_patterns
{
    public class Percentage : IDiscountStrategy
    {
        private readonly decimal _percentage;
        public Percentage(decimal percentage) => _percentage = percentage;

        public string name => $"{_percentage}% off";
        public decimal Apply(decimal subtotal) => subtotal - (subtotal * _percentage / 100);
    }
}
