namespace SWAD_L4.Core.Entities
{
    public class AttractionEntity
    {
        public int AttractionId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ICollection<OrderAttractionEntity> OrderAttractions { get; set; } = new List<OrderAttractionEntity>();
    }
}
