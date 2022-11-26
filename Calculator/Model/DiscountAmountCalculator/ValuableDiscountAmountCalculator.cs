namespace Calculator.Model
{
    public class ValuableDiscountAmountCalculator : IDiscountAmountCalculator
    {
        public CustomerType CustomerType => CustomerType.Valuable;

        public decimal Calculate(decimal amount, decimal discount)
        {
            var result = (0.7m * amount) - discount * (0.7m * amount);
            return result;
        }
    }
}