using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral_patterns
{
    public class BankCapDiscount : IDiscountStrategy
    {
        private readonly decimal discountAmount;
        private readonly decimal maxCap;
        public BankCapDiscount(decimal discountAmount, decimal maxCap) =>
            (this.discountAmount, this.maxCap) = (discountAmount, maxCap);

        public string name => $"Bank Cap Discount (up to {maxCap})";
        public decimal Apply(decimal subtotal) => subtotal - Math.Min(discountAmount, maxCap);
    }
}
