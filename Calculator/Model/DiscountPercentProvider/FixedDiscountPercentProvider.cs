namespace Calculator.Model
{
    public class FixedDiscountPercentProvider : IDiscountPercentProvider
    {
        public decimal GetPercentDiscount()
        {
            return (decimal)5 / 100;
        }
    }
}