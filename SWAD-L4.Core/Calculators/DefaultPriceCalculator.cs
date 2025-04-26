using SWAD_L4.Core.Entities;

namespace SWAD_L4.Core.Calculators
{
    public class DefaultPriceCalculator : IPriceCalculatorStrategy
    {
        public decimal CalculatePrice(OrderEntity order)
        {
            decimal totalPrice = 0;

            totalPrice += order.Zones.Sum(z => z.Zone.Price);
            totalPrice += order.Attractions.Sum(a => a.Attraction.Price);
            totalPrice += order.Characters.Sum(c => c.Character.Price);


            return totalPrice;
        }
    }
}