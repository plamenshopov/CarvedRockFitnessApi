using CarvedRockFitnessApi.Models;
using System;
using System.Collections.Generic;

namespace CarvedRockFitnessApi.Data
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetOrdersPlacedToday()
        {
            var stubbedOrders = new List<Order>();
            var random = new Random(1);

            var currencies = Enum.GetValues(typeof(Currency));

            for (var i = 0; i < 100; i++)
            {
                stubbedOrders.Add(
                    new Order(
                        (Currency)currencies.GetValue(random.Next(1, currencies.Length)),
                        new decimal(Math.Round(random.NextDouble() * 200, 2))
                    ));
            }

            return stubbedOrders;
        }
    }
}
