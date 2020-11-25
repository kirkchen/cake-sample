using System;
using Xunit;

namespace Library.Test
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void TotalPriceOver1000ShouldGet80PercentDiscount()
        {
            var totalPrice = 1200M;
            var expected = 960M;

            var actual = new DiscountCalculator().Calculate(totalPrice);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TotalPriceOver500ShouldGet90PercentDiscount()
        {
            var totalPrice = 600M;
            var expected = 540M;

            var actual = new DiscountCalculator().Calculate(totalPrice);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TotalPriceLessThan500ShouldNotGetDiscount()
        {
            var totalPrice = 300M;
            var expected = 300M;

            var actual = new DiscountCalculator().Calculate(totalPrice);
            
            Assert.Equal(expected, actual);
        }
    }
}
