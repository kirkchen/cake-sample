using System;

namespace Library
{
    public class DiscountCalculator
    {
        public decimal Calculate(decimal totalPrice)
        {
            if (totalPrice > 1000)
            {
                return totalPrice * 0.8M;
            }

            if (totalPrice > 500)
            {
                return totalPrice * 0.9M;
            }
            
            return totalPrice;
        }
    }
}