using SWAD_L4.Core.Entities;

namespace SWAD_L4.Core.Calculators
{
    public class PriceCalculatorContext
    {
        private readonly IPriceCalculatorStrategy _priceCalculatorStrategy;

        public PriceCalculatorContext(IPriceCalculatorStrategy priceCalculatorStrategy)
        {
            _priceCalculatorStrategy = priceCalculatorStrategy;
        }

        public decimal CalculatePrice(OrderEntity order)
        {
            return _priceCalculatorStrategy.CalculatePrice(order);
        }
    }
}