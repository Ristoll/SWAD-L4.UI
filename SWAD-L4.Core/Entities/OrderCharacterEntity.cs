namespace SWAD_L4.Core.Entities
{
    public class OrderCharacterEntity
    {
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; } = null!;

        public int CharacterId { get; set; }
        public CharacterEntity Character { get; set; } = null!;
    }
}
