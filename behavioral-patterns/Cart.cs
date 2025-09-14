using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral_patterns
{
    public class Cart
    {
        private IDiscountStrategy discountStrategy;
        public Cart(IDiscountStrategy discountStrategy) => this.discountStrategy = discountStrategy;
        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            discountStrategy = strategy;
            Console.WriteLine($"Discount strategy changed to: {discountStrategy.name}");
        }
        public decimal Total(decimal subtotal) => discountStrategy.Apply(subtotal);
    }
}
