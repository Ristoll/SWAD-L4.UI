namespace SWAD_L4.Core.Entities
{
    public class OrderZoneEntity
    {
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; } = null!;

        public int ZoneId { get; set; }
        public ZoneEntity Zone { get; set; } = null!;
    }
}
