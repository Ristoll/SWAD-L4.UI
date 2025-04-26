using SWAD_L4.Core.Entities;
using SWAD_L4.Core.Calculators;
using Microsoft.EntityFrameworkCore;

namespace SWAD_L4.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<OrderEntity> _orderRepository;
        private readonly IDbContextFactory _dbContextFactory;
        private readonly IPriceCalculatorStrategy _priceCalculatorStrategy;

        public OrderService(
            IRepository<OrderEntity> orderRepository,
            IDbContextFactory dbContextFactory,
            IPriceCalculatorStrategy priceCalculatorStrategy)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _priceCalculatorStrategy = priceCalculatorStrategy ?? throw new ArgumentNullException(nameof(priceCalculatorStrategy));
        }

        // Створення звичайного замовлення
        public async Task<OrderEntity> CreateCustomOrderAsync(OrderEntity order)
        {
            await _orderRepository.AddAsync(order);
            return order;
        }

        // Створення замовлення на День народження
        public async Task<OrderEntity> CreateBirthdayOrderAsync()
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();

            var newOrder = new OrderEntity
            {
                Date = DateTime.Now,
                ProgramType = ProgramType.Birthday,
                Attractions = new List<OrderAttractionEntity>(),
                Characters = new List<OrderCharacterEntity>(),
                Zones = new List<OrderZoneEntity>()
            };

            await context.Set<OrderEntity>().AddAsync(newOrder);
            await context.SaveChangesAsync();

            var attractions = await context.Set<AttractionEntity>().Take(3).ToListAsync();
            var characters = await context.Set<CharacterEntity>().Take(2).ToListAsync();
            var zones = await context.Set<ZoneEntity>().Take(2).ToListAsync();

            var orderAttractions = attractions.Select(a => new OrderAttractionEntity
            {
                OrderId = newOrder.OrderId,
                AttractionId = a.AttractionId
            }).ToList();

            var orderCharacters = characters.Select(c => new OrderCharacterEntity
            {
                OrderId = newOrder.OrderId,
                CharacterId = c.CharacterId
            }).ToList();

            var orderZones = zones.Select(z => new OrderZoneEntity
            {
                OrderId = newOrder.OrderId,
                ZoneId = z.ZoneId
            }).ToList();

            await context.Set<OrderAttractionEntity>().AddRangeAsync(orderAttractions);
            await context.Set<OrderCharacterEntity>().AddRangeAsync(orderCharacters);
            await context.Set<OrderZoneEntity>().AddRangeAsync(orderZones);

            await context.SaveChangesAsync();

            return newOrder;
        }

        // Додавання атракціону до замовлення
        public async Task AddAttractionToOrderAsync(int orderId, int attractionId)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var order = await context.Set<OrderEntity>().FindAsync(orderId);

            if (order == null) throw new InvalidOperationException("Order not found.");

            var attraction = await context.Set<AttractionEntity>().FindAsync(attractionId);
            if (attraction == null) throw new InvalidOperationException("Attraction not found.");

            order.Attractions.Add(new OrderAttractionEntity
            {
                OrderId = orderId,
                AttractionId = attractionId
            });

            await context.SaveChangesAsync();
        }

        // Додавання героя до замовлення
        public async Task AddCharacterToOrderAsync(int orderId, int characterId)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var order = await context.Set<OrderEntity>().FindAsync(orderId);

            if (order == null) throw new InvalidOperationException("Order not found.");

            var character = await context.Set<CharacterEntity>().FindAsync(characterId);
            if (character == null) throw new InvalidOperationException("Character not found.");

            order.Characters.Add(new OrderCharacterEntity
            {
                OrderId = orderId,
                CharacterId = characterId
            });

            await context.SaveChangesAsync();
        }

        public async Task<OrderEntity> UpdateOrderAsync(OrderEntity order)
        {
            await _orderRepository.UpdateAsync(order);
            return order;
        }

        public async Task DeleteOrderAsync(int orderId)
        {
            await _orderRepository.DeleteAsync(orderId);
        }

        public async Task<decimal> CalculateOrderPriceAsync(int orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            return _priceCalculatorStrategy.CalculatePrice(order);
        }

        public async Task<OrderEntity> GetOrderByIdAsync(int orderId)
        {
            return await _orderRepository.GetByIdAsync(orderId);
        }
    }
}
