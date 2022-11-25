namespace Calculator.Model
{
    public class UnregisteredDiscountAmountCalculator : IDiscountAmountCalculator
    {
        public decimal Calculate(decimal amount, decimal discount)
        {
            return amount;
        }
    }
}