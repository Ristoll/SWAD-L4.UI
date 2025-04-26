namespace SWAD_L4.Core.Entities
{
    public class CharacterEntity
    {
        public int CharacterId { get; set; }
        public string CostumeName { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ICollection<OrderCharacterEntity> OrderCharacters { get; set; } = new List<OrderCharacterEntity>();
    }
}