using CarvedRockFitnessApi.Models;
using System;

namespace CarvedRockFitnessApi.Data
{
    public class Order
    {
        public Order(Currency currency, decimal price)
        {
            this.Currency = currency;
            this.Price = price;
        }

        public Currency Currency { get; }
        public decimal Price { get; }
    }
}
