namespace Calculator.Model
{
    public class MostValuableDiscountAmountCalculator : IDiscountAmountCalculator
    {
        public CustomerType CustomerType => CustomerType.MostValuable;

        public decimal Calculate(decimal amount, decimal discount)
        {
            var result = (amount - (0.5m * amount)) - discount * (amount - (0.5m * amount));
            return result;
        }
    }
}