namespace Calculator.Model
{
    public class ByYearsDiscountPercentProvider : IDiscountPercentProvider
    {
        private readonly int _years;

        public ByYearsDiscountPercentProvider(int years)
        {
            this._years = years;
        }

        public decimal GetPercentDiscount()
        {
            return (decimal)_years / 100;
        }
    }
}