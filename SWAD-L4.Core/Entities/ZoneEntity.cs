namespace SWAD_L4.Core.Entities
{
    public class ZoneEntity
    {
        public int ZoneId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public ICollection<OrderZoneEntity> OrderZones { get; set; } = new List<OrderZoneEntity>();
    }

}
