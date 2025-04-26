using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SWAD_L4.DAL.Services;

namespace SWAD_L4.DAL.Configurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.OrderId);            
            builder.Property(o => o.CustomerName).IsRequired().HasMaxLength(100);
            builder.Property(o => o.CustomerPhone).IsRequired().HasMaxLength(100);
            builder.Property(o => o.TotalPrice).HasPrecision(18, 2);

            builder.HasData(
            new OrderEntity
            {
                OrderId = 1,
                CustomerId = 1,
                CustomerName = "Олена",
                CustomerPhone = "0987654821",
                ProgramType = ProgramType.Birthday,
                Customer = new CustomerEntity
                {
                    CustomerId = 1,
                    NickName = "Олена",
                    PhoneNumber = "0987654821"
                }
            },
            new OrderEntity
            {
                OrderId = 2,
                CustomerId = 2,
                CustomerName = "Іван",
                CustomerPhone = "1234567860",
                ProgramType = ProgramType.Custom,
                Customer = new CustomerEntity
                {
                    CustomerId = 2,
                    NickName = "Іван",
                    PhoneNumber = "1234567860"
                }

            },
            new OrderEntity
            {
                OrderId = 3,
                CustomerId = 3,
                CustomerName = "Марія",
                CustomerPhone = "0987654341",
                ProgramType = ProgramType.Birthday,

                Customer = new CustomerEntity
                {
                    CustomerId = 3,
                    NickName = "Марія",
                    PhoneNumber = "0987654341"
                }
            },
            new OrderEntity
            {   
                OrderId = 4, 
                CustomerId = 4,
                CustomerName = "Андрій",
                CustomerPhone = "1234567890",
                ProgramType = ProgramType.Custom,
                Customer = new CustomerEntity
                {
                    CustomerId = 4,
                    NickName = "Андрій",
                    PhoneNumber = "1234567890"
                }
            },
            new OrderEntity
            {
                OrderId = 5,
                CustomerId = 5,
                CustomerName = "Наталя",
                CustomerPhone = "0987654321",
                ProgramType = ProgramType.Custom,
                Customer = new CustomerEntity
                {
                    CustomerId = 5,
                    NickName = "Наталя",
                    PhoneNumber = "0987654321"
                }
            }
        );
        }
    }
}