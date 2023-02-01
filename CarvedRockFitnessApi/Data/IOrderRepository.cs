using System.Collections.Generic;

namespace CarvedRockFitnessApi.Data
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrdersPlacedToday();
    }
}
