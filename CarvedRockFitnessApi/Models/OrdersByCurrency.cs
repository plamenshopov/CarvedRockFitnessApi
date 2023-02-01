namespace CarvedRockFitnessApi.Models
{
    public class RevenueInCurrency
    {
        public RevenueInCurrency(Currency currency, decimal revenue)
        {
            this.Currency = currency;
            this.Revenue = revenue;
        }

        public Currency Currency { get; }
        public decimal Revenue { get; }
    }
}
