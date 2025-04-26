namespace SWAD_L4.Core.Entities
{
    public class OrderAttractionEntity
    {
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; } = null!;

        public int AttractionId { get; set; }
        public AttractionEntity Attraction { get; set; } = null!;
    }
}