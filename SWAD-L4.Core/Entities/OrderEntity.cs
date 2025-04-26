namespace SWAD_L4.Core.Entities
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public ProgramType ProgramType { get; set; }
        public decimal? TotalPrice { get; set; }

        public CustomerEntity? Customer { get; set; }
        public ICollection<OrderAttractionEntity> Attractions { get; set; } = new List<OrderAttractionEntity>();
        public ICollection<OrderZoneEntity> Zones { get; set; } = new List<OrderZoneEntity>();
        public ICollection<OrderCharacterEntity> Characters { get; set; } = new List<OrderCharacterEntity>();
    }
}
