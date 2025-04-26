namespace SWAD_L4.Core.Entities
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }
        public string NickName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
