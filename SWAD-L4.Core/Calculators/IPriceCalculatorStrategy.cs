using SWAD_L4.Core.Entities;

namespace SWAD_L4.Core.Calculators
{
    public interface IPriceCalculatorStrategy
    {
        decimal CalculatePrice(OrderEntity order);
    }
}